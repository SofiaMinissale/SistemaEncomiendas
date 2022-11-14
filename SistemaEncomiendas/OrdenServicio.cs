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
            string prioridad = null;

            Direccion origen = null;
            Direccion destino = null; ;

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
                    prioridad = "NORMAL";
                    break;
                case 2:
                    prioridad = "URGENTE";
                    break;
            }

            Console.Clear();

            // CARGA DE ORIGEN 
            Console.WriteLine("Seleccione si el origen del envío es un domicilio particular o sucursal");
            Console.WriteLine("1 - Domicilio");
            Console.WriteLine("2 - Sucursal");
            numeroIngresado = Utils.solcitarNumeroEntre(1, 2);
            switch (numeroIngresado)
            {
                case 1:
                    origen = cargarDireccionNacional();
                    break;
                case 2:
                    origen = seleccionarSucursal();
                    break;
            }

            Console.Clear();
           
            //DIRECCION DESTINO Y DATOS DESTINATARIO

            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("SOLICITUD DE SERVICIO - DATOS DEL DESTINO");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");

            //TIPO DE ENVIO 
            Console.WriteLine("Seleccione si el alcance del envío es Nacional o Internacional");
            Console.WriteLine("1 - Nacional ");
            Console.WriteLine("2 - Internacional");
            numeroIngresado = Utils.solcitarNumeroEntre(1, 2);
            switch (numeroIngresado)
            {
                case 1:
                    tipoEnvio = "Nacional";
                    Console.WriteLine("Seleccione si el destino del envío es un domicilio particular o sucursal");
                    Console.WriteLine("1 - Domicilio");
                    Console.WriteLine("2 - Sucursal");
                    numeroIngresado = Utils.solcitarNumeroEntre(1, 2);
                    switch (numeroIngresado)
                    {
                        case 1:
                            destino = cargarDireccionNacional();
                            break;
                        case 2:
                            destino = seleccionarSucursal();
                            break;
                    }

                    Console.Clear();
                    break;
                case 2:
                    tipoEnvio = "Internacional";
                    destino = cargarDireccionInternacional();
                    break;
            }

            //nombre
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese nombre del destinatario");
            string nombreDestinatario;
            bool primerIntento = true;
            do
            {
                if (!primerIntento)
                {
                    Console.WriteLine("Por favor, ingrese un nombre valido ");
                }
                nombreDestinatario = Console.ReadLine();
                primerIntento = false;
            }
            while (String.IsNullOrWhiteSpace(nombreDestinatario));

            //apellido
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese el apellido del destinatario");
            string apellidoDestinatario;
            primerIntento = true;
            do
            {
                if (!primerIntento)
                {
                    Console.WriteLine("Por favor, ingrese un apellido valido ");
                }
                apellidoDestinatario = Console.ReadLine();
                primerIntento = false;
            }
            while (String.IsNullOrWhiteSpace(apellidoDestinatario));

            //documento
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese el DNI, del destinatario");
            int documentoDestinatario = Utils.solicitarDocumento();

            //SE PERSISTEN DATOS
            Envio envio = new Envio(
               INGRESADO_EN_SISTEMA,
               cliente.cuit,
               peso,
               prioridad,
               tipoEnvio,
               origen.ToString(),
               destino.ToString(),
               nombreDestinatario,
               apellidoDestinatario,
               documentoDestinatario
               );
            envio.cargarEnvioEnTXTEnvios();
            return envio;
        }

        public static void mostrarResumenSolicitud(Envio envio)
        { 
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("       RESUMEN DE SU SOLICITUD");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine($"* Tipo de envío: {envio.tipoEnvio}");
            Console.WriteLine($"* Prioridad: {envio.prioridad}");
            Console.WriteLine($"* Origen: {envio.origen}");
            Console.WriteLine($"* Destino: {envio.destino}");
            Console.WriteLine($"* Nombre y apellido del destinatario:{envio.nombreDestinatario}, {envio.apellidoDestinatario}");
            Console.WriteLine($"* DNI del receptor:{envio.documenoDestinatario}");
            Console.WriteLine($"* Cotización del envío: ${envio.costo}");
            Console.WriteLine(" ");

        }

        public static Direccion seleccionarSucursal()
        {
            int opcionSeleccionada;

            // FLUJO SELECCION DE SUCURSAL
            var listadoSucursales = Sucursal.listar();
            var sucursalesAgrupadasRegion = listadoSucursales.GroupBy(sucursal => sucursal.Direccion.Region);

            // SELECCIONAR REGION
            Console.WriteLine("");
            Console.WriteLine("Seleccione region para la sucursal:");
            foreach (var item in sucursalesAgrupadasRegion.Select((value, index) => (value, index)))
            {
                var index = item.index + 1;
                var region = item.value.Key;

                Console.WriteLine(index + "-" + region);
            }

            opcionSeleccionada = Utils.solcitarNumeroEntre(1, sucursalesAgrupadasRegion.Count());

            // SELECCIONAR PROVINCIA
            var sucursalesRegionSeleccionada = sucursalesAgrupadasRegion.ElementAt(opcionSeleccionada - 1);
            var sucursalesAgrupadasProvincia = sucursalesRegionSeleccionada.GroupBy(sucursal => sucursal.Direccion.Provincia);
            Console.WriteLine("");
            Console.WriteLine("Seleccione provincia para la sucursal:");
            foreach (var item in sucursalesAgrupadasProvincia.Select((value, index) => (value, index)))
            {
                var index = item.index + 1;
                var region = item.value.Key;

                Console.WriteLine(index + "-" + region);
            }

            opcionSeleccionada = Utils.solcitarNumeroEntre(1, sucursalesAgrupadasProvincia.Count());

            // SELECCIONAR LOCALIDAD
            var sucursalesProvinciaSeleccionada = sucursalesAgrupadasProvincia.ElementAt(opcionSeleccionada - 1);
            var sucursalesAgrupadasLocalidad = sucursalesProvinciaSeleccionada.GroupBy(sucursal => sucursal.Direccion.Localidad);
            Console.WriteLine("");
            Console.WriteLine("Seleccione localidad para la sucursal:");
            foreach (var item in sucursalesAgrupadasLocalidad.Select((value, index) => (value, index)))
            {
                var index = item.index + 1;
                var region = item.value.Key;

                Console.WriteLine(index + "-" + region);
            }

            opcionSeleccionada = Utils.solcitarNumeroEntre(1, sucursalesAgrupadasLocalidad.Count());

            // SELECCIONAR SUCURSAL
            var sucursalesFiltradas = sucursalesAgrupadasLocalidad.ElementAt(opcionSeleccionada - 1);
            Console.WriteLine("");
            Console.WriteLine("Seleccione la sucursal para el envio:");
            foreach (var item in sucursalesFiltradas.Select((sucursal, index) => (sucursal, index)))
            {
                var index = item.index + 1;

                Console.WriteLine(index + "-" + item.sucursal.Direccion.mostrar());
            }

            opcionSeleccionada = Utils.solcitarNumeroEntre(1, sucursalesFiltradas.Count());
            var sucursalSeleccionada = sucursalesFiltradas.ElementAt(opcionSeleccionada - 1);
            return sucursalSeleccionada.Direccion;
        }

        public static Direccion cargarDireccionNacional()
        {
            int opcionSeleccionada;

            // FLUJO CARGA DE DOMICILIO
            var listadoLocalidades = Direccion.listarLocalidades();
            var localidadesAgrupadasRegion = listadoLocalidades.GroupBy(localidad => localidad.Region);

            // SELECCIONAR REGION
            Console.WriteLine("");
            Console.WriteLine("Seleccione la region a la que pertenece la direccion:");
            foreach (var item in localidadesAgrupadasRegion.Select((value, index) => (value, index)))
            {
                var index = item.index + 1;
                var region = item.value.Key;

                Console.WriteLine(index + "-" + region);
            }

            opcionSeleccionada = Utils.solcitarNumeroEntre(1, localidadesAgrupadasRegion.Count());

            // SELECCIONAR PROVINCIA
            var localidadesRegionSeleccionada = localidadesAgrupadasRegion.ElementAt(opcionSeleccionada - 1);
            var localidadesAgrupadasProvincia = localidadesRegionSeleccionada.GroupBy(localidad => localidad.Provincia);
            Console.WriteLine("");
            Console.WriteLine("Seleccione la provincia a la que pertenece la direccion:");
            foreach (var item in localidadesAgrupadasProvincia.Select((value, index) => (value, index)))
            {
                var index = item.index + 1;
                var region = item.value.Key;

                Console.WriteLine(index + "-" + region);
            }

            opcionSeleccionada = Utils.solcitarNumeroEntre(1, localidadesAgrupadasProvincia.Count());

            // SELECCIONAR LOCALIDAD
            var localidadesProvinciaSeleccionada = localidadesAgrupadasProvincia.ElementAt(opcionSeleccionada - 1);
            Console.WriteLine("");
            Console.WriteLine("Seleccione la localidad a la que pertenece la direccion:");
            foreach (var item in localidadesProvinciaSeleccionada.Select((direccion, index) => (direccion, index)))
            {
                var index = item.index + 1;

                Console.WriteLine(index + "-" + item.direccion.Localidad);
            }

            opcionSeleccionada = Utils.solcitarNumeroEntre(1, localidadesProvinciaSeleccionada.Count());
            var direccion = localidadesProvinciaSeleccionada.ElementAt(opcionSeleccionada - 1);

            Console.WriteLine("Cargar la calle:");
            direccion.Calle = Console.ReadLine();

            Console.WriteLine("Carga la altura:");
            direccion.Altura = Utils.solcitarNumeroEntre(1, 99999).ToString();

            return direccion;
        }

        public static Direccion cargarDireccionInternacional()
        {
   
            int opcionSeleccionada;

            // FLUJO SELECCION DE DESTINO INTERNACIONAL
            var listadoInternacional = DestinoInternacional.listar();
            var destinosInternacionesAgrupadosRegion = listadoInternacional.GroupBy(destino => destino.Direccion.Region); //Agrupo por region

            // SELECCIONAR REGION
            Console.WriteLine("");
            Console.WriteLine("Seleccione region de destino:");
            foreach (var item in destinosInternacionesAgrupadosRegion.Select((value, index) => (value, index)))
            {
                var index = item.index + 1;
                var region = item.value.Key;

                Console.WriteLine(index + "-" + region);
            }

            opcionSeleccionada = Utils.solcitarNumeroEntre(1, destinosInternacionesAgrupadosRegion.Count());

            // SELECCIONAR PAIS
            var paisesRegionSeleccionada = destinosInternacionesAgrupadosRegion.ElementAt(opcionSeleccionada - 1);
            var destinosAgrupadosPais = paisesRegionSeleccionada.GroupBy(destino => destino.Direccion.Provincia);
            Console.WriteLine("");
            Console.WriteLine("Seleccione pais de destino:");
            foreach (var item in destinosAgrupadosPais.Select((value, index) => (value, index)))
            {
                var index = item.index + 1;
                var pais = item.value.Key;

                Console.WriteLine(index + "-" + pais);
            }

            opcionSeleccionada = Utils.solcitarNumeroEntre(1, destinosAgrupadosPais.Count());

            // SELECCIONAR LOCALIDAD
            var destinosFiltrados = destinosAgrupadosPais.ElementAt(opcionSeleccionada - 1);
            Console.WriteLine("");
            Console.WriteLine("Seleccione la localidad de destino:");
            foreach (var item in destinosFiltrados.Select((value, index) => (value, index)))
            {
                var index = item.index + 1;

                Console.WriteLine(index + "-" + item.value.Direccion.Localidad);
            }

            opcionSeleccionada = Utils.solcitarNumeroEntre(1, destinosFiltrados.Count());
            var destinoSeleccionado = destinosFiltrados.ElementAt(opcionSeleccionada - 1);
            return destinoSeleccionado.Direccion;
        
        }

    }

}










