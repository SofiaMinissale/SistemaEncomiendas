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
            Console.WriteLine("");
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
                    Envio solicitudOrdenServicio = OrdenServicio.cargarDatos(cliente);
                    Console.Clear();
                    OrdenServicio.mostrarResumenSolicitud(solicitudOrdenServicio);
                    Console.WriteLine("Pulse 1 para confirmar solicitud y volver al menu principal");
                    Console.WriteLine("Pulse 2 para cancelar solicitud y volver al menu principal");
                    var seleccion = Utils.solcitarNumeroEntre(1, 2);

                    switch (seleccion)
                    {
                        case 1:
                            solicitudOrdenServicio.cargarEnvioEnTXTEnvios();
                            Console.Clear();
                            MenuPrincipal.mostrar(cliente);
                            break;
                        case 2:
                            Console.Clear();
                            MenuPrincipal.mostrar(cliente);
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("          CONSULTA ESTADO DE  SERVICIO");
                    Console.WriteLine("------------------------------------------");
                    List<Envio> enviosEstadoServicio = Envio.consultarEnvioCuitUsuario(cliente.cuit);
                    ConsultaEstadoServicio consulta = new ConsultaEstadoServicio(enviosEstadoServicio);
                    if (enviosEstadoServicio.Count() > 0)
                    {
                        consulta.mostrarOpciones();
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione la opcion que desee consultar.");
                        var envioSeleccionado = Utils.solcitarNumeroEntre(1, enviosEstadoServicio.Count());
                        consulta.mostrarEnvio(envioSeleccionado);
                    } else
                    {
                        Console.WriteLine("Usted no tiene envios a su nombre'");
                    }
                        
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

                    List<Envio> enviosEstadoCuenta = Envio.consultarEnvioCuitUsuario(cliente.cuit);
                    if (enviosEstadoCuenta.Count() > 0)
                    {
                        ConsultaEstadoCuenta consultaEstadoCuenta = new ConsultaEstadoCuenta(enviosEstadoCuenta);
                        consultaEstadoCuenta.mostrarEstado();
                    }
                    else
                    {
                        Console.WriteLine("Usted no tiene envios a su nombre'");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
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


