
using System;
using System.Runtime.CompilerServices;

namespace SistemaEncomiendas
{
    public static class MenuInicial
    {
        public static void mostrar()
        {
            MenuLogueo();
        }

        public static void MenuLogueo()
        {
            /* USUARIO DE PRUEBA:  20306578636768; NicolasMartinez; usuario1  */
            string nombreUsuario = "NicolasMartinez";
            string cuit = "20306578636768";
            string contraseña = "usuario1";

            int numeroIntentos = 0;
            string cuitIngresado;
            string usuarioIngresado;
            string contraseñaIngresada;

            do
            {
                if (numeroIntentos >= 1)
                {
                    Console.WriteLine("Los datos ingresados son incorrectos, pulse una tecla para volver a intentarlo");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine("INGRESE SU NUMERO DE CUIT");
                cuitIngresado = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("INGRESE SU USUARIO");
                usuarioIngresado = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("INGRESE SU CONTRASEÑA");
                contraseñaIngresada = Console.ReadLine();
                Console.Clear();

                numeroIntentos++;

            } while (!cuitIngresado.Equals(cuit) ||
                    !usuarioIngresado.Equals(nombreUsuario) ||
                    !contraseñaIngresada.Equals(contraseña));
            
            Console.WriteLine($"BIENVENIDO {nombreUsuario}");
            MenuPrincipal.mostrar();
        }
    }
}
    