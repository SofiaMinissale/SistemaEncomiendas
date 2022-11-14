using System;
namespace SistemaEncomiendas
{
	public class CSVReader
	{
		public CSVReader()
		{
		}

		public static List<Dictionary<String, String>> read(String filename, String separator)
        {
			var stream = File.OpenRead(filename);
			var reader = new StreamReader(stream);

			List<Dictionary<String, String>> data = new List<Dictionary<String, String>>();
			List<String> keys = new List<string>();

			var counter = 0;
			while (!reader.EndOfStream)
			{
				var linea = reader.ReadLine();
				string[] datos = linea.Split(separator);

				// Leo el header del csv (los nombres de cada `columna`)
				if (counter == 0)
				{
					foreach(String key in datos)
                    {
						keys.Add(key);
                    }
				}
                else {
					Dictionary<String, String> row = new Dictionary<string, string>();

					foreach(var item in keys.Select((value, i) => new { i, value }))
                    {
						var index = item.i;
						var key = item.value;

						row.Add(key, datos[index]);
                    }

					data.Add(row);
				}

				counter++;
			}

			stream.Close();

			return data;
		}
	}
}

