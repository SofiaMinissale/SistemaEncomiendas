using System;
namespace SistemaEncomiendas
{
	public class Direccion
	{

		private static string archivoSucursales = @"../../../localidades.csv";


		public Direccion()
		{
		}

		public String Region { get; set; }
		public String Provincia { get; set; }
		public String Localidad { get; set; }
		public String Calle { get; set; }
		public String Altura { get; set; }

        public override string? ToString()
        {
			if (String.IsNullOrEmpty(this.Altura)) {
				return $"{this.Region},{this.Provincia},{this.Localidad},{this.Calle}";
			}  else
            {
				return $"{this.Region},{this.Provincia},{this.Localidad},{this.Calle},{this.Altura}";
			}
        }

        public String mostrar()
		{
			if (String.IsNullOrEmpty(this.Altura))
				return this.Calle;
			else
				return $"{this.Calle} {this.Altura}";
		}


		public static List<Direccion> listarLocalidades()
		{
			var stream = File.OpenRead(archivoSucursales);
			var reader = new StreamReader(stream);

			var sucursales = new List<Direccion>();

			var counter = 0;

			while (!reader.EndOfStream)
			{
				var linea = reader.ReadLine();

				if (counter > 0)
				{
					string[] datos = linea.Split(';');

					var direccion = new Direccion();
					direccion.Region = datos[0];
					direccion.Provincia = datos[1];
					direccion.Localidad = datos[2];

					sucursales.Add(direccion);

				}

				counter++;
			}

			stream.Close();

			return sucursales;
		}
	}
}

