using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEncomiendas
{

    public class Envio
    {
        public int IdOrdenServicio { get; set; }
        public string estado { get; set; }
        public string nombreUsuario { get; set; }
        public double peso { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public int documentoReceptor { get; set; }
        public string prioridad { get; set; }
        public string correoElectronicoReceptor { get; set; }
        public double costo { get; set; }

        public string nombreDestinatario { get; set; }

        public string apellidoDestinatario { get; set;}


        private string archivoDatosEnvios = "../../datos/Envios.txt";
        private string archivoDatosClientes = @"../../datos/ClienteCorporativo.txt";

        public Envio(string estado, string nombreUsuario, double peso, string origen, string destino, int documentoReceptor)
        {
            this.estado = estado;
            this.nombreUsuario = nombreUsuario;
            this.peso = peso;
            this.origen = origen;
            this.destino = destino;
            this.documentoReceptor = documentoReceptor;

        }

        public void asignarNumeroDeSeguimiento()
        {
            int numeroSeguimiento = 0;
            var stream = File.OpenRead(archivoDatosEnvios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (int.Parse(datos[0]) > IdOrdenServicio)
                {
                    IdOrdenServicio = (int.Parse(datos[0]));
                }
            }

            stream.Close();

            this.IdOrdenServicio = numeroSeguimiento + 1;
        }

        public void cargarEnvioEnTXTEnvios()
        {

            var stream = File.OpenRead(archivoDatosEnvios);
            var reader = new StreamReader(stream);

            List<string> lineas = new List<string>();

            if (new FileInfo(archivoDatosEnvios).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    lineas.Add(linea);
                }
            }

            stream.Close();


            using (StreamWriter writer = new StreamWriter(archivoDatosEnvios))
            {
                foreach (string linea in lineas)
                {
                    writer.WriteLine(linea);
                }
                writer.WriteLine(this.IdOrdenServicio + ";"
                    + this.nombreUsuario + ";"
                    + this.estado + ";"
                    + this.peso + ";"
                    + this.costo);

                writer.Close();
            }

        }

        public void cargarEnvioEnTXTClientes(string nombreUsuario, int numeroSeguimientoNuevoEnvio)
        {

            string estado = null;
            var stream = File.OpenRead(archivoDatosClientes);
            var reader = new StreamReader(stream);
            int lineToEdit = 1;

            //Datos a sobreescribir
            string usuario = null;
            string direccion = null;
            string IdOrdenServicio = null;

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (datos[0].Equals(nombreUsuario))
                {
                    usuario = datos[0];
                    IdOrdenServicio = datos[1];
                    break;
                }

                lineToEdit++;
            }
            stream.Close();
            Utils.lineChanger($"{usuario};{direccion};{IdOrdenServicio}|{numeroSeguimientoNuevoEnvio}", archivoDatosClientes, lineToEdit);

        }

        public void consultarEnvio()
        {
            int numeroSeguimiento = 0;
            var stream = File.OpenRead(archivoDatosEnvios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (int.Parse(datos[0]) > numeroSeguimiento)
                {
                    //Obtengo el ultimo numero de seguimiento asignado a un pedido
                    IdOrdenServicio = (int.Parse(datos[0]));
                }
            }

            stream.Close();

            this.IdOrdenServicio = IdOrdenServicio + 1;
        }

       

    }
}








