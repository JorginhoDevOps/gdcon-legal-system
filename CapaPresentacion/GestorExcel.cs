using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CapaNegocio;
using MiniExcelLibs;

namespace CapaPresentacion
{
    public class ResultadoImportacionExcel
    {
        public int FilasLeidas { get; set; }
        public int Importados { get; set; }
        public int Despachados { get; set; }
        public int Omitidos { get; set; }
        public List<string> DetalleErrores { get; private set; }

        public ResultadoImportacionExcel()
        {
            DetalleErrores = new List<string>();
        }

        public string ConstruirResumen()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Resumen de importación desde Excel:");
            sb.AppendLine("• Filas procesadas: " + FilasLeidas);
            sb.AppendLine("• Trámites importados: " + Importados);
            if (Despachados > 0)
                sb.AppendLine("• Despachados automáticamente: " + Despachados);
            sb.AppendLine("• Filas omitidas (duplicadas o inválidas): " + Omitidos);

            if (DetalleErrores.Count > 0)
            {
                sb.AppendLine();
                sb.AppendLine("Detalle de observaciones:");
                int limite = Math.Min(DetalleErrores.Count, 10);
                for (int i = 0; i < limite; i++)
                    sb.AppendLine("- " + DetalleErrores[i]);

                if (DetalleErrores.Count > limite)
                    sb.AppendLine("... y " + (DetalleErrores.Count - limite) + " observación(es) más.");
            }

            return sb.ToString();
        }
    }

    public static class GestorExcel
    {
        public static ResultadoImportacionExcel ImportarTramites(
            string rutaArchivo,
            string empresaPorDefecto,
            bool despacharSiCompleto)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo) || !File.Exists(rutaArchivo))
                throw new FileNotFoundException("No se encontró el archivo Excel seleccionado.", rutaArchivo);

            string empresaBase = string.IsNullOrWhiteSpace(empresaPorDefecto)
                ? "IMCRUZ"
                : empresaPorDefecto.Trim();

            List<string> hojas = ObtenerHojas(rutaArchivo);
            if (hojas.Count == 0)
                throw new InvalidOperationException("El archivo Excel no contiene hojas legibles.");

            string hojaDatos = SeleccionarHojaDatos(hojas);
            string hojaReglas = BuscarHojaPorNombre(hojas, "REGLAS");
            List<KeyValuePair<string, string>> reglasClase = CargarReglasClase(rutaArchivo, hojaReglas);

            Tramites tramites = new Tramites();
            tramites.Archivo_VectorTramites();

            Empresas empresas = new Empresas();
            empresas.Archivo_VectorEmpresas();

            ResultadoImportacionExcel resultado = new ResultadoImportacionExcel();
            Dictionary<string, string> mapaColumnas = null;
            int numeroFila = 0;

            using (FileStream fs = AbrirSoloLecturaCompartida(rutaArchivo))
            {
                foreach (object filaObj in MiniExcel.Query(fs, useHeaderRow: false, sheetName: hojaDatos, excelType: ExcelType.XLSX))
                {
                    numeroFila++;
                    IDictionary<string, object> fila = filaObj as IDictionary<string, object>;
                    if (fila == null) continue;

                    if (mapaColumnas == null)
                    {
                        Dictionary<string, string> detectado = DetectarEncabezados(fila);
                        if (detectado != null)
                            mapaColumnas = detectado;
                        continue;
                    }

                    string chasis = LimpiarTexto(ObtenerValor(fila, mapaColumnas, "Chasis")).ToUpperInvariant();
                    string cliente = LimpiarTexto(ObtenerValor(fila, mapaColumnas, "Cliente"));
                    string poliza = LimpiarTexto(ObtenerValor(fila, mapaColumnas, "Poliza"));

                    // Ignora filas vacías o prenumeradas (como las filas 29..272 de GDCON.xlsm)
                    if (string.IsNullOrWhiteSpace(chasis) &&
                        string.IsNullOrWhiteSpace(cliente) &&
                        string.IsNullOrWhiteSpace(poliza))
                    {
                        continue;
                    }

                    resultado.FilasLeidas++;

                    string empresaFila = LimpiarTexto(ObtenerValor(fila, mapaColumnas, "Empresa"));
                    string empresaFinal = string.IsNullOrWhiteSpace(empresaFila) ? empresaBase : empresaFila;

                    string contrato = LimpiarTexto(ObtenerValor(fila, mapaColumnas, "NroContrato"));
                    string nitCi = LimpiarTexto(ObtenerValor(fila, mapaColumnas, "NitCi"));
                    string modalidad = NormalizarModalidad(LimpiarTexto(ObtenerValor(fila, mapaColumnas, "Modalidad")));
                    string marca = LimpiarTexto(ObtenerValor(fila, mapaColumnas, "Marca")).ToUpperInvariant();
                    string tipoVehiculo = LimpiarTexto(ObtenerValor(fila, mapaColumnas, "TipoVehiculo"));
                    object claseCruda = ObtenerValor(fila, mapaColumnas, "Clase");
                    string clase = ResolverClase(claseCruda, tipoVehiculo, reglasClase);
                    string anio = LimpiarTexto(ObtenerValor(fila, mapaColumnas, "Anio"));
                    string color = LimpiarTexto(ObtenerValor(fila, mapaColumnas, "Color"));

                    Tramite nuevo = new Tramite
                    {
                        Empresa = empresaFinal,
                        NroContrato = contrato,
                        Chasis = chasis,
                        NitCi = nitCi,
                        Cliente = cliente,
                        Poliza = poliza,
                        Modalidad = modalidad,
                        Marca = marca,
                        Clase = clase,
                        TipoVehiculo = tipoVehiculo,
                        Anio = anio,
                        Color = color,
                        Honorario = empresas.Honorario(empresaFinal, modalidad),
                        DespachoAlcaldia = false
                    };

                    List<KeyValuePair<string, string>> errores = tramites.Validar(nuevo, -1);
                    if (errores.Count > 0)
                    {
                        resultado.Omitidos++;
                        string idRef = string.IsNullOrWhiteSpace(chasis) ? "sin chasis" : chasis;
                        resultado.DetalleErrores.Add("Fila " + numeroFila + " (" + idRef + "): " + errores[0].Value);
                        continue;
                    }

                    tramites.Guardar(nuevo);
                    resultado.Importados++;

                    if (despacharSiCompleto)
                    {
                        int posGuardado = tramites.Cantidad() - 1;
                        string msgDespacho;
                        if (tramites.Despachar(posGuardado, out msgDespacho))
                            resultado.Despachados++;
                    }
                }
            }

            if (mapaColumnas == null)
                throw new InvalidOperationException(
                    "No se encontró una fila de encabezados válida en la hoja '" + hojaDatos +
                    "' (debe contener al menos la columna CHASIS).");

            if (resultado.Importados > 0)
                tramites.VectorTramites_Archivo();

            return resultado;
        }

        private static FileStream AbrirSoloLecturaCompartida(string ruta)
        {
            return new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        }

        private static List<string> ObtenerHojas(string rutaArchivo)
        {
            using (FileStream fs = AbrirSoloLecturaCompartida(rutaArchivo))
            {
                return MiniExcel.GetSheetNames(fs) ?? new List<string>();
            }
        }

        private static string SeleccionarHojaDatos(List<string> hojas)
        {
            string exacta = BuscarHojaPorNombre(hojas, "CONSOLIDADO TRAMITES DIARIOS");
            if (exacta != null) return exacta;

            foreach (string h in hojas)
            {
                string norm = NormalizarClave(h);
                if (norm.Contains("CONSOLIDADO") || norm.Contains("TRAMITE") || norm.Contains("RECEPCION"))
                    return h;
            }

            foreach (string h in hojas)
            {
                if (!string.Equals(h.Trim(), "REGLAS", StringComparison.OrdinalIgnoreCase))
                    return h;
            }

            return hojas[0];
        }

        private static string BuscarHojaPorNombre(List<string> hojas, string nombreBuscado)
        {
            foreach (string h in hojas)
            {
                if (string.Equals(h.Trim(), nombreBuscado, StringComparison.OrdinalIgnoreCase))
                    return h;
            }
            return null;
        }

        private static List<KeyValuePair<string, string>> CargarReglasClase(string rutaArchivo, string hojaReglas)
        {
            List<KeyValuePair<string, string>> reglas = new List<KeyValuePair<string, string>>();

            if (!string.IsNullOrEmpty(hojaReglas))
            {
                bool primeraFila = true;
                using (FileStream fs = AbrirSoloLecturaCompartida(rutaArchivo))
                {
                    foreach (object filaObj in MiniExcel.Query(fs, useHeaderRow: false, sheetName: hojaReglas, excelType: ExcelType.XLSX))
                    {
                        if (primeraFila) { primeraFila = false; continue; }

                        IDictionary<string, object> fila = filaObj as IDictionary<string, object>;
                        if (fila == null) continue;

                        string tipoVariante = LimpiarTexto(ObtenerPorClave(fila, "A")).ToUpperInvariant();
                        string tipoCorrecto = LimpiarTexto(ObtenerPorClave(fila, "B")).ToUpperInvariant();
                        string clase = LimpiarTexto(ObtenerPorClave(fila, "C")).ToUpperInvariant();

                        if (string.IsNullOrWhiteSpace(clase)) continue;

                        if (!string.IsNullOrWhiteSpace(tipoVariante))
                            reglas.Add(new KeyValuePair<string, string>(tipoVariante, clase));
                        if (!string.IsNullOrWhiteSpace(tipoCorrecto) &&
                            !string.Equals(tipoCorrecto, tipoVariante, StringComparison.OrdinalIgnoreCase))
                            reglas.Add(new KeyValuePair<string, string>(tipoCorrecto, clase));
                    }
                }
            }

            // Respaldo para modelos presentes en GDCON.xlsm sin clase asignada en la hoja REGLAS
            reglas.Add(new KeyValuePair<string, string>("JIMNY", "JEEP"));
            reglas.Add(new KeyValuePair<string, string>("ALL NEW T9", "CAMIONETA"));
            reglas.Add(new KeyValuePair<string, string>("T9", "CAMIONETA"));

            reglas.Sort((a, b) => b.Key.Length.CompareTo(a.Key.Length));
            return reglas;
        }

        private static Dictionary<string, string> DetectarEncabezados(IDictionary<string, object> fila)
        {
            Dictionary<string, string> mapa = new Dictionary<string, string>();

            foreach (KeyValuePair<string, object> par in fila)
            {
                string clave = NormalizarClave(LimpiarTexto(par.Value));
                if (clave == "") continue;

                if (clave == "CHASIS" || clave.Contains("CHASIS"))
                    AsignarSiNoExiste(mapa, "Chasis", par.Key);
                else if (clave.Contains("CONTRATO"))
                    AsignarSiNoExiste(mapa, "NroContrato", par.Key);
                else if (clave.Contains("CLIENTE") || clave.Contains("PROPIETARIO") || clave.Contains("COMPRADOR"))
                    AsignarSiNoExiste(mapa, "Cliente", par.Key);
                else if (clave.Contains("TIPO DE VENTA") || clave.Contains("MODALIDAD"))
                    AsignarSiNoExiste(mapa, "Modalidad", par.Key);
                else if (clave.Contains("NIT") || clave == "CI" || clave.Contains("CI NIT") || clave.Contains("DOCUMENTO"))
                    AsignarSiNoExiste(mapa, "NitCi", par.Key);
                else if (clave.Contains("POLIZA"))
                    AsignarSiNoExiste(mapa, "Poliza", par.Key);
                else if (clave.Contains("MARCA"))
                    AsignarSiNoExiste(mapa, "Marca", par.Key);
                else if (clave == "CLASE")
                    AsignarSiNoExiste(mapa, "Clase", par.Key);
                else if (clave.Contains("TIPO VEHICULO") || clave.Contains("TIPO DE VEHICULO") || clave == "MODELO")
                    AsignarSiNoExiste(mapa, "TipoVehiculo", par.Key);
                else if (clave == "ANO" || clave == "ANIO" || clave == "YEAR")
                    AsignarSiNoExiste(mapa, "Anio", par.Key);
                else if (clave == "COLOR")
                    AsignarSiNoExiste(mapa, "Color", par.Key);
                else if (clave == "EMPRESA" || clave.Contains("CONCESIONARIA"))
                    AsignarSiNoExiste(mapa, "Empresa", par.Key);
            }

            if (mapa.ContainsKey("Chasis") &&
                (mapa.ContainsKey("Cliente") || mapa.ContainsKey("Poliza") || mapa.ContainsKey("Modalidad")))
            {
                return mapa;
            }

            return null;
        }

        private static void AsignarSiNoExiste(Dictionary<string, string> mapa, string campo, string colExcel)
        {
            if (!mapa.ContainsKey(campo))
                mapa[campo] = colExcel;
        }

        private static object ObtenerValor(IDictionary<string, object> fila, Dictionary<string, string> mapa, string campo)
        {
            string colExcel;
            if (!mapa.TryGetValue(campo, out colExcel))
                return null;
            return ObtenerPorClave(fila, colExcel);
        }

        private static object ObtenerPorClave(IDictionary<string, object> fila, string clave)
        {
            object valor;
            return fila.TryGetValue(clave, out valor) ? valor : null;
        }

        private static string LimpiarTexto(object valor)
        {
            if (valor == null) return "";

            string texto;
            if (valor is double)
                texto = ((double)valor).ToString("0.################", CultureInfo.InvariantCulture);
            else if (valor is decimal)
                texto = ((decimal)valor).ToString("0.################", CultureInfo.InvariantCulture);
            else if (valor is float)
                texto = ((float)valor).ToString("0.########", CultureInfo.InvariantCulture);
            else if (valor is DateTime)
                texto = ((DateTime)valor).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            else
                texto = Convert.ToString(valor, CultureInfo.InvariantCulture) ?? "";

            texto = texto.Replace('\u00A0', ' ').Trim();
            if (texto.Length == 0) return "";

            StringBuilder sb = new StringBuilder(texto.Length);
            bool espacioPrevio = false;
            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];
                if (char.IsWhiteSpace(c))
                {
                    if (!espacioPrevio)
                    {
                        sb.Append(' ');
                        espacioPrevio = true;
                    }
                }
                else
                {
                    sb.Append(c);
                    espacioPrevio = false;
                }
            }
            return sb.ToString();
        }

        private static string NormalizarClave(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return "";
            string descompuesto = texto.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            bool espacioPrevio = true;

            for (int i = 0; i < descompuesto.Length; i++)
            {
                char c = descompuesto[i];
                UnicodeCategory cat = CharUnicodeInfo.GetUnicodeCategory(c);
                if (cat == UnicodeCategory.NonSpacingMark) continue;

                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(char.ToUpperInvariant(c));
                    espacioPrevio = false;
                }
                else if (!espacioPrevio)
                {
                    sb.Append(' ');
                    espacioPrevio = true;
                }
            }

            return sb.ToString().Trim();
        }

        private static string NormalizarModalidad(string texto)
        {
            string norm = NormalizarClave(texto);
            if (norm.Contains("CREDITO")) return "Crédito";
            if (norm.Contains("CONTADO")) return "Contado";
            return texto;
        }

        private static string ResolverClase(object claseCruda, string tipoVehiculo, List<KeyValuePair<string, string>> reglas)
        {
            if (!(claseCruda is DateTime))
            {
                string texto = LimpiarTexto(claseCruda);
                if (!string.IsNullOrWhiteSpace(texto) && !EsTextoFecha(texto))
                    return texto.ToUpperInvariant();
            }

            string tipoUpper = (tipoVehiculo ?? "").ToUpperInvariant();
            for (int i = 0; i < reglas.Count; i++)
            {
                if (tipoUpper.IndexOf(reglas[i].Key, StringComparison.OrdinalIgnoreCase) >= 0)
                    return reglas[i].Value;
            }

            return "VEHICULO";
        }

        private static bool EsTextoFecha(string texto)
        {
            DateTime dt;
            string[] formatos = { "dd.MM.yyyy", "d.M.yyyy", "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "yyyy-MM-dd" };
            return DateTime.TryParseExact(texto, formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);
        }
    }
}