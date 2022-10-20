using System;
using System.Net;
using System.Security.Cryptography;

namespace SistemaEncomiendas
{

    public static class MenuPrincipal
    {

        public static void mostrar(Servicio servicio)
        {

            string nombreUsuario = "Nicolas Martinez";
            long cuit = 20306578636768;
            double peso = 0;
            string prioridad;
            string tipoEnvio;
            string sucursalOrigen = "";
            string sucursalDestino = "";
            string direccionDestino = "";
            string DNIDestinatario = "";
            string direccionOrigen = "";
            string nombreDestinatario = "";
            string apellidoDestinatario = "";
            int opcionSeleccionada;
            int numeroIntentos = 0;
            string nroSeguimiento = "0";
            int costoEnvio = 5600;
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

                    if (!String.IsNullOrEmpty(servicio.nroSeguimiento)){
                        Console.WriteLine("Por el momento solo se permite una solicitud por usuario");
                        Console.WriteLine(" ");
                        Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                        Console.ReadKey();
                        Console.Clear();
                        MenuPrincipal.mostrar(servicio);
                        break;
                    }

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
                            Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
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
                    opcionSeleccionada = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
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


                    //  para el prototipo usamos --> Domicilio
                    numeroIntentos = 0;
                    opcionSeleccionada = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
                            Console.ReadLine();
                        }

                        //TIPO DE ENVIO
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione si el origen del envío es un domicilio particular o sucursal:");
                        Console.WriteLine("1 - Domicilio");
                        Console.WriteLine("2 - Sucursal");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                        if (opcionSeleccionada == 1)
                        {
                            tipoEnvio = "Domicilio";
                        }
                        numeroIntentos++;

                    } while (opcionSeleccionada != 1);
                    Console.Clear();

              


                    // Unica opcion desarrollada --> Metropolitana
                    numeroIntentos = 0;
                    opcionSeleccionada = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
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
                    opcionSeleccionada = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
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
                    opcionSeleccionada = 0;
                    do

                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
                            Console.ReadLine();
                        }

                        //LOCALIDAD ORIGEN
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione localidad de origen");
                        Console.WriteLine("1 - Martinez");
                        Console.WriteLine("2 - Olivos");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                        if (opcionSeleccionada == 1)
                        {
                            sucursalOrigen = "Martinez, Buenos Aires, Metropolitana";
                        }

                        numeroIntentos++;

                    } while (opcionSeleccionada != 1);


                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Debe ingresar un domicilio valido, por favor vuelva a intentarlo");
                        }
                        Console.WriteLine("Ingrese domicilio de origen:");
                        string direccionO = Console.ReadLine();

                        direccionOrigen = direccionO + direccionOrigen;

                        numeroIntentos++;

                    } while (String.IsNullOrEmpty(direccionOrigen) ||
                    direccionOrigen.All(char.IsWhiteSpace)
                    );

                    //DATOS DESTINO


                    // Unica opcion desarrollada --> Nacional
                    numeroIntentos = 0;
                    opcionSeleccionada = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
                            Console.ReadLine();
                        }

                        Console.Clear();

                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(" SOLICITUD DE SERVICIO - DATOS DE DESTINO");
                        Console.WriteLine("------------------------------------------");

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


                    //  para el prototipo usamos --> Domicilio
                    numeroIntentos = 0;
                    opcionSeleccionada = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
                            Console.ReadLine();
                        }

                        //TIPO DE ENVIO
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione si el destino del envío es un domicilio particular o sucursal:");
                        Console.WriteLine("1 - Domicilio");
                        Console.WriteLine("2 - Sucursal");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                        if (opcionSeleccionada == 1)
                        {
                            tipoEnvio = "Domicilio";
                        }
                        numeroIntentos++;

                    } while (opcionSeleccionada != 1);
                    Console.Clear();


                    // Unica opcion desarrollada --> Metropolitana
                    numeroIntentos = 0;
                    opcionSeleccionada = 0;
                    Console.Clear();
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
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
                    opcionSeleccionada = 0;
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


                    // Unica opcion desarrollada --> Martinez
                    numeroIntentos = 0;
                    opcionSeleccionada = 0;
                    do

                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
                            Console.ReadLine();
                        }

                        //LOCALIDAD DESTINO
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione localidad destino");
                        Console.WriteLine("1 - Cosquin");
                        Console.WriteLine("2 - La Falda");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                        if (opcionSeleccionada == 1)
                        {
                            sucursalDestino = "Cosquin, Cordoba";
                        }

                        numeroIntentos++;

                    } while (opcionSeleccionada != 1);


                    //DIRECCION DESTINO Y DATOS DESTINATARIO

                    Console.Clear();
                      Console.WriteLine("------------------------------------------");
                      Console.WriteLine("DATOS DEL DESTINATARIO");
                      Console.WriteLine("------------------------------------------");
                      Console.WriteLine("");

                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Debe ingresar un domicilio valido, por favor vuelva a intentarlo");
                        }
                        Console.WriteLine("Ingrese domicilio del destinatario:");
                        string direccion = Console.ReadLine();

                        direccionDestino = direccion + direccionDestino;

                        numeroIntentos++;

                    } while (String.IsNullOrEmpty(direccionDestino) ||
                    direccionDestino.All(char.IsWhiteSpace)
                    );


                    //nombre destinatario
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
                            Console.WriteLine("Debe ingresar un nombre valido, por favor vuelva a intentarlo");
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

                    servicio.nroSeguimiento = "30541";
                    servicio.peso = peso;
                    servicio.sucursalOrigen = sucursalOrigen;
                    servicio.direccionDestino = direccionDestino;
                    servicio.direccionOrigen = direccionOrigen;
                    servicio.DNIDestinatario = DNIDestinatario;
                    servicio.nombreDestinatario = nombreDestinatario;
                    servicio.apellidoDestinatario = apellidoDestinatario;
                    servicio.costoEnvio = 455;

                    //RESUMEN DE LA SOLICITUD
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("       RESUMEN DE SU SOLICITUD");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($"* Numero de orden de servicio: {servicio.nroSeguimiento}");
                    Console.WriteLine($"* Peso declarado: {servicio.peso}kg");
                    Console.WriteLine($"* Origen: {servicio.direccionOrigen}, Martinez, Buenos Aires");
                    Console.WriteLine($"* Destino: {servicio.direccionDestino}, Los Cocos, Cordoba");
                    Console.WriteLine($"* DNI del receptor:{servicio.DNIDestinatario}");
                    Console.WriteLine($"* Nombre y apellido del receptor:{servicio.nombreDestinatario}, {servicio.apellidoDestinatario}");
                    Console.WriteLine($"* Costo del envio: ${servicio.costoEnvio}");
                    Console.WriteLine(" ");
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal.mostrar(servicio);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("     CONSULTAR ESTADO DE SERVICIO");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("");

                    if (String.IsNullOrEmpty(servicio.nroSeguimiento)){
                        Console.WriteLine("Usted no tiene solicitudes pendientes");
                        Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                        Console.ReadKey();
                        Console.Clear();
                        MenuPrincipal.mostrar(servicio);
                    }

                    //Se valida numero de seguimiento a consultar
                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Debe ingresar un  número de orden existente, por favor vuelva a intentarlo");
                        }
                        Console.WriteLine("Ingrese el número de orden de servicio que desea consultar");
                        nroSeguimiento = Console.ReadLine();

                        numeroIntentos++;

                    } while (!nroSeguimiento.Equals(servicio.nroSeguimiento));

                    Console.Clear();
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("           ESTADO DE SERVICIO");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"* Numero de orden de servicio: {servicio.nroSeguimiento}");
                    Console.WriteLine($"* Peso declarado: {servicio.peso}kg");
                    Console.WriteLine($"* Origen: {servicio.direccionOrigen}" + "Martinez, Buenos Aires");
                    Console.WriteLine($"* Destino: {servicio.direccionDestino}" + "Cosquin, Cordoba");
                    Console.WriteLine($"* DNI del receptor:{servicio.DNIDestinatario}");
                    Console.WriteLine($"* Nombre y apellido del receptor:{servicio.nombreDestinatario}, {servicio.apellidoDestinatario}");
                    Console.WriteLine($"* Costo del envio: ${servicio.costoEnvio}");
                    Console.WriteLine("");
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal.mostrar(servicio);
                    break;
                case 3:
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("        CONSULTAR ESTADO DE CUENTA");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Resumen a la fecha: {DateTime.Today}");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Monto total de su cuenta ${servicio.costoEnvio}");
                    Console.WriteLine($"Estado: A PAGAR");
                    Console.WriteLine(" ");
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal.mostrar(servicio);
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


