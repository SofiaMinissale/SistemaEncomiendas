using System;
namespace SistemaEncomiendas
{
    public class Servicio
    {
        private const string estado = "En centro de Distribución";

        public string nombreUsuario { get; set; }
        public long cuit { get; set; }
        public double peso { get; set; }
        public string prioridad { get; set; }
        public string tipoEnvio { get; set; }
        public string sucursalOrigen { get; set; }
        public string direccionDestino { get; set; }
        public string DNIDestinatario { get; set; }
        public string nombreDestinatario { get; set; }
        public string apellidoDestinatario { get; set; }
        public int opcionSeleccionada { get; set; }
        public int numeroIntentos { get; set; }
        public string nroSeguimiento { get; set; }
        public int costoEnvio { get; set; }
        public string estadoOrden { get; set; }
        public string direccionOrigen { get; set; }
    }
}

