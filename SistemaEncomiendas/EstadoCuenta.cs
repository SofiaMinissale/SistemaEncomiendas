using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEncomiendas
{
    internal class EstadoCuenta
    {
        private string archivoDatosEnvios = "../../datos/Cuenta.txt";

        public string consultar(List<string> envio)
        {
            traerEstadoCuenta(envio);
            return archivoDatosEnvios;

        }
        private void traerEstadoCuenta(List<string> envio)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("        ESTADO DE CUENTA");
            Console.WriteLine("------------------------------------------");


            Console.WriteLine($" Nicolas Martinez, El detalle de tus ordenes de servicio: ");
            Console.WriteLine(" ");
            Console.WriteLine($" fecha de solicitud: {DateTime.Today}");
            Console.WriteLine(" ");
            Console.WriteLine($"* Numero de orden de servicio: ");
            Console.WriteLine($"importe: $");
            Console.WriteLine($"Estado del pago: A PAGAR");
            Console.WriteLine($"Total envios pendientes de facturacion: 0");
            Console.WriteLine($"Total envios impagos: 1");
            Console.WriteLine($"Total envios pagos:0");


        }

    }
}
