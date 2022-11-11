using System;
namespace SistemaEncomiendas
{
	public class Tarifa
	{
		public Tarifa()
		{
		}

		public String Tipo { get; set; }
		public double Peso { get; set; }
		public decimal Importe { get; set; }

		//CSV
		//Tipo, pesoMax, importe
		//local, 0,5, 350
		//local, 10, 3500
		//local, 20, 4200
		//local, 30, 5250
		//provincial, 0,5, 550
		//provincial, 10, 5500
		//provincial, 20, 6600
		//provincial, 30, 8250
		//regional, 0,5, 750
		//regional, 10, 7500
		//regional, 20, 9000
		//regional, 30, 11250
		//nacional, 0,5, 950
		//nacional, 10, 9500
		//nacional, 20, 11400
		//nacional, 30, 14250
		//limitrofes, 0,5, 1620
		//limitrofes, 10, 16200
		//limitrofes, 20, 19440
		//limitrofes, 30, 24300
		//resto america latina, 0,5, 2900
		//resto america latina, 10, 29000
		//resto america latina, 20, 34800
		//resto america latina, 30, 43500
		//america del norte, 0,5, 5400
		//america del norte, 10, 54000
		//america del norte, 20, 64800
		//america del norte, 30, 81000
		//europa, 0,5, 8200
		//europa, 10, 82000
		//europa, 20, 98400
		//europa, 30, 123000
		//asia, 0,5, 12000
		//asia, 10, 120000
		//asia, 20, 144000
		//asia, 30, 180000
	}
}

