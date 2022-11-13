using System;
namespace SistemaEncomiendas
{
	public class Sucursal
	{

		private static string archivoSucursales = @"../../../sucursales.csv";

		public Sucursal()
		{
		}

		public Direccion Direccion { get; set; }

		public static List<Sucursal> listar()
        {
			var stream = File.OpenRead(archivoSucursales);
			var reader = new StreamReader(stream);

			var sucursales = new List<Sucursal>();

			var counter = 0;

			while (!reader.EndOfStream)
			{
				var linea = reader.ReadLine();

				if (counter > 0)
                {
					string[] datos = linea.Split(';');

					var sucursal = new Sucursal();
					var direccion = new Direccion();

					direccion.Region = datos[0];
					direccion.Provincia = datos[1];
					direccion.Localidad = datos[2];
					direccion.Calle = datos[3];

					if(datos.Length > 4)
                    {
						direccion.Altura = datos[4];

					}

					sucursal.Direccion = direccion;
					sucursales.Add(sucursal);

				}

				counter++;
			}

			stream.Close();

			return sucursales;
		}
	}
}

