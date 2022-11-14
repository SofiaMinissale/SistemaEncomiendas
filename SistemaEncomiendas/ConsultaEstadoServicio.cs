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

        public string consultarEstadoSolicitud(int idEnvio)
        {
            this.mostrarEnvio();
            int numeroIngresado = 1;
            return traerEstadoEnvio(numeroIngresado);

        }

        private void mostrarEnvio()
        {

            Console.WriteLine("Ingrese el numero de la orden de servicio por la cual desea consultar");

          
        }

        private string traerEstadoEnvio(int numeroSeguimiento)
        {
            string estado = null;
            var stream = File.OpenRead(archivoDatosEnvios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (int.Parse(datos[0]).Equals(numeroSeguimiento))
                {
                    estado = datos[2];
                }
            }

            stream.Close();

            return estado;
        }

        public static void mostrarEstadoServicio(Envio envio)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("           ESTADO DE SERVICIO");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($" fecha de solicitud: {DateTime.Today}");
            Console.WriteLine($"* Numero de orden de servicio: ");
            Console.WriteLine($"* Estado de servicio: ");
            Console.WriteLine($"* Nombre y apellido del receptor:");
            Console.WriteLine($"* Destino:");
            Console.WriteLine("");

        }


    }
}
