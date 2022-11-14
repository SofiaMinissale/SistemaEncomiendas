using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEncomiendas
{
    internal class ConsultaEstadoServicio
    {
        public int numeroSeguimiento { get; set; }
        private string archivoDatosEnvios = "../../datos/envios.txt";

        public string consultarEstadoSolicitud()
        {
            mostrarOrdenServicio();
            int numeroIngresado = Utils.solicitarNumeroEnvioExistente();
            return traerEstadoEnvio(numeroIngresado);

        }
        private void mostrarOrdenServicio()
        {
            Console.WriteLine("Ingrese el numero de seguimiento de la orden de servicio que desea consultar");
        }

        private string traerEstadoEnvio(int numeroSeguimiento)
        {
            string estado = null;
            string direccion = null;
            string numeroOrdenServicio = null;
            var stream = File.OpenRead(archivoDatosEnvios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (int.Parse(datos[0]).Equals(numeroSeguimiento))
                {
                    estado = datos[2];
                    direccion = datos[5];
                    numeroOrdenServicio = datos[0];

                }
            }

            stream.Close();

            return ("Número orden de servicio:") + numeroOrdenServicio +
                   (", Estado Orden de Servicio:") + estado +
                   (", Localidad Destino:") + direccion;

        }

    }
}
