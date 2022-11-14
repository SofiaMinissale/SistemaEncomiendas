using System;
namespace SistemaEncomiendas
{
    public class DestinoInternacional
    {
        private static string archivoDestinoInternacional = @"../../../destinosInternacionales.csv";

        public DestinoInternacional()
        {
        }

        public Direccion Direccion { get; set; }

        public static List<DestinoInternacional> listar()
        {
            var stream = File.OpenRead(archivoDestinoInternacional);
            var reader = new StreamReader(stream);

            var destinosInternacionales = new List<DestinoInternacional>();

            var counter = 0;

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                if (counter > 0)
                {
                    string[] datos = linea.Split(';');

                    var destinoInternacional = new DestinoInternacional();
                    var direccion = new Direccion();
					direccion.Region = datos[0];
					direccion.Provincia = datos[1];
					direccion.Localidad = datos[2];
					direccion.Calle = "";
					direccion.Altura = "";


                    destinoInternacional.Direccion = direccion;
                    destinosInternacionales.Add(destinoInternacional);

                }

                counter++;
            }

            stream.Close();

            return destinosInternacionales;
        }
    }
}

