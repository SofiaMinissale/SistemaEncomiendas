using System;
namespace SistemaEncomiendas
{
	public class ConsultaEstadoCuenta
	{
        List<Envio> envios { get; set; }

        public ConsultaEstadoCuenta()
		{
		}

        public ConsultaEstadoCuenta(List<Envio> envios)
        {
            this.envios = envios;
        }

        public void mostrarEstado()
        {
            Console.WriteLine("El estado de cuenta de sus envios es:");
            Console.WriteLine("");
            var enviosConIndice = this.envios.Select((value, index) => (value, index));

            foreach (var item in enviosConIndice)
            {
                var index = item.index + 1;
                Envio envio = item.value;
                //"Usuario, FechaSolicitud, Numero de Orden, Importe, Estado del pago"

                Console.WriteLine($"{index} - Fecha: {envio.fechaCreacion.ToString("yyyy-MM-dd")}, Nro Orden: {envio.IdOrdenServicio}, Importe: ${envio.costo}, Estado: {envio.estadoPago}");
            }
            Console.WriteLine("");
            Console.WriteLine("------RESUMEN------");
            Console.WriteLine("");
            var enviosAgrupadosPorEstado = this.envios.GroupBy(envio => envio.estadoPago);
            foreach (var group in enviosAgrupadosPorEstado) {
                double importeGrupo = 0;
                foreach(Envio envio in group)
                    importeGrupo += envio.costo;

                Console.WriteLine($"Estado: {group.Key}, Importe: ${importeGrupo}");
            }
        }
    }
}

