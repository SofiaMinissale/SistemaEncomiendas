using System;
using System.Net;
using System.Security.Cryptography;

namespace SistemaEncomiendas
{

    public static class MenuPrincipal
    {

        public static void mostrar()
        {

            string nombreUsuario = "Nicolas Martinez";
            long cuit = 20306578636768;
            double peso = 0;
            string prioridad;
            string tipoEnvio;
            string sucursalOrigen = "";
            string direccionDestino = "";
            string DNIDestinatario = "";
            string nombreDestinatario = "";
            string apellidoDestinatario = "";
            int opcionSeleccionada;
            int numeroIntentos = 0;

            int costoEnvio = 5600;
            long nroSeguimiento = 828842;
            string estadoOrden = "En centro de Distribución";

            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("INGRESA UN NUMERO PARA NAVEGAR EN EL MENU");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 - Solicitar servicio");
            Console.WriteLine("2 - Consultar estado de servicio");
            Console.WriteLine("3 - Consultar estado de cuenta");
            Console.WriteLine("4 - Cerrar sesion");
            Console.WriteLine("5 - Salir del programa");
            opcionSeleccionada = Utils.solcitarNumeroEntre(1, 5);
            Console.Clear();

            switch (opcionSeleccionada)
            {
                case 1:
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("         SOLICITUD DE SERVICIO");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("");

                    //PESO
                    Console.WriteLine("Ingrese el peso de paquete (KG):");
                    peso = Utils.solicitarPeso();

                    // Unica opcion desarrollada --> Normal
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, pulse una tecla para reintentarlo");
                            Console.ReadLine();
                        }

                        //PRIORIDAD
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione la prioridad del envio:");
                        Console.WriteLine("1 - Normal");
                        Console.WriteLine("2 - Urgente");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                        if (opcionSeleccionada == 1)
                        {
                            prioridad = "Normal";
                        }

                        numeroIntentos++;

                    } while (opcionSeleccionada != 1);


                    // Unica opcion desarrollada --> Nacional
                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, pulse una tecla para reintentarlo");
                            Console.ReadLine();
                        }

                        //TIPO DE ENVIO
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione el tipo de envio:");
                        Console.WriteLine("1 - Nacional");
                        Console.WriteLine("2 - Internacional");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                        if (opcionSeleccionada == 1)
                        {
                            tipoEnvio = "Nacional";
                        }

                        numeroIntentos++;

                    } while (opcionSeleccionada != 1);
                    Console.Clear();

                    // Unica opcion desarrollada --> Metropolitana
                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, pulse una tecla para reintentarlo");
                            Console.ReadLine();
                        }

                        //REGION ORIGEN
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(" SOLICITUD DE SERVICIO - DATOS DE ORIGEN");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione region de origen");
                        Console.WriteLine("1 - Centro");
                        Console.WriteLine("2 - Metropolitana");
                        Console.WriteLine("3 - Norte");
                        Console.WriteLine("4 - Sur");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 4);

                        numeroIntentos++;

                    } while (opcionSeleccionada != 2);

                    // Unica opcion desarrollada --> Buenos Aires
                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, pulse una tecla para reintentarlo");
                            Console.ReadLine();
                        }

                        //PROVINCIA ORIGEN
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione provincia de origen");
                        Console.WriteLine("1 - Buenos Aires");
                        Console.WriteLine("2 - Cordoba");
                        Console.WriteLine("3 - Chaco");
                        Console.WriteLine("4 - La Pampa");
                        Console.WriteLine("5 - Salta");
                        Console.WriteLine("6 - Jujuy");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 6);

                        numeroIntentos++;

                    } while (opcionSeleccionada != 1);

                    // Unica opcion desarrollada --> Martinez
                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, pulse una tecla para reintentarlo");
                            Console.ReadLine();
                        }

                        //SUCURSAL ORIGEN
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione sucursal de origen");
                        Console.WriteLine("1 - Martinez");
                        Console.WriteLine("2 - Olivos");
                        if (opcionSeleccionada == 1)
                        {
                            sucursalOrigen = "Martinez, Buenos Aires, Metropolitana";
                        }

                        numeroIntentos++;

                    } while (opcionSeleccionada != 1);


                    //DATOS DESTINO
                    // Unica opcion desarrollada --> Metropolitana
                    numeroIntentos = 0;
                    Console.Clear();
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, pulse una tecla para reintentarlo");
                            Console.ReadLine();
                        }

                        //REGION DESTINO
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(" SOLICITUD DE SERVICIO - DATOS DE DESTINO");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Seleccione region de destino");
                        Console.WriteLine("1 - Centro");
                        Console.WriteLine("2 - Metropolitana");
                        Console.WriteLine("3 - Norte");
                        Console.WriteLine("4 - Sur");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 4);

                        numeroIntentos++;

                    } while (opcionSeleccionada != 2);

                    // Unica opcion desarrollada --> Cordoba
                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, pulse una tecla para reintentarlo");
                            Console.ReadLine();

                        }

                        //PROVINCIA DESTINO
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione provincia de destino");
                        Console.WriteLine("1 - Buenos Aires");
                        Console.WriteLine("2 - Cordoba");
                        Console.WriteLine("3 - Chaco");
                        Console.WriteLine("4 - La Pampa");
                        Console.WriteLine("5 - Salta");
                        Console.WriteLine("6 - Jujuy");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 6);
                        if (opcionSeleccionada == 1)
                        {
                            direccionDestino = "Cordoba, Metropolitana";
                        }

                        numeroIntentos++;

                    } while (opcionSeleccionada != 2);

                    //DIRECCION DESTINO Y DATOS DESTINATARIO
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese direccion de destino");
                    string direccion = Console.ReadLine();

                    direccionDestino = direccion + direccionDestino;

                    Console.Clear();
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("DATOS DEL DESTINATARIO");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("");

                    //Nombre destinatario
                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Debe ingresar un nombre valido, por favor vuelva a intentarlo");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese nombre del destinatario:");
                        nombreDestinatario = Console.ReadLine();

                        numeroIntentos++;

                    } while (String.IsNullOrEmpty(nombreDestinatario) ||
                    nombreDestinatario.Any(char.IsDigit) ||
                    nombreDestinatario.All(char.IsWhiteSpace)
                    );

                    //Apellido destinatario
                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Debe ingresar un apellido valido, por favor vuelva a intentarlo");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese apellido del destinatario:");
                        apellidoDestinatario = Console.ReadLine();

                        numeroIntentos++;

                    } while (String.IsNullOrEmpty(apellidoDestinatario) ||
                    apellidoDestinatario.Any(char.IsDigit) ||
                    apellidoDestinatario.All(char.IsWhiteSpace)
                    );


                    //Datos destinatario
                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Debe ingresar un DNI valido, por favor vuelva a intentarlo");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el DNI del destinatario");
                        DNIDestinatario = Console.ReadLine();

                        numeroIntentos++;

                    } while (!Utils.esDNIValido(DNIDestinatario));
                    
                    Console.Clear();

                    //RESUMEN DE LA SOLICITUD
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("       RESUMEN DE SU SOLICITUD");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($"* Numero de orden de servicio: {nroSeguimiento}");
                    Console.WriteLine($"* Peso declarado: {peso}kg");
                    Console.WriteLine($"* Origen: {sucursalOrigen}");
                    Console.WriteLine($"* Destino: {direccionDestino}");
                    Console.WriteLine($"* DNI del receptor:{DNIDestinatario}");
                    Console.WriteLine($"* Nombre y apellido del receptor:{nombreDestinatario}, {apellidoDestinatario}");
                    Console.WriteLine($"* Costo del envio: ${costoEnvio}");
                    Console.WriteLine(" ");
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal.mostrar();
                    break;
                case 2:
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("     CONSULTAR ESTADO DE SERVICIO");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el nro de orden de servicio que desea consultar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine($"* Numero de orden de servicio: {nroSeguimiento}");
                    Console.WriteLine($"* Peso declarado: {peso}kg");
                    Console.WriteLine($"* Origen: {sucursalOrigen}");
                    Console.WriteLine($"* Destino: {direccionDestino}");
                    Console.WriteLine($"* DNI del receptor:{DNIDestinatario}");
                    Console.WriteLine($"* Nombre y apellido del receptor:{nombreDestinatario}, {apellidoDestinatario}");
                    Console.WriteLine($"* Costo del envio: ${costoEnvio}");
                    Console.WriteLine("");
                    opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal.mostrar();
                    break;
                case 3:
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("        CONSULTAR ESTADO DE CUENTA");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese mes/ año(en formato mmAA):");
                    Console.WriteLine("Sus envios en la fecha: 18/10:");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Un paquete con un peso de: {peso}kg");
                    Console.WriteLine($"Origen {sucursalOrigen}");
                    Console.WriteLine($"Destino {direccionDestino}");
                    Console.WriteLine($"Costo de envio: ${costoEnvio}");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Monto total de su cuenta ${costoEnvio}");
                    Console.WriteLine($"Estado: A PAGAR");
                    Console.WriteLine(" ");
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal.mostrar();
                    break;
                case 4:
                    Console.WriteLine("CERRANDO SESION, pulse una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    MenuInicial.mostrar();
                    break;
                case 5:
                    Console.WriteLine("SALIENDO DEL PROGRAMA");
                    break;
            }

        }

    }

}


