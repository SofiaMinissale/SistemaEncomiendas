using System;
namespace SistemaEncomiendas
{
    public class OrdenServicio
    {
        private static string INGRESADO_EN_SISTEMA = "Ingresado en sistema";
   
        public string nombreUsuario { get; set; }
        public long cuit { get; set; }
        public double peso { get; set; }
        public string prioridad { get; set; }
        public string tipoEnvio { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string DNIDestinatario { get; set; }
        public string nombreDestinatario { get; set; }
        public string apellidoDestinatario { get; set; }
        public int opcionSeleccionada { get; set; }
        public int numeroIntentos { get; set; }
        public string nroSeguimiento { get; set; }
        public int costoEnvio { get; set; }
        public string estadoOrden { get; set; }
        public string direccionOrigen { get; set; }


        public static Envio cargarDatos(ClienteCorporativo cliente)
        {
            int numeroIngresado;
            double peso;
            string prioridadPedido = null;
            string origen = null;
            string destino = null;
            string tipoEnvio = null;

            Console.WriteLine(" ");

            //PESO
            Console.WriteLine("Por favor, ingrese el peso de su envio(KG)");
            peso = Utils.solicitarPeso();
            Console.Clear();

            //PRIORIDAD DE ENVIO
            Console.WriteLine("Seleccione la prioridad que desea darle al envío");
            Console.WriteLine("1 - Normal");
            Console.WriteLine("2 - Urgente (48hs)");
            numeroIngresado = Utils.solcitarNumeroEntre(1, 2);
            switch (numeroIngresado)
            {
                case 1:
                    prioridadPedido = "NORMAL";
                    break;
                case 2:
                    prioridadPedido = "URGENTE";
                    break;
            }

            Console.Clear();

            //TIPO DE ENVIO 
            Console.WriteLine("Seleccione si el origen del envío es un domicilio particular o sucursal");
            Console.WriteLine("1 - Domicilio");
            Console.WriteLine("2 - Sucursal");
            numeroIngresado = Utils.solcitarNumeroEntre(1, 2);
            switch (numeroIngresado)
            {
                case 1:
                    tipoEnvio = "Domicilio";
                    break;
                case 2:
                    tipoEnvio = "Sucursal";
                    break;
            }


            //AGREGARIAMOS METODO PARA QUE EL USUARIO ELIJA SUCURSAL O DOMICILIO, ETC
            Console.Clear();
           

            //DIRECCION DESTINO Y DATOS DESTINATARIO

            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("SOLICITUD DE SERVICIO - DATOS DEL DESTINO");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");

            //TIPO DE ENVIO 
            Console.WriteLine("Seleccione si el alcance del envío es Nacional o Internacional");
            Console.WriteLine("1 -Nacional ");
            Console.WriteLine("2 - Internacional");
            numeroIngresado = Utils.solcitarNumeroEntre(1, 2);
            switch (numeroIngresado)
            {
                case 1:
                    prioridadPedido = "Domicilio";
                    break;
                case 2:
                    prioridadPedido = "Sucursal";
                    break;
            }

            //nombre
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese nombre del destinatario");
            string nombreReceptor;
            bool primerIntento = true;
            do
            {
                if (!primerIntento)
                {
                    Console.WriteLine("Por favor, ingrese un nombre valido ");
                }
                nombreReceptor = Console.ReadLine();
                primerIntento = false;
            }
            while (String.IsNullOrWhiteSpace(nombreReceptor));

            //apellido
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese el apellido del destinatario");
            string apellidoReceptor;
            primerIntento = true;
            do
            {
                if (!primerIntento)
                {
                    Console.WriteLine("Por favor, ingrese un apellido valido ");
                }
                apellidoReceptor = Console.ReadLine();
                primerIntento = false;
            }
            while (String.IsNullOrWhiteSpace(apellidoReceptor));

            //documento
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese el DNI, del destinatario");
            int documentoReceptor = Utils.solicitarDocumento();

            string nombreUsuario = cliente.nombreUsuario;
            Envio envio = new Envio(
               INGRESADO_EN_SISTEMA,
               nombreUsuario,
               peso,
               origen,
               destino,
               documentoReceptor
               );
            envio.cargarEnvioEnTXTEnvios();
            envio.cargarEnvioEnTXTClientes(cliente.nombreUsuario, envio.IdOrdenServicio);
            return envio;
        }

        public static void mostrarResumenSolicitud(Envio envio)
        { 
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("       RESUMEN DE SU SOLICITUD");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine($"* Tipo de envío: ");
            Console.WriteLine($"* Prioridad: ");
            Console.WriteLine($"* Origen: ");
            Console.WriteLine($"* Destino: SUCURSAL: ");
            Console.WriteLine($"* Nombre y apellido del receptor:{envio.nombreDestinatario}, {envio.apellidoDestinatario}");
            Console.WriteLine($"* DNI del receptor:{envio.documentoReceptor}");
            Console.WriteLine($"* Cotización del envío: ${envio.costo}");
            Console.WriteLine(" ");

        }

    }


}










