using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEncomiendas
{
    public class ConsultaEstadoServicio
    {

        List<Envio> envios { get; set; }

        public ConsultaEstadoServicio(List<Envio> envios) {
            this.envios = envios;
        }

        public void mostrarOpciones()
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

        public void mostrarEnvio(int seleccion)
        {
            Envio envio = this.envios.ElementAt(seleccion - 1);
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("           ESTADO DE SERVICIO");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Fecha: {envio.fechaCreacion.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Orden: {envio.IdOrdenServicio}");
            Console.WriteLine($"Estado: {envio.estado}");
            Console.WriteLine($"Destinatario: {envio.documenoDestinatario} - {envio.nombreDestinatario} {envio.apellidoDestinatario}");
            Console.WriteLine($"Destino: {envio.destino}");


        }
    }
}
