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

		public static String calculatTipoTarifa(String tipoEnvio, Direccion origen, Direccion destino)
        {
            String tipoTarifa = null;

            if (String.Equals(tipoEnvio, "Nacional"))
            {
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
            }
            else
            {
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
            }

            return tipoTarifa;
        }

        public static double calcularImporte(String tipoEnvio, Direccion origen, Direccion destino, double peso, String prioridad, bool retiroEnPuerta, bool entregaEnPuerta)
        {
            String tipoTarifa = Tarifa.calculatTipoTarifa(tipoEnvio, origen, destino);
            List<Tarifa> tarifas = Tarifa.listar();

            double importe = 0;

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

            if (String.Equals(prioridad, "URGENTE"))
            {
                double adicional = importe * 0.5;
                if (adicional > 15000)
                    importe = importe + 15000;
                else
                    importe = importe + adicional;
            }

            if (retiroEnPuerta)
            {
                importe = importe + 3500;
            }

            if (entregaEnPuerta)
            {
                importe = importe + 1500;
            }

            return importe;
        }

    }
}


