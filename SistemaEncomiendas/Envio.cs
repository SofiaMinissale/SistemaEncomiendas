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
        public string tipoEnvio { get; set; }
        public string prioridad { get; set; }
        public string cuitUsuario { get; set; }
        public string estado { get; set; }

        public double peso { get; set; }

        public string origen { get; set; }
        public string destino { get; set; }

        public double costo { get; set; }
        public string estadoPago { get; set; }

        public int documenoDestinatario { get; set; }
        public string nombreDestinatario { get; set; }
        public string apellidoDestinatario { get; set;}

        public DateTime fechaCreacion { get; set; }

      
        private static string archivoDatosEnvios = "../../../envios.txt";

        public Envio()
        {
        }

        public Envio(
            string tipoEnvio,
            string prioridad,
            string cuitUsuario,
            string estado,
            double peso,
            string origen,
            string destino,
            double costo,
            int documenoDestinatario,
            string nombreDestinatario,
            string apellidoDestinatario
        )
        {
            this.tipoEnvio = tipoEnvio;
            this.prioridad = prioridad;

            this.cuitUsuario = cuitUsuario;

            this.estado = estado;

            this.peso = peso;

            this.origen = origen;
            this.destino = destino;

            this.costo = costo;

            this.documenoDestinatario = documenoDestinatario;
            this.nombreDestinatario = nombreDestinatario;
            this.apellidoDestinatario = apellidoDestinatario;

            this.estadoPago = "IMPAGO";
            this.fechaCreacion = DateTime.Now;    
        }

        public int calcularIdOrdenServicio()
        {

            var stream = File.OpenRead(archivoDatosEnvios);
            var reader = new StreamReader(stream);

            int ultimoID = 0;
            List<string> lineas = new List<string>();
            // Leemos el archivo y guardamos en memoria todas las lineas previas
            if (new FileInfo(archivoDatosEnvios).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    lineas.Add(linea);
                }
            }

            stream.Close();

            var cantidadEnvios = lineas.Count();
            if (cantidadEnvios > 1)
            {
                var ultimoEnvio = lineas.ElementAt(cantidadEnvios - 1);
                var datos = ultimoEnvio.Split(';');
                ultimoID = int.Parse(datos[0]);
            }

            int proximoID = ultimoID + 1;
            return proximoID;
        }

        public void cargarEnvioEnTXTEnvios()
        {

            this.IdOrdenServicio = this.calcularIdOrdenServicio();

            // Escribimos el nuevo envio
            using (StreamWriter writer = File.AppendText(archivoDatosEnvios))
            {
                String fechaCreacion = this.fechaCreacion.ToString("yyyy-MM-dd"); 
                var nuevoEnvio = $"{this.IdOrdenServicio};{this.cuitUsuario};{this.tipoEnvio};{this.prioridad};{this.estado};{this.peso};{this.origen};{this.destino};{this.costo};{this.documenoDestinatario};{this.nombreDestinatario};{this.apellidoDestinatario};{this.estadoPago};{fechaCreacion}";
                writer.WriteLine(nuevoEnvio);
                writer.Close();
            }
        }


        public static List<Envio> listarTodosLosEnvios()
        {
            var stream = File.OpenRead(archivoDatosEnvios);
            var reader = new StreamReader(stream);

            var envios = new List<Envio>();

            var counter = 0;

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                if (counter > 0)
                {
                    string[] datos = linea.Split(';');

                    Envio envio = new Envio();
                    envio.IdOrdenServicio = int.Parse(datos[0]);
                    envio.cuitUsuario = datos[1];
                    envio.tipoEnvio = datos[2];
                    envio.prioridad = datos[3];
                    envio.estado = datos[4];
                    envio.peso = double.Parse(datos[5]);
                    envio.origen = datos[6];
                    envio.destino = datos[7];
                    envio.costo = double.Parse(datos[8]);
                    envio.documenoDestinatario = int.Parse(datos[9]);
                    envio.nombreDestinatario = datos[10];
                    envio.apellidoDestinatario = datos[11];
                    envio.estadoPago = datos[12];
                    envio.fechaCreacion = DateTime.ParseExact(datos[13], "yyyy-MM-dd", null);

                    envios.Add(envio);
                }

                counter++;
            }

            stream.Close();

            return envios;
        }

        public static List<Envio> consultarEnvioCuitUsuario(String cuit)
        {
            List<Envio> envios = listarTodosLosEnvios();

            List<Envio> filtrados = envios.Where(envio => String.Equals(envio.cuitUsuario, cuit)).ToList();
            filtrados = filtrados.OrderBy(envio => envio.fechaCreacion).ToList();
            return filtrados;
        }




    }
}








