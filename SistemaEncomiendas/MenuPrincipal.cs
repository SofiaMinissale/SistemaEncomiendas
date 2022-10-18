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

            long dni = 36966066;
            int costoEnvio = 5600;
            long NroSeguimiento = 828842;
            string estadoOrden = "En centro de Distribución";
            int opcionSeleccionada;
            int numeroIntentos = 0;

            Console.WriteLine(" ");
            Console.WriteLine("INGRESA UN NUMERO PARA NAVEGAR EN EL MENU");
            Console.WriteLine("1 - Solicitar envio");
            Console.WriteLine("2 - Consultar estado de servicio");
            Console.WriteLine("3 - Consultar estado de cuenta");
            Console.WriteLine("4 - Cerrar sesion");
            Console.WriteLine("5 - Salir del programa");
            opcionSeleccionada = Utils.solcitarNumeroEntre(1, 5);
            Console.Clear();

            switch (opcionSeleccionada)
            {
                case 1:
                    Console.WriteLine("Usted selecciono SOLICITAR ENVIO");
                    Console.WriteLine("");

                    //PESO
                    Console.WriteLine("INGRESE EL PESO DEL PAQUETE (KG)");
                    peso = Utils.solicitarPeso();
                    Console.Clear();

                    // Unica opcion desarrollada --> Normal
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, pulse una tecla para reintentarlo");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        //PRIORIDAD
                        Console.WriteLine("SELECCIONE LA PRIORIDAD DE SU PEDIDO, si es NORMAL o URGENTE");
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
                            Console.Clear();
                        }

                        //TIPO DE ENVIO 
                        Console.WriteLine("SELECCIONE EL TIPO DE ENVIO");
                        Console.WriteLine("1 - Nacional");
                        Console.WriteLine("2 - Internacional");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                        if (opcionSeleccionada == 1)
                        {
                            tipoEnvio = "Nacional";
                        }
                        Console.Clear();

                        numeroIntentos++;

                    } while (opcionSeleccionada != 1);

                    // Unica opcion desarrollada --> Metropolitana
                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, pulse una tecla para reintentarlo");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        //REGION ORIGEN
                        Console.WriteLine("SELECCIONE REGION DE ORIGEN");
                        Console.WriteLine("1 - Centro");
                        Console.WriteLine("2 - Metropolitana");
                        Console.WriteLine("3 - Norte");
                        Console.WriteLine("4 - Sur");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 4);
                        Console.Clear();

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
                            Console.Clear();
                        }

                        //PROVINCIA ORIGEN
                        Console.WriteLine("SELECCIONE PROVINCIA DE ORIGEN");
                        Console.WriteLine("1 - Buenos Aires");
                        Console.WriteLine("2 - Cordoba");
                        Console.WriteLine("3 - Chaco");
                        Console.WriteLine("4 - La Pampa");
                        Console.WriteLine("5 - Salta");
                        Console.WriteLine("6 - Jujuy");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 6);
                        Console.Clear();

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
                            Console.Clear();
                        }

                        //SUCURSAL ORIGEN
                        Console.WriteLine("SELECCIONE SUCURSAL DE ORIGEN");
                        Console.WriteLine("1 - Martinez");
                        Console.WriteLine("2 - Olivos");
                        if (opcionSeleccionada == 1)
                        {
                            sucursalOrigen = "Martinez, Buenos Aires, Metropolitana";
                        }
                        Console.Clear();
        
                        numeroIntentos++;

                    } while (opcionSeleccionada != 1);


                    //DATOS DESTINO
                    // Unica opcion desarrollada --> Metropolitana
                    numeroIntentos = 0;
                    do
                    {
                        if (numeroIntentos >= 1)
                        {
                            Console.WriteLine("Opcion aun no desarrollada, pulse una tecla para reintentarlo");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        //REGION DESTINO
                        Console.WriteLine("SELECCIONE REGION DE DESTINO");
                        Console.WriteLine("1 - Centro");
                        Console.WriteLine("2 - Metropolitana");
                        Console.WriteLine("3 - Norte");
                        Console.WriteLine("4 - Sur");
                        opcionSeleccionada = Utils.solcitarNumeroEntre(1, 4);
                        Console.ReadLine();
                        Console.Clear();

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
                            Console.Clear();
                        }

                        //PROVINCIA DESTINO
                        Console.WriteLine("SELECCIONE PROVINCIA DE DESTINO");
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
                        Console.ReadLine();
                        Console.Clear();

                        numeroIntentos++;

                    } while (opcionSeleccionada != 2);

                    //DIRECCION DESTINO Y DATOS DESTINATARIO
                    Console.WriteLine("INGRESE DIRECCION DE DESTINO");
                    string direccion = Console.ReadLine();

                    direccionDestino = direccion + direccionDestino;

                    Console.WriteLine("INGRESE NOMBRE DEL DESTINATARIO");
                    Console.ReadLine();
                    Console.WriteLine("INGRESE APELLIDO DEL DESTINATARIO");
                    Console.ReadLine();
                    Console.WriteLine("INGRESE DNI DEL DESTINATARIO");
                    Console.ReadLine();
                    Console.Clear();
         
                    //RESUMEN DE LA SOLICITUD
                    Console.WriteLine("RESUMEN DE SU SOLICITUD");
                    Console.WriteLine($"Numero de orden de servicio: {NroSeguimiento}");
                    Console.WriteLine($"El peso declarado es: {peso}kg");
                    Console.WriteLine($"Origen {sucursalOrigen}");
                    Console.WriteLine($"Destino {direccionDestino}");
                    Console.WriteLine($"El DNI del receptor es:{dni}");
                    Console.WriteLine($"El costo del envio es ${costoEnvio}");
                    Console.WriteLine(" ");
                    Console.WriteLine("1- SI ");
                    Console.WriteLine("2 - NO");
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Usted selecciono CONSULTAR ESTADO DE SERVICIO");
                    Console.WriteLine("INGRESE EL NUMERO DE ORDEN DE SERVICIO POR EL CUAL DESEA CONSULTAR");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(" EL ESTADO DEL SERVICIO CONSULTADO ES:");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Numero de orden de servicio: {NroSeguimiento}");
                    Console.WriteLine($"El estado de su paquete es: {estadoOrden}");
                    Console.WriteLine($"El peso declarado es: {peso}kg");
                    Console.WriteLine($"Origen {sucursalOrigen}");
                    Console.WriteLine($"Destino {direccionDestino}");
                    Console.WriteLine($"El DNI del receptor es:{dni}");
                    Console.WriteLine($"El costo del envio es ${costoEnvio}");
                    Console.WriteLine("");
                    Console.WriteLine("¿Desea consultar otra orden de servicio?");
                    Console.WriteLine("1 - SI");
                    Console.WriteLine("2 - NO");
                    opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);


                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Usted selecciono CONSULTAR ESTADO DE CUENTA");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Ingrese mes/ año(en formato mmAA):");
                    Console.Clear();
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
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    break;
                case 4:
                    Console.WriteLine("CERRANDO SESION");
                    break;
                case 5:
                    Console.WriteLine("SALIENDO DEL PROGRAMA");
                    break;
            }

        }

    }

}


