
using System;
using System.Runtime.CompilerServices;

namespace SistemaEncomiendas
{
    public static class MenuInicial
    {

        public static void mostrar()
        {
            /* USUARIO DE PRUEBA:  20306578636768; NicolasMartinez; usuario1  */
            string nombreUsuario = "NicolasMartinez";
            string cuit = "20306578636768";
            string contraseña = "usuario1";

            int numeroIntentos = 0;
            string cuitIngresado;
            string usuarioIngresado;
            string contraseñaIngresada;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("              INICIAR SESION");
            Console.WriteLine("------------------------------------------");

            do
            {
                if (numeroIntentos >= 1)
                {
                    Console.WriteLine("Los datos ingresados son incorrectos, presione ENTER para volver a intentarlo");
                    Console.ReadLine();
                }

                Console.WriteLine("");
                Console.WriteLine("Introduce tu numero de CUIT:");
                cuitIngresado = Console.ReadLine();
                //Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("Introduce tu nombre de usuario:");
                usuarioIngresado = Console.ReadLine();
                //Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("Introduce tu contraseña:");
                contraseñaIngresada = Console.ReadLine();
                Console.Clear();

                numeroIntentos++;

            } while (!cuitIngresado.Equals(cuit) ||
                    !usuarioIngresado.Equals(nombreUsuario) ||
                    !contraseñaIngresada.Equals(contraseña));

            Console.Clear();
            Console.WriteLine($"BIENVENIDO {nombreUsuario}!");
            MenuPrincipal.mostrar();
        }
    }
}
    