using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEncomiendas
{
    internal class EstadoCuenta
    {
        private string archivoDatosEnvios = "../../../envios.txt";



        List<Envio> envios { get; set; }

        public EstadoCuenta(List<Envio> envios)
        {
            this.envios = envios;
        }

        public void mostrarOpcionesCuenta()
        {
            Console.WriteLine("Sus envios son:");
            Console.WriteLine("");
            var enviosConIndice = this.envios.Select((value, index) => (value, index));
            foreach (var item in enviosConIndice)
            {
                var index = item.index + 1;
                Envio envio = item.value;
                Console.WriteLine($"{index} - Nro Seguimiento: {envio.IdOrdenServicio}, Fecha: {envio.fechaCreacion.ToString("yyyy-MM-dd")}");
            }
            Console.WriteLine("");
        }

        private void traerEstadoCuenta(int seleccion)
        {
            Envio envio = this.envios.ElementAt(seleccion - 1);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("        ESTADO DE CUENTA");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"  El detalle de tus ordenes de servicio: ");
            Console.WriteLine(" ");
            Console.WriteLine($" fecha de solicitud: {envio.fechaCreacion.ToString("yyyy-MM-dd")}");
            Console.WriteLine(" ");
            Console.WriteLine($"* Numero de orden de servicio: {envio.IdOrdenServicio}");
            Console.WriteLine($"importe: $");
            Console.WriteLine($"Estado del pago: A PAGAR");
            Console.WriteLine($"Total envios pendientes de facturacion: 0");
            Console.WriteLine($"Total envios impagos: 1");
            Console.WriteLine($"Total envios pagos:0");

        }


    }
}
