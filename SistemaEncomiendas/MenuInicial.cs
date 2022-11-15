
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
            Login login = null;

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
                Console.WriteLine("");

                Console.WriteLine("INGRESE SU NUMERO DE CUIT:");
                string cuit = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("INGRESE SU NOMBRE DE USUARIO:");
                nombreUsuario = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("INGRESE SU CONTRASEÑA:");
                string contraseña = Console.ReadLine();
                Console.Clear();

                login = new Login(cuit, nombreUsuario, contraseña);

                usuarioValido = login.validarUsuario();
                esPrimerIntento = false;
            }

            Console.WriteLine($"BIENVENIDO {nombreUsuario}!");

            ClienteCorporativo cliente = new ClienteCorporativo(login);
            return cliente;
        }


    }
}
    