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
        public string cuitUsuario { get; set; }
        public double peso { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string prioridad { get; set; }
        public double costo { get; set; }

        public string nombreDestinatario { get; set; }
        public string apellidoDestinatario { get; set;}
        public int documenoDestinatario { get; set; }


        private string archivoDatosEnvios = "../../../envios.txt";
        private string archivoDatosClientes = @"../../../clientes_corporativos.txt";

        public Envio(string estado, string cuitUsuario, double peso, string origen, string destino, int documentoReceptor)
        {
            this.estado = estado;
            this.cuitUsuario = cuitUsuario;
            this.peso = peso;
            this.origen = origen;
            this.destino = destino;
            this.documenoDestinatario = documentoReceptor;

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

            // Leemos el archivo y guardamos en memoria todas las lineas previas
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

            int id = 1;
            var conteoEnvios = lineas.Count();
            if (conteoEnvios > 1) {
                var ultimoEnvio = lineas.ElementAt(conteoEnvios - 1);
                id = int.Parse(ultimoEnvio.Split(';')[0]) + 1;
            }
            this.IdOrdenServicio = id;


            using (StreamWriter writer = File.AppendText(archivoDatosEnvios))
            {
                // Escribimos el nuevo envio
                var nuevoEnvio = $"{this.IdOrdenServicio};{this.cuitUsuario};{this.estado};{this.peso};{this.origen};{this.destino};{this.documenoDestinatario};{this.costo}";
                writer.WriteLine(nuevoEnvio);

                writer.Close();
            }

        }

        public void cargarEnvioEnTXTClientes(string nombreUsuario, int numeroSeguimientoNuevoEnvio)
        {

            //string estado = null;
            //var stream = File.OpenRead(archivoDatosClientes);
            //var reader = new StreamReader(stream);
            //int lineToEdit = 1;

            ////Datos a sobreescribir
            //string usuario = null;
            //string direccion = null;
            //string IdOrdenServicio = null;

            //while (!reader.EndOfStream)
            //{
            //    var linea = reader.ReadLine();

            //    string[] datos = linea.Split(';');

            //    if (datos[0].Equals(nombreUsuario))
            //    {
            //        usuario = datos[0];
            //        IdOrdenServicio = datos[1];
            //        break;
            //    }

            //    lineToEdit++;
            //}
            //stream.Close();
            //Utils.lineChanger($"{usuario};{direccion};{IdOrdenServicio}|{numeroSeguimientoNuevoEnvio}", archivoDatosClientes, lineToEdit);

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








