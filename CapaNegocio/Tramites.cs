using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;

namespace CapaNegocio
{
    public class Tramites
    {
        #region "ATRIBUTOS"
        Tramite[] VTramites = new Tramite[100];
        int Vis;
        #endregion

        #region "ESTADOS"
        public const string Recibido = "Recibido";
        public const string Despachado = "Despachado";
        public const string ConPlacaPago = "Con placa y pago";
        public const string EnTransito = "En tránsito";
        public const string Entregado = "Entregado";
        #endregion

        #region "CONSTRUCTOR"
        public Tramites()
        {
            Vis = -1;
        }
        #endregion

        #region "METODOS BASICOS"
        public void Incrementar()
        {
            Vis++;
        }
        public bool HayEspacio()
        {
            return Vis < VTramites.Length - 1;
        }
        public int Cantidad()
        {
            return Vis + 1;
        }
        public Tramite Obtener(int Pos)
        {
            if (Pos < 0 || Pos > Vis) return null;
            return VTramites[Pos];
        }

        // Busca por chasis, N° de trámite o NIT/CI. Devuelve la posición o -1.
        public int Buscar(string Texto)
        {
            if (string.IsNullOrWhiteSpace(Texto)) return -1;
            Texto = Texto.Trim();
            for (int V = 0; V <= Vis; V++)
                if (Igual(VTramites[V].Chasis, Texto) ||
                    Igual(VTramites[V].NroTramite, Texto) ||
                    Igual(VTramites[V].NitCi, Texto))
                    return V;
            return -1;
        }
        // Posiciones de los trámites que están en alguno de los estados indicados
        public List<int> Posiciones(params string[] Estados)
        {
            List<int> Lista = new List<int>();
            for (int V = 0; V <= Vis; V++)
                if (Array.IndexOf(Estados, VTramites[V].Estado) >= 0)
                    Lista.Add(V);
            return Lista;
        }
        public int BuscarChasis(string Chasis)
        {
            for (int V = 0; V <= Vis; V++)
                if (Igual(VTramites[V].Chasis, Chasis))
                    return V;
            return -1;
        }
        #endregion

        #region "RECEPCION (RF-01)"
      
        public List<KeyValuePair<string, string>> Validar(Tramite T, int PosActual)
        {
            List<KeyValuePair<string, string>> Errores = new List<KeyValuePair<string, string>>();

            if (Vacio(T.Empresa)) Errores.Add(Error("Empresa", "Selecciona la empresa."));
            if (Vacio(T.Chasis)) Errores.Add(Error("Chasis", "Ingresa el chasis."));
            if (Vacio(T.NitCi)) Errores.Add(Error("NitCi", "Ingresa el NIT / CI."));
            if (Vacio(T.Cliente)) Errores.Add(Error("Cliente", "Ingresa el nombre del cliente."));
            if (Vacio(T.Poliza)) Errores.Add(Error("Poliza", "Ingresa el N° de póliza."));
            if (Vacio(T.Modalidad)) Errores.Add(Error("Modalidad", "Selecciona la modalidad (Contado o Crédito)."));

            for (int V = 0; V <= Vis; V++)
            {
                if (V == PosActual) continue;
                if (!Vacio(T.Chasis) && Igual(VTramites[V].Chasis, T.Chasis))
                    Errores.Add(Error("Chasis", "Ya existe un trámite con ese chasis (" + VTramites[V].NroTramite + ")."));
                if (!Vacio(T.Poliza) && Igual(VTramites[V].Poliza, T.Poliza))
                    Errores.Add(Error("Poliza", "Ya existe un trámite con esa póliza (" + VTramites[V].NroTramite + ")."));
            }
            return Errores;
        }

        // Marca, clase, tipo, año y color: se pueden completar después, pero son
        // obligatorios para despachar.
        public bool DatosCompletos(Tramite T)
        {
            return !Vacio(T.Marca) && !Vacio(T.Clase) && !Vacio(T.TipoVehiculo) &&
                   !Vacio(T.Anio) && !Vacio(T.Color);
        }

        // Une Incrementar + Guardar: asigna N° de trámite, estado inicial "Recibido"
        // y fecha de ingreso. El estado inicial NUNCA lo elige el usuario (RN-01).
        public bool Guardar(Tramite T)
        {
            if (!HayEspacio()) return false;
            T.NroTramite = GenerarNroTramite();
            T.Estado = Recibido;
            T.FechaIngreso = DateTime.Now;
            T.Codigo = Vis + 2;
            Incrementar();
            VTramites[Vis] = T;
            return true;
        }

        public string GenerarNroTramite()
        {
            string Prefijo = "TRM-" + DateTime.Now.Year.ToString() + "-";
            int Max = 0;
            for (int V = 0; V <= Vis; V++)
            {
                string Nro = VTramites[V].NroTramite;
                int Secuencia;
                if (Nro != null && Nro.StartsWith(Prefijo) &&
                    int.TryParse(Nro.Substring(Prefijo.Length), out Secuencia) && Secuencia > Max)
                    Max = Secuencia;
            }
            return Prefijo + (Max + 1).ToString("0000");
        }

        // ¿Esta persona puede modificar este trámite?
        // Recibido: cualquiera. Después de Despachado: solo el Administrador.
        public bool PuedeModificar(int Pos, bool EsAdministrador)
        {
            if (Pos < 0 || Pos > Vis) return false;
            return VTramites[Pos].Estado == Recibido || EsAdministrador;
        }

        // Cambia solo los datos editables. N° de trámite, estado y fecha de ingreso nunca cambian.
        // Chasis, empresa, póliza, modalidad y honorario solo cambian mientras el trámite esté Recibido.
        public bool Modificar(int Pos, Tramite Nuevo, bool EsAdministrador)
        {
            if (!PuedeModificar(Pos, EsAdministrador)) return false;
            Tramite Ant = VTramites[Pos];

            if (Ant.Estado == Recibido)
            {
                Ant.Empresa = Nuevo.Empresa;
                Ant.Chasis = Nuevo.Chasis;
                Ant.Poliza = Nuevo.Poliza;
                Ant.Modalidad = Nuevo.Modalidad;
                Ant.Honorario = Nuevo.Honorario;
            }
            Ant.NitCi = Nuevo.NitCi;
            Ant.Cliente = Nuevo.Cliente;
            Ant.Marca = Nuevo.Marca;
            Ant.Clase = Nuevo.Clase;
            Ant.TipoVehiculo = Nuevo.TipoVehiculo;
            Ant.Anio = Nuevo.Anio;
            Ant.Color = Nuevo.Color;
            return true;
        }

        // Solo se elimina un trámite que todavía está Recibido.
        public bool Eliminar(int Pos)
        {
            if (Pos < 0 || Pos > Vis) return false;
            if (VTramites[Pos].Estado != Recibido) return false;
            for (int V = Pos; V < Vis; V++)
            {
                VTramites[V] = VTramites[V + 1];
                VTramites[V].Codigo = V + 1;
            }
            VTramites[Vis] = null;
            Vis--;
            return true;
        }

        // Recibido -> Despachado (casilla "Despacho a Alcaldía y Diprove")
        public bool Despachar(int Pos, out string Mensaje)
        {
            Mensaje = "";
            if (Pos < 0 || Pos > Vis) { Mensaje = "No hay un trámite seleccionado."; return false; }
            Tramite T = VTramites[Pos];
            if (T.Estado != Recibido) { Mensaje = "El trámite ya fue despachado."; return false; }
            if (!DatosCompletos(T))
            {
                Mensaje = "Completa marca, clase, tipo de vehículo, año y color antes de despachar.";
                return false;
            }
            T.Estado = Despachado;
            T.FechaDespacho = DateTime.Now;
            return true;
        }
        #endregion

        #region "PLACAS Y PAGOS (etapa 3): Despachado -> Con placa y pago"
        // C: registra placa, RUAT verificado y comprobante de pago
        public bool RegistrarPlacaPago(int Pos, string Placa, bool Ruat, string Comprobante, double Monto, out string Mensaje)
        {
            Mensaje = "";
            if (Pos < 0 || Pos > Vis) { Mensaje = "No hay un trámite seleccionado."; return false; }
            Tramite T = VTramites[Pos];
            if (T.Estado != Despachado)
            {
                Mensaje = "Solo se registran placa y pago de trámites Despachados (este está " + T.Estado + ").";
                return false;
            }
            if (!ValidarPlacaPago(Pos, Placa, Ruat, Comprobante, Monto, out Mensaje)) return false;
            AsignarPlacaPago(T, Placa, Ruat, Comprobante, Monto);
            T.Estado = ConPlacaPago;
            return true;
        }
        // U: corrige placa, monto o comprobante (mientras siga Con placa y pago)
        public bool ModificarPlacaPago(int Pos, string Placa, bool Ruat, string Comprobante, double Monto, out string Mensaje)
        {
            Mensaje = "";
            if (Pos < 0 || Pos > Vis) { Mensaje = "No hay un trámite seleccionado."; return false; }
            Tramite T = VTramites[Pos];
            if (T.Estado != ConPlacaPago)
            {
                Mensaje = "Solo se modifica mientras el trámite esté Con placa y pago (este está " + T.Estado + ").";
                return false;
            }
            if (!ValidarPlacaPago(Pos, Placa, Ruat, Comprobante, Monto, out Mensaje)) return false;
            AsignarPlacaPago(T, Placa, Ruat, Comprobante, Monto);
            return true;
        }
        // D: deshace la etapa y el trámite vuelve a Despachado
        public bool DeshacerPlacaPago(int Pos, out string Mensaje)
        {
            Mensaje = "";
            if (Pos < 0 || Pos > Vis) { Mensaje = "No hay un trámite seleccionado."; return false; }
            Tramite T = VTramites[Pos];
            if (T.Estado != ConPlacaPago)
            {
                Mensaje = "Solo se deshace si el trámite está Con placa y pago (este está " + T.Estado + ").";
                return false;
            }
            T.Placa = ""; T.Ruat = false; T.Comprobante = ""; T.MontoPago = 0; T.PagoRealizado = false;
            T.Estado = Despachado;
            return true;
        }
        bool ValidarPlacaPago(int Pos, string Placa, bool Ruat, string Comprobante, double Monto, out string Mensaje)
        {
            Mensaje = "";
            if (Vacio(Placa)) { Mensaje = "Ingresa la placa."; return false; }
            if (!Ruat) { Mensaje = "Falta verificar el RUAT."; return false; }
            if (Vacio(Comprobante)) { Mensaje = "Ingresa el N° de comprobante del banco."; return false; }
            if (Monto <= 0) { Mensaje = "El monto pagado debe ser mayor a cero."; return false; }
            for (int V = 0; V <= Vis; V++)
                if (V != Pos && Igual(VTramites[V].Placa, Placa))
                {
                    Mensaje = "Esa placa ya está asignada al trámite " + VTramites[V].NroTramite + ".";
                    return false;
                }
            return true;
        }
        void AsignarPlacaPago(Tramite T, string Placa, bool Ruat, string Comprobante, double Monto)
        {
            T.Placa = Placa.Trim();
            T.Ruat = Ruat;
            T.Comprobante = Comprobante.Trim();
            T.MontoPago = Monto;
            T.PagoRealizado = true;     // solo se registra con comprobante
        }
        #endregion

        #region "DIPROVE Y TRANSITO (etapa 4): Con placa y pago -> En tránsito"
        // C: registra el informe de Diprove y envía la carpeta a Tránsito
        public bool RegistrarTransito(int Pos, string Informe, DateTime FechaRetorno, out string Mensaje)
        {
            Mensaje = "";
            if (Pos < 0 || Pos > Vis) { Mensaje = "No hay un trámite seleccionado."; return false; }
            Tramite T = VTramites[Pos];
            if (T.Estado != ConPlacaPago)
            {
                Mensaje = "Solo se envían a Tránsito trámites Con placa y pago (este está " + T.Estado + ").";
                return false;
            }
            if (Vacio(Informe)) { Mensaje = "Ingresa el N° de informe de Diprove."; return false; }
            T.InformeDiprove = Informe.Trim();
            T.FechaRetorno = FechaRetorno;
            T.FechaEnvioTransito = DateTime.Now;
            T.Estado = EnTransito;
            return true;
        }
        // U: corrige informe o fecha (solo si la entrega todavía no empezó)
        public bool ModificarTransito(int Pos, string Informe, DateTime FechaRetorno, out string Mensaje)
        {
            Mensaje = "";
            if (Pos < 0 || Pos > Vis) { Mensaje = "No hay un trámite seleccionado."; return false; }
            Tramite T = VTramites[Pos];
            if (T.Estado != EnTransito || EntregaIniciada(T))
            {
                Mensaje = "Ya no se puede modificar: el trámite está " + T.Estado + " o la entrega ya empezó.";
                return false;
            }
            if (Vacio(Informe)) { Mensaje = "Ingresa el N° de informe de Diprove."; return false; }
            T.InformeDiprove = Informe.Trim();
            T.FechaRetorno = FechaRetorno;
            return true;
        }
        // D: deshace el envío y el trámite vuelve a Con placa y pago
        public bool DeshacerTransito(int Pos, out string Mensaje)
        {
            Mensaje = "";
            if (Pos < 0 || Pos > Vis) { Mensaje = "No hay un trámite seleccionado."; return false; }
            Tramite T = VTramites[Pos];
            if (T.Estado != EnTransito || EntregaIniciada(T))
            {
                Mensaje = "No se puede deshacer: el trámite está " + T.Estado + " o la entrega ya empezó.";
                return false;
            }
            T.InformeDiprove = ""; T.FechaRetorno = DateTime.MinValue; T.FechaEnvioTransito = DateTime.MinValue;
            T.Estado = ConPlacaPago;
            return true;
        }
        #endregion

        #region "ENTREGA FINAL (etapa 5): En tránsito -> Entregado"
        // Posición de cada requisito dentro del texto de 7 caracteres (0 = falta, 1 = listo)
        public const int ReqActaImpresa = 0;
        public const int ReqComprobanteCopia = 1;
        public const int ReqDocsIniciales = 2;
        public const int ReqResolucion = 3;
        public const int ReqPlacasMetalicas = 4;
        public const int ReqRuat = 5;
        public const int ReqPolizaOriginal = 6;

        public static bool Requisito(Tramite T, int Indice)
        {
            return T.Requisitos != null && T.Requisitos.Length > Indice && T.Requisitos[Indice] == '1';
        }
        public static bool EntregaCompleta(Tramite T)
        {
            return T.Requisitos == "1111111";
        }
        // ¿Ya hay un registro de entrega guardado?
        public static bool EntregaIniciada(Tramite T)
        {
            return !string.IsNullOrEmpty(T.Requisitos) || !string.IsNullOrWhiteSpace(T.EntregadoA);
        }

        // C/U: guarda los requisitos marcados y a quién se entrega (el trámite sigue En tránsito)
        public bool GuardarEntrega(int Pos, string Requisitos, string EntregadoA, out string Mensaje)
        {
            Mensaje = "";
            if (Pos < 0 || Pos > Vis) { Mensaje = "No hay un trámite seleccionado."; return false; }
            Tramite T = VTramites[Pos];
            if (T.Estado != EnTransito)
            {
                Mensaje = "Solo se registra la entrega de trámites En tránsito (este está " + T.Estado + ").";
                return false;
            }
            if (Requisitos == null || Requisitos.Length != 7)
            {
                Mensaje = "Los requisitos de entrega no son válidos.";
                return false;
            }
            T.Requisitos = Requisitos;
            T.EntregadoA = (EntregadoA ?? "").Trim();
            return true;
        }
        // D: deshace el registro de entrega (solo si todavía no se finalizó)
        public bool DeshacerEntrega(int Pos, out string Mensaje)
        {
            Mensaje = "";
            if (Pos < 0 || Pos > Vis) { Mensaje = "No hay un trámite seleccionado."; return false; }
            Tramite T = VTramites[Pos];
            if (T.Estado != EnTransito)
            {
                Mensaje = "Un trámite " + T.Estado + " no se puede deshacer.";
                return false;
            }
            T.Requisitos = "";
            T.EntregadoA = "";
            return true;
        }
        // En tránsito -> Entregado. Exige los 7 requisitos y a quién se entrega.
        public bool FinalizarEntrega(int Pos, out string Mensaje)
        {
            Mensaje = "";
            if (Pos < 0 || Pos > Vis) { Mensaje = "No hay un trámite seleccionado."; return false; }
            Tramite T = VTramites[Pos];
            if (T.Estado != EnTransito)
            {
                Mensaje = "Solo se finaliza un trámite En tránsito (este está " + T.Estado + ").";
                return false;
            }
            if (!EntregaCompleta(T)) { Mensaje = "Faltan requisitos por marcar."; return false; }
            if (Vacio(T.EntregadoA)) { Mensaje = "Indica a quién se entrega la carpeta."; return false; }
            T.Estado = Entregado;
            T.FechaEntrega = DateTime.Now;
            return true;
        }
        #endregion

        #region "SEMAFORO Y SITUACION"
        public static double Horas(Tramite T)
        {
            return (DateTime.Now - T.FechaIngreso).TotalHours;
        }

        // Verde hasta 24 h, Ámbar de 24 a 48 h, Rojo más de 48 h. Un trámite entregado ya no corre.
        public static string Semaforo(Tramite T)
        {
            if (T.Estado == Entregado) return "Entregado";
            double H = Horas(T);
            if (H <= 24) return "Verde";
            if (H <= 48) return "Ámbar";
            return "Rojo";
        }

        // Texto para la columna Estado de la grilla de Recepción
        public string Situacion(Tramite T)
        {
            if (T.Estado != Recibido) return T.Estado;
            if (!DatosCompletos(T)) return "Recibido · Datos incompletos";
            return "Recibido · Pendiente de despacho";
        }
        #endregion

        #region "MOSTRAR"
        // Grilla de Recepción. Columnas: Chasis, Cliente, Modalidad, Marca, Póliza, Ingreso, Estado
        public void MostrarRecepcion(DataGridView Dgv)
        {
            try
            {
                Dgv.RowCount = Vis + 1;
            }
            catch
            {
                Dgv.RowCount = 1;
            }
            for (int V = 0; V <= Vis; V++)
            {
                Dgv[0, V].Value = VTramites[V].Chasis;
                Dgv[1, V].Value = VTramites[V].Cliente;
                Dgv[2, V].Value = VTramites[V].Modalidad;
                Dgv[3, V].Value = VTramites[V].Marca;
                Dgv[4, V].Value = VTramites[V].Poliza;
                Dgv[5, V].Value = VTramites[V].FechaIngreso.ToString("dd/MM/yyyy HH:mm");
                Dgv[6, V].Value = Situacion(VTramites[V]);
            }
        }
        #endregion

        #region "ARCHIVO JSON"
        string Archivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "Tramites.json");
        JsonSerializerOptions OpcionesJson = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true
        };

        public void VectorTramites_Archivo()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Archivo));
            List<Tramite> Lista = new List<Tramite>();
            for (int V = 0; V <= Vis; V++)
                Lista.Add(VTramites[V]);

            string Json = JsonSerializer.Serialize(Lista, OpcionesJson);
            File.WriteAllText(Archivo, Json);
        }

        public void Archivo_VectorTramites()
        {
            Vis = -1;
            if (!File.Exists(Archivo))
            {
                CrearArchivo();
                return;
            }
            try
            {
                string Json = File.ReadAllText(Archivo);
                List<Tramite> Lista = JsonSerializer.Deserialize<List<Tramite>>(Json, OpcionesJson);
                if (Lista != null)
                {
                    for (int I = 0; I < Lista.Count; I++)
                    {
                        if (!HayEspacio()) break;
                        Incrementar();
                        VTramites[Vis] = Lista[I];
                    }
                }
            }
            catch
            {
                CrearArchivo();
            }
        }

        public void CrearArchivo()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Archivo));
            File.WriteAllText(Archivo, "[]");
        }
        #endregion

        #region "DATOS DE PRUEBA"
        // Agrega 5 trámites ficticios, uno en cada punto del recorrido, para probar todas las pantallas.
        // 0 = Recibido incompleto, 1 = Recibido completo, 2 = Despachado, 3 = Con placa y pago, 4 = En tránsito
        public void CargarDemo()
        {
            AgregarDemo("CHASIS-DEMO-001", "POL-DEMO-001", "Cliente de ejemplo 1", "Contado", 0, 5);
            AgregarDemo("CHASIS-DEMO-002", "POL-DEMO-002", "Cliente de ejemplo 2", "Crédito", 2, 30);
            AgregarDemo("CHASIS-DEMO-003", "POL-DEMO-003", "Cliente de ejemplo 3", "Contado", 3, 60);
            AgregarDemo("CHASIS-DEMO-004", "POL-DEMO-004", "Cliente de ejemplo 4", "Contado", 4, 40);
            AgregarDemo("CHASIS-DEMO-005", "POL-DEMO-005", "Cliente de ejemplo 5", "Crédito", 4, 20);
        }

        void AgregarDemo(string Chasis, string Poliza, string Cliente, string Modalidad, int Nivel, int HorasAtras)
        {
            if (!HayEspacio() || BuscarChasis(Chasis) >= 0) return;
            Tramite T = new Tramite();
            T.Empresa = "IMCRUZ";
            T.Chasis = Chasis;
            T.Poliza = Poliza;
            T.Cliente = Cliente;
            T.NitCi = "0000000";
            T.Modalidad = Modalidad;
            T.Honorario = Modalidad == "Crédito" ? 1100 : 900;
            if (Nivel >= 1)
            {
                T.Marca = "MARCA DE EJEMPLO";
                T.Clase = "VAGONETA";
                T.TipoVehiculo = "SUV";
                T.Anio = "2026";
                T.Color = "BLANCO";
            }
            Guardar(T);
            T.FechaIngreso = DateTime.Now.AddHours(-HorasAtras);
            int Pos = Vis;
            string Msg;
            string Numero = Chasis.Substring(Chasis.Length - 3);
            if (Nivel >= 2) Despachar(Pos, out Msg);
            if (Nivel >= 3) RegistrarPlacaPago(Pos, "1" + Numero + "DEM", true, "COMP-" + Numero, 650, out Msg);
            if (Nivel >= 4) RegistrarTransito(Pos, "DIP-DEMO-" + Numero, DateTime.Now, out Msg);
        }
        #endregion

        #region "AUXILIARES"
        static bool Vacio(string Texto)
        {
            return string.IsNullOrWhiteSpace(Texto);
        }
        static bool Igual(string A, string B)
        {
            return string.Equals((A ?? "").Trim(), (B ?? "").Trim(), StringComparison.OrdinalIgnoreCase);
        }
        static KeyValuePair<string, string> Error(string Campo, string Mensaje)
        {
            return new KeyValuePair<string, string>(Campo, Mensaje);
        }
        static string L(string Texto)
        {
            if (Texto == null) return "";
            return Texto.Replace("*", " ").Replace("\r", " ").Replace("\n", " ");
        }
        static string F(DateTime Fecha)
        {
            return Fecha == DateTime.MinValue ? "" : Fecha.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
        }
        static DateTime D(string Texto)
        {
            DateTime Fecha;
            if (DateTime.TryParseExact(Texto, "yyyyMMddHHmmss", CultureInfo.InvariantCulture, DateTimeStyles.None, out Fecha))
                return Fecha;
            return DateTime.MinValue;
        }
        static string N(double Numero)
        {
            return Numero.ToString(CultureInfo.InvariantCulture);
        }
        static double Num(string Texto)
        {
            double Numero;
            if (double.TryParse(Texto, NumberStyles.Float, CultureInfo.InvariantCulture, out Numero))
                return Numero;
            return 0;
        }
        static string B(bool Valor)
        {
            return Valor ? "1" : "0";
        }
        static string G(string[] S, int Indice)
        {
            return Indice < S.Length ? S[Indice] : "";
        }
        #endregion
    }
}
