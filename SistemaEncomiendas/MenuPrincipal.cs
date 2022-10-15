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
            double peso = 5;
            string sucursalOrigen = "Buenos Aires";
            string sucursalDestino = "Tierra del Fuego";
            long dni = 36966066;
            int costoEnvio = 5600;
            long NroSeguimiento = 828842;
            string estadoOrden = "En centro de Distribución";
           

            Console.WriteLine(" ");
            Console.WriteLine("INGRESA UN NUMERO PARA NAVEGAR EN EL MENU");
            Console.WriteLine("1 - Solicitar envio");
            Console.WriteLine("2 - Consultar estado de servicio");
            Console.WriteLine("3 - Consultar estado de cuenta");
            Console.WriteLine("4 - Cerrar sesion");
            Console.WriteLine("5 - Salir del programa");

            Console.ReadLine();
          //  Console.Clear();


            int numeroIngresado;
            
            numeroIngresado = Utils.solcitarNumeroEntre(0, 5);

            switch (numeroIngresado)
            {
                case 1:
                    Console.WriteLine("Usted selecciono SOLICITAR ENVIO");
                    Console.WriteLine("");
                    //PESO
                    Console.WriteLine("INGRESE EL PESO DEL PAQUETE (KG)");
                    Console.ReadLine();
                    Console.Clear();

                    //PRIORIDAD
                    Console.WriteLine("SELECCIONE LA PRIORIDAD DE SU PEDIDO, si es NORMAL o URGENTE");
                    Console.WriteLine("1 - Normal");
                    Console.WriteLine("2 - Urgente");
                    Console.ReadLine();
                    Console.Clear();

                    // ORIGEN
                    Console.WriteLine("SELECCIONE SI EL ORIGEN DEL ENVIO ES UN DOMICILIO O SUCURSAL");
                    Console.WriteLine("1 - Domicilio Particular");
                    Console.WriteLine("2 - Sucursarl");
                    Console.ReadLine();
                    Console.Clear();

                    //NACIONALIDAD 
                    Console.WriteLine("SELECCIONE SI SU PEDIDO ES NACIONAL O INTERNACIONAL ");
                    Console.WriteLine("1 - Nacional");
                    Console.WriteLine("2 - Internacional");
                    Console.ReadLine();
                    Console.Clear();

                    //REGION 
                    Console.WriteLine("SELECCIONE SU REGION");
                    Console.WriteLine("1 - Centro");
                    Console.WriteLine("2 - Metropolitana");
                    Console.WriteLine("3 - Norte");
                    Console.WriteLine("4 - Sur");
                    Console.ReadLine();
                    Console.Clear();

                    //PROVINCIAS
                    Console.WriteLine("SELECCIONE SU Provincia");
                    Console.WriteLine("1 - Buenos Aires");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("INGRESE DOMICILIO DONDE DESEA QUE SE ENVIE SU PAQUETE");
                    Console.ReadLine();
                    Console.Clear();

                    //DESTINO 

                    // ORIGEN
                    Console.WriteLine("SELECCIONE SI EL DESTINO DEL ENVIO ES UN DOMICILIO O SUCURSAL");
                    Console.WriteLine("1 - Domicilio Particular");
                    Console.WriteLine("2 - Sucursarl");
                    Console.ReadLine();
                    Console.Clear();

                    //NACIONALIDAD 
                    Console.WriteLine("SELECCIONE SI SU PEDIDO ES NACIONAL O INTERNACIONAL ");
                    Console.WriteLine("1 - Nacional");
                    Console.WriteLine("2 - Internacional");
                    Console.ReadLine();
                    Console.Clear();

                    //REGION 
                    Console.WriteLine("SELECCIONE REGION A ENVIAR");
                    Console.WriteLine("1 - Centro");
                    Console.WriteLine("2 - Metropolitana");
                    Console.WriteLine("3 - Norte");
                    Console.WriteLine("4 - Sur");
                    Console.ReadLine();
                    Console.Clear();

                    //PROVINCIAS
                    Console.WriteLine("SELECCIONE SU Provincia");
                    Console.WriteLine("1 - Chubut");
                    Console.WriteLine("2 - La pampa");
                    Console.WriteLine("3 - Neuquen");
                    Console.WriteLine("4 - Rio Negro");
                    Console.WriteLine("5 - Santa Cruz");
                    Console.WriteLine("6 - Tierra del Fuego");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("INGRESE Domicilio donde sea que envie su paquete");
                    Console.ReadLine();
                    Console.Clear();

                    //DATOS DEL DESTINATARIO

                    Console.WriteLine("INGRESE NOMBRE DEL DESTINATARIO");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("INGRESE APELLIDO");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("INGRESE DNI");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("RESUMEN DE SU SOLICITUD");
                    Console.WriteLine($"Numero de orden de servicio: {NroSeguimiento}");
                    Console.WriteLine($"El peso declarado es: {peso}kg");
                    Console.WriteLine($"Origen {sucursalOrigen}");
                    Console.WriteLine($"Destino {sucursalDestino}");
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
                    Console.WriteLine($"Destino {sucursalDestino}");
                    Console.WriteLine($"El DNI del receptor es:{dni}");
                    Console.WriteLine($"El costo del envio es ${costoEnvio}");
                    Console.WriteLine("");
                    Console.WriteLine("¿Desea consultar otra orden de servicio?");
                    Console.WriteLine("1 - SI");
                    Console.WriteLine("2 - NO");


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
                    Console.WriteLine($"Destino {sucursalDestino}");
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


