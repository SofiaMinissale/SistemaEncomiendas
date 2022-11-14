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
                    Console.WriteLine("");
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
                    string estado = consulta.consultarEstadoSolicitud(1);
                    Console.Clear();
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("           ESTADO DE SERVICIO");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"fecha de solicitud de servicio: {DateTime.Today}");
                    Console.WriteLine($"Estado de servicio: {estado}");
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


                    

        /*  switch (opcionSeleccionada)
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

                   // Unica opcion desarrollada --> Correspondencia
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
                       Console.WriteLine("Por favor, ingrese el tipo de envío que desea realizar");
                      // Console.WriteLine("");
                       Console.WriteLine("1 -Correspondencia (sobres hasta 500g)");
                       Console.WriteLine("2 -Encomienda (bultos de 500g a 30kg)");
                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                       if (opcionSeleccionada == 1)
                       {
                           seleccionEnvio = "Correspondencia";
                       }

                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);
                   Console.Clear();


                   // Unica opcion desarrollada --> Normal
                   numeroIntentos = 0;
                   opcionSeleccionada = 0;
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
                       Console.WriteLine("2 - Urgente (48hs)");
                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                       if (opcionSeleccionada == 1)
                       {
                           prioridad = "Normal";
                       }

                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);


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
                       Console.WriteLine("1 - Sucursal");
                       Console.WriteLine("2 - Domicilio");
                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                       if (opcionSeleccionada == 1)
                       {
                           tipoEnvio = "Sucursal";
                       }
                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);
                   Console.Clear();


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
                       Console.WriteLine("Seleccione provincia de origen:");
                       Console.WriteLine("1 - Buenos Aires");
                       Console.WriteLine("2 - Catamarca");
                       Console.WriteLine("3 - Chaco");
                       Console.WriteLine("4 - Chubut");
                       Console.WriteLine("5 - Cordoba");
                       Console.WriteLine("6 - Corrientes");
                       Console.WriteLine("7 - Entre Rios");
                       Console.WriteLine("8 - Formosa");
                       Console.WriteLine("9 - Jujuy");
                       Console.WriteLine("10 - La pampa");
                       Console.WriteLine("11 - La Rioja");
                       Console.WriteLine("12 - Mendoza");
                       Console.WriteLine("13 - Misiones");
                       Console.WriteLine("14 - Neuquen");
                       Console.WriteLine("15 - Rio Negro");
                       Console.WriteLine("16 - San Juan");
                       Console.WriteLine("17 - San Luis");
                       Console.WriteLine("18 - Santa Cruz");
                       Console.WriteLine("19 - Santa Fe");
                       Console.WriteLine("20 - Santiago Del Estero");
                       Console.WriteLine("21 - Tierra del fuego");

                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 21);

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
                       Console.WriteLine("1 - Sucursal");
                       Console.WriteLine("2 - Domicilio");
                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                       if (opcionSeleccionada == 1)
                       {
                           tipoEnvio = "Sucursal";
                       }
                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);
                   Console.Clear();


                   numeroIntentos = 0;
                   opcionSeleccionada = 0;
                   do
                   {
                       if (numeroIntentos >= 1)
                       {
                           Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
                           Console.ReadLine();
                       }

                       //PROVINCIA DESTINO
                       Console.WriteLine("");
                       Console.WriteLine("Seleccione provincia Destino:");
                       Console.WriteLine("1 - Buenos Aires");
                       Console.WriteLine("2 - Catamarca");
                       Console.WriteLine("3 - Chaco");
                       Console.WriteLine("4 - Chubut");
                       Console.WriteLine("5 - Cordoba");
                       Console.WriteLine("6 - Corrientes");
                       Console.WriteLine("7 - Entre Rios");
                       Console.WriteLine("8 - Formosa");
                       Console.WriteLine("9 - Jujuy");
                       Console.WriteLine("10 - La pampa");
                       Console.WriteLine("11 - La Rioja");
                       Console.WriteLine("12 - Mendoza");
                       Console.WriteLine("13 - Misiones");
                       Console.WriteLine("14 - Neuquen");
                       Console.WriteLine("15 - Rio Negro");
                       Console.WriteLine("16 - San Juan");
                       Console.WriteLine("17 - San Luis");
                       Console.WriteLine("18 - Santa Cruz");
                       Console.WriteLine("19 - Santa Fe");
                       Console.WriteLine("20 - Santiago Del Estero");
                       Console.WriteLine("21 - Tierra del fuego");

                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 21);

                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);

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
                       Console.WriteLine("1 - Bahia Blanca");
                       Console.WriteLine("2 - Bragado");
                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                       if (opcionSeleccionada == 1)
                       {
                           sucursalDestino = "Bahia Blanca, Buenos Aires";
                       }

                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);


                   //DIRECCION DESTINO Y DATOS DESTINATARIO

                   Console.Clear();
                     Console.WriteLine("------------------------------------------");
                     Console.WriteLine("DATOS DEL DESTINATARIO");
                     Console.WriteLine("------------------------------------------");
                     Console.WriteLine("");

                 /*  numeroIntentos = 0;
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
                   );*/


        //nombre destinatario
        /*  numeroIntentos = 0;
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

          Console.WriteLine($"* Tipo de envío: Correspondencia");
          Console.WriteLine($"* Prioridad: Normal");
          Console.WriteLine($"* Origen:  SUCURSAL 06, Av Libertador 146,  Martinez, Buenos Aires");
          Console.WriteLine($"* Destino: SUCURSAL 24, Los Condores 860, Bahia Blanca, Buenos Aires");
          Console.WriteLine($"* Nombre y apellido del receptor:{servicio.nombreDestinatario}, {servicio.apellidoDestinatario}");
          Console.WriteLine($"* DNI del receptor:{servicio.DNIDestinatario}");
          Console.WriteLine($"* Cotización del envío: ${servicio.costoEnvio}");
          Console.WriteLine(" ");


          numeroIntentos = 0;
          opcionSeleccionada = 0;
          do
          {
              if (numeroIntentos >= 1)
              {

                  Console.ReadKey();
                  Console.Clear();
                  MenuPrincipal.mostrar(servicio);
              }

              //PRIORIDAD
              Console.WriteLine("");
              Console.WriteLine("Por favor, indique si desea confirmar o rechazar la solicitud");
              Console.WriteLine("1 - CONFIRMAR");
              Console.WriteLine("2 - RECHAZAR");
              opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
              if (opcionSeleccionada == 1)
              {
                  Console.Clear();
                  Console.WriteLine($"¡Su solicitud se regitró, exitosamente!");
                  Console.WriteLine($"Su número de Seguimiento es: 30541");
                  Console.WriteLine($" ");
                  Console.WriteLine($"¡Gracias por elegirnos!");
                  Console.WriteLine($" ");
                  Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                  Console.ReadKey();
                  Console.Clear();
                  MenuPrincipal.mostrar(servicio);
              }

              numeroIntentos++;

          } while (opcionSeleccionada != 1);

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
          Console.WriteLine($" fecha de solicitud: {DateTime.Today}");
          Console.WriteLine($"* Numero de orden de servicio: {servicio.nroSeguimiento}");
          Console.WriteLine($"* Estado de servicio:  {estadoOrden}");
          Console.WriteLine($"* Nombre y apellido del receptor:{servicio.nombreDestinatario}, {servicio.apellidoDestinatario}");
          Console.WriteLine($"* Destino: {servicio.direccionDestino}" + "Cosquin, Cordoba");
          Console.WriteLine("");
          Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
          Console.ReadKey();
          Console.Clear();
          MenuPrincipal.mostrar(servicio);
          break;
      case 3:
          Console.WriteLine("------------------------------------------");
          Console.WriteLine("        ESTADO DE CUENTA");
          Console.WriteLine("------------------------------------------");

          Console.WriteLine($" Nicolas Martinez, El detalle de tus ordenes de servicio: ");
          Console.WriteLine(" ");
          Console.WriteLine($" fecha de solicitud: {DateTime.Today}");
          Console.WriteLine(" ");
          Console.WriteLine($"* Numero de orden de servicio: {servicio.nroSeguimiento}");
          Console.WriteLine($"importe: ${servicio.costoEnvio}");
          Console.WriteLine($"Estado del pago: A PAGAR");
          Console.WriteLine($"Total envios pendientes de facturacion: 0");
          Console.WriteLine($"Total envios impagos: 1");
          Console.WriteLine($"Total envios pagos:0");

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
  }*/






















        /*  switch (opcionSeleccionada)
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

                   // Unica opcion desarrollada --> Correspondencia
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
                       Console.WriteLine("Por favor, ingrese el tipo de envío que desea realizar");
                      // Console.WriteLine("");
                       Console.WriteLine("1 -Correspondencia (sobres hasta 500g)");
                       Console.WriteLine("2 -Encomienda (bultos de 500g a 30kg)");
                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                       if (opcionSeleccionada == 1)
                       {
                           seleccionEnvio = "Correspondencia";
                       }

                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);
                   Console.Clear();


                   // Unica opcion desarrollada --> Normal
                   numeroIntentos = 0;
                   opcionSeleccionada = 0;
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
                       Console.WriteLine("2 - Urgente (48hs)");
                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                       if (opcionSeleccionada == 1)
                       {
                           prioridad = "Normal";
                       }

                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);


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
                       Console.WriteLine("1 - Sucursal");
                       Console.WriteLine("2 - Domicilio");
                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                       if (opcionSeleccionada == 1)
                       {
                           tipoEnvio = "Sucursal";
                       }
                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);
                   Console.Clear();


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
                       Console.WriteLine("Seleccione provincia de origen:");
                       Console.WriteLine("1 - Buenos Aires");
                       Console.WriteLine("2 - Catamarca");
                       Console.WriteLine("3 - Chaco");
                       Console.WriteLine("4 - Chubut");
                       Console.WriteLine("5 - Cordoba");
                       Console.WriteLine("6 - Corrientes");
                       Console.WriteLine("7 - Entre Rios");
                       Console.WriteLine("8 - Formosa");
                       Console.WriteLine("9 - Jujuy");
                       Console.WriteLine("10 - La pampa");
                       Console.WriteLine("11 - La Rioja");
                       Console.WriteLine("12 - Mendoza");
                       Console.WriteLine("13 - Misiones");
                       Console.WriteLine("14 - Neuquen");
                       Console.WriteLine("15 - Rio Negro");
                       Console.WriteLine("16 - San Juan");
                       Console.WriteLine("17 - San Luis");
                       Console.WriteLine("18 - Santa Cruz");
                       Console.WriteLine("19 - Santa Fe");
                       Console.WriteLine("20 - Santiago Del Estero");
                       Console.WriteLine("21 - Tierra del fuego");

                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 21);

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
                       Console.WriteLine("1 - Sucursal");
                       Console.WriteLine("2 - Domicilio");
                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                       if (opcionSeleccionada == 1)
                       {
                           tipoEnvio = "Sucursal";
                       }
                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);
                   Console.Clear();


                   numeroIntentos = 0;
                   opcionSeleccionada = 0;
                   do
                   {
                       if (numeroIntentos >= 1)
                       {
                           Console.WriteLine("Opcion aun no desarrollada, presione ENTER para reintentarlo");
                           Console.ReadLine();
                       }

                       //PROVINCIA DESTINO
                       Console.WriteLine("");
                       Console.WriteLine("Seleccione provincia Destino:");
                       Console.WriteLine("1 - Buenos Aires");
                       Console.WriteLine("2 - Catamarca");
                       Console.WriteLine("3 - Chaco");
                       Console.WriteLine("4 - Chubut");
                       Console.WriteLine("5 - Cordoba");
                       Console.WriteLine("6 - Corrientes");
                       Console.WriteLine("7 - Entre Rios");
                       Console.WriteLine("8 - Formosa");
                       Console.WriteLine("9 - Jujuy");
                       Console.WriteLine("10 - La pampa");
                       Console.WriteLine("11 - La Rioja");
                       Console.WriteLine("12 - Mendoza");
                       Console.WriteLine("13 - Misiones");
                       Console.WriteLine("14 - Neuquen");
                       Console.WriteLine("15 - Rio Negro");
                       Console.WriteLine("16 - San Juan");
                       Console.WriteLine("17 - San Luis");
                       Console.WriteLine("18 - Santa Cruz");
                       Console.WriteLine("19 - Santa Fe");
                       Console.WriteLine("20 - Santiago Del Estero");
                       Console.WriteLine("21 - Tierra del fuego");

                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 21);

                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);

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
                       Console.WriteLine("1 - Bahia Blanca");
                       Console.WriteLine("2 - Bragado");
                       opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
                       if (opcionSeleccionada == 1)
                       {
                           sucursalDestino = "Bahia Blanca, Buenos Aires";
                       }

                       numeroIntentos++;

                   } while (opcionSeleccionada != 1);


                   //DIRECCION DESTINO Y DATOS DESTINATARIO

                   Console.Clear();
                     Console.WriteLine("------------------------------------------");
                     Console.WriteLine("DATOS DEL DESTINATARIO");
                     Console.WriteLine("------------------------------------------");
                     Console.WriteLine("");

                 /*  numeroIntentos = 0;
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
                   );*/


        //nombre destinatario
        /*  numeroIntentos = 0;
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

          Console.WriteLine($"* Tipo de envío: Correspondencia");
          Console.WriteLine($"* Prioridad: Normal");
          Console.WriteLine($"* Origen:  SUCURSAL 06, Av Libertador 146,  Martinez, Buenos Aires");
          Console.WriteLine($"* Destino: SUCURSAL 24, Los Condores 860, Bahia Blanca, Buenos Aires");
          Console.WriteLine($"* Nombre y apellido del receptor:{servicio.nombreDestinatario}, {servicio.apellidoDestinatario}");
          Console.WriteLine($"* DNI del receptor:{servicio.DNIDestinatario}");
          Console.WriteLine($"* Cotización del envío: ${servicio.costoEnvio}");
          Console.WriteLine(" ");


          numeroIntentos = 0;
          opcionSeleccionada = 0;
          do
          {
              if (numeroIntentos >= 1)
              {

                  Console.ReadKey();
                  Console.Clear();
                  MenuPrincipal.mostrar(servicio);
              }

              //PRIORIDAD
              Console.WriteLine("");
              Console.WriteLine("Por favor, indique si desea confirmar o rechazar la solicitud");
              Console.WriteLine("1 - CONFIRMAR");
              Console.WriteLine("2 - RECHAZAR");
              opcionSeleccionada = Utils.solcitarNumeroEntre(1, 2);
              if (opcionSeleccionada == 1)
              {
                  Console.Clear();
                  Console.WriteLine($"¡Su solicitud se regitró, exitosamente!");
                  Console.WriteLine($"Su número de Seguimiento es: 30541");
                  Console.WriteLine($" ");
                  Console.WriteLine($"¡Gracias por elegirnos!");
                  Console.WriteLine($" ");
                  Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                  Console.ReadKey();
                  Console.Clear();
                  MenuPrincipal.mostrar(servicio);
              }

              numeroIntentos++;

          } while (opcionSeleccionada != 1);

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
          Console.WriteLine($" fecha de solicitud: {DateTime.Today}");
          Console.WriteLine($"* Numero de orden de servicio: {servicio.nroSeguimiento}");
          Console.WriteLine($"* Estado de servicio:  {estadoOrden}");
          Console.WriteLine($"* Nombre y apellido del receptor:{servicio.nombreDestinatario}, {servicio.apellidoDestinatario}");
          Console.WriteLine($"* Destino: {servicio.direccionDestino}" + "Cosquin, Cordoba");
          Console.WriteLine("");
          Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
          Console.ReadKey();
          Console.Clear();
          MenuPrincipal.mostrar(servicio);
          break;
      case 3:
          Console.WriteLine("------------------------------------------");
          Console.WriteLine("        ESTADO DE CUENTA");
          Console.WriteLine("------------------------------------------");

          Console.WriteLine($" Nicolas Martinez, El detalle de tus ordenes de servicio: ");
          Console.WriteLine(" ");
          Console.WriteLine($" fecha de solicitud: {DateTime.Today}");
          Console.WriteLine(" ");
          Console.WriteLine($"* Numero de orden de servicio: {servicio.nroSeguimiento}");
          Console.WriteLine($"importe: ${servicio.costoEnvio}");
          Console.WriteLine($"Estado del pago: A PAGAR");
          Console.WriteLine($"Total envios pendientes de facturacion: 0");
          Console.WriteLine($"Total envios impagos: 1");
          Console.WriteLine($"Total envios pagos:0");

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
  }*/

    }

    }

}


