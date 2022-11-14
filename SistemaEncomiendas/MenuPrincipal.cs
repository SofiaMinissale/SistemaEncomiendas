using System;
using System.Net;
using System.Security.Cryptography;

namespace SistemaEncomiendas
{
    public static class MenuPrincipal
    {

        /* USUARIO DE PRUEBA:  20306578636768; NicolasMartinez; usuario1  */
        public static void mostrar(ClienteCorporativo cliente)
        {

            int opcionSeleccionada;

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
                    Envio solicitudOrdenServicio = OrdenServicio.cargarDatos(cliente);
                    Console.Clear();
                    OrdenServicio.mostrarResumenSolicitud(solicitudOrdenServicio);

                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
                    break;
                case 2:
                    /* if (cliente.idEnvio == null)
                      {
                      Console.WriteLine("------------------------------------------");
                      Console.WriteLine("           CONSULTA ESTADO DE  SERVICIO");
                      Console.WriteLine("------------------------------------------");
                      Console.WriteLine(" ");
                      Console.WriteLine("Usted no registra ordenes de servicio");
                      Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                      Console.ReadKey();
                      Console.Clear();
                      MenuPrincipal.mostrar(cliente);
                      break;
                      }*/

                    Console.Clear();
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("          CONSULTA ESTADO DE  SERVICIO");
                    Console.WriteLine("------------------------------------------");
                    ConsultaEstadoServicio consulta = new ConsultaEstadoServicio();
                    string estado = consulta.consultarEstadoSolicitud();
                    Console.Clear();
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("           ESTADO DE SERVICIO");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"fecha de solicitud de servicio: {DateTime.Today}");
                    Console.WriteLine($"Estado de servicio: {estado}");
                    Console.WriteLine("");
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
                    break;
                case 3:
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("        ESTADO DE CUENTA");
                    Console.WriteLine("------------------------------------------");

                    //METODO RESUMEN ESTADO DE CUENTA 

                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    // MenuPrincipal.mostrar();
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


