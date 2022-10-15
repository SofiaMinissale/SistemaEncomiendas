
using System;
using System.Runtime.CompilerServices;

namespace SistemaEncomiendas
{
    public static class MenuInicial
    {
        public static void mostrar()
        {
            MenuLogueo();
            MenuPrincipal.mostrar();
        }

        public static void MenuLogueo()
        {
            /* USUARIO DE PRUEBA:  20306578636768; NicolasMartinez; usuario1  */

            string nombreUsuario = "Nicolas Martinez";
            long cuit = 20306578636768;
            double peso = 5;
            string sucursalOrigen = "Buenos Aires";
            string sucursalDestino = "Tierra del Fuego";
            long dni = 36966066;
            int costoEnvio = 5600;
            long NroSeguimiento = 828842;
           
                Console.WriteLine("INGRESE SU NUMERO DE CUIT");
                string numeroCuit = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("INGRESE SU USUARIO");
                nombreUsuario = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("INGRESE SU CONTRASEÑA");
                string contraseña = Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"BIENVENIDO {nombreUsuario}");

            }
        }


    }
    