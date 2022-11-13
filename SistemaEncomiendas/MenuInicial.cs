
using System;
using System.Runtime.CompilerServices;

namespace SistemaEncomiendas
{
    public static class MenuInicial
    {

        /* USUARIO DE PRUEBA:  20306578636768; NicolasMartinez; usuario1  */
   
        public static void mostrar()
        {
            ClienteCorporativo cliente = MenuLogueo();
            MenuPrincipal.mostrar(cliente);
        }

        static ClienteCorporativo MenuLogueo()
        {

            string nombreUsuario = null;

            bool usuarioValido = false;
            bool esPrimerIntento = true;

            while (!usuarioValido)
            {
                if (!esPrimerIntento)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Los datos ingresados son incorrectos, presione ENTER para volver a intentarlo");
                    Console.ForegroundColor = ConsoleColor.White;
                }


                Console.WriteLine("------------------------------------------");
                Console.WriteLine("              INICIAR SESION");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("Ingrese su número de CUIT:");
                string cuit = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Ingrese su Usuario");
                nombreUsuario = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Ingrese su contraseña");
                string contraseña = Console.ReadLine();
                Console.Clear();

                Login usuarioIngresado = new Login(cuit, nombreUsuario, contraseña);

                usuarioValido = usuarioIngresado.validarUsuario();
                esPrimerIntento = false;
            }

            Console.WriteLine($"BIENVENIDO {nombreUsuario}");

            ClienteCorporativo cliente = new ClienteCorporativo();
            cliente.traerDatosCliente(nombreUsuario);

            return cliente;
        }


    }
}
    