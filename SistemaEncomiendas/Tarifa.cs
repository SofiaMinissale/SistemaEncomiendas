using System;
namespace SistemaEncomiendas
{
	public class Tarifa
	{
		private static string archivoTarifas = @"../../../tarifas.csv";

		public Tarifa()
		{
		}

		public String Tipo { get; set; }
		public String Peso { get; set; }
		public String Importe { get; set; }

		public static List<Tarifa> listar()
		{
			List<Dictionary<String,String>> rows = CSVReader.read(archivoTarifas, ";");

			List<Tarifa> tarifas = rows.Select(row => new Tarifa()
			{
				Tipo = row["tipo"],
				Peso = row["peso"],
				Importe = row["importe"]
			}
			).ToList<Tarifa>();

			return tarifas;
		}

        public static String calcularTipoTarifaNacional(Direccion origen, Direccion destino)
        {
            String tipoTarifa = null;

            if (String.Equals(origen.Region, destino.Region))
            {
                if (String.Equals(origen.Provincia, destino.Provincia))
                {
                    if (String.Equals(origen.Localidad, destino.Localidad))
                        tipoTarifa = "local";
                    else
                        tipoTarifa = "provincial";
                }
                else
                    tipoTarifa = "regional";
            }
            else
                tipoTarifa = "nacional";

            return tipoTarifa;
        }

        public static String calcularTipoTarifaInternacional(Direccion destino)
        {
            String tipoTarifa = null;

            switch (destino.Region)
            {
                case "Limitrofe":
                    tipoTarifa = "limitrofes";
                    break;
                case "America Latina":
                    tipoTarifa = "resto america latina";
                    break;
                case "America del Norte":
                    tipoTarifa = "america del norte";
                    break;
                case "Europa":
                    tipoTarifa = "europa";
                    break;
                case "Asia":
                    tipoTarifa = "asia";
                    break;
            }

            return tipoTarifa;
        }

        public static double calcularImporteTarifa(String tipoTarifa, double peso)
        {
            double importe = 0;
            List<Tarifa> tarifas = Tarifa.listar();
            var tarifasAgrupadas = tarifas.GroupBy(tarifa => tarifa.Tipo);

            foreach (var group in tarifasAgrupadas)
            {
                if (String.Equals(group.Key, tipoTarifa))
                {
                    var orderedGroup = group.OrderBy(x => double.Parse(x.Peso));
                    foreach (Tarifa tarifa in orderedGroup)
                    {
                        double pesoTarifa = double.Parse(tarifa.Peso);
                        if (peso <= pesoTarifa)
                        {
                            importe = double.Parse(tarifa.Importe);
                            break;
                        }
                    }
                    break;
                }
            }

            return importe;
        }

        public static double calcularAdicionales(double importe, String prioridad, bool retiroEnPuerta, bool entregaEnPuerta)
        {
            if (String.Equals(prioridad, "URGENTE"))
            {
                double adicional = importe * 0.5;
                if (adicional > 15000)
                    importe = importe + 15000;
                else
                    importe = importe + adicional;
            }

            if (retiroEnPuerta)
                importe = importe + 3500;

            if (entregaEnPuerta)
                importe = importe + 1500;

            return importe;
        }

        public static double calcularCostoTotal(String tipoEnvio, Direccion origen, Direccion destino, double peso, String prioridad, bool retiroEnPuerta, bool entregaEnPuerta)
        {
            double importe = 0;

            if(String.Equals(tipoEnvio, "Nacional"))
            {
                String tipoTarifa = calcularTipoTarifaNacional(origen, destino);
                importe = calcularImporteTarifa(tipoTarifa, peso);
            } else
            {
                Direccion destinoIntermedioCABA = new Direccion();
                destinoIntermedioCABA.Region = "Metropolitana";
                destinoIntermedioCABA.Provincia = "CABA";
                destinoIntermedioCABA.Localidad = "Ciudad de Buenos Aires";

                String tipoTarifaNacional = calcularTipoTarifaNacional(origen, destinoIntermedioCABA);
                double importeNacional = calcularImporteTarifa(tipoTarifaNacional, peso);

                String tipoTarifaInternacional = calcularTipoTarifaInternacional(destino);
                double importeInternacional = calcularImporteTarifa(tipoTarifaInternacional, peso);

                importe = importeNacional + importeInternacional;
            }

            double importeTotal = calcularAdicionales(importe, prioridad, retiroEnPuerta, entregaEnPuerta);
            return importeTotal;
        }


    }
}


