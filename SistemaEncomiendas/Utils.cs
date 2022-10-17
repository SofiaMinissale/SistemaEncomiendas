
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEncomiendas
{
    public static class Utils
    {
        public static int solcitarNumeroEntre(int numero1, int numero2)
        {
            bool esPrimerIntento = true;
            int nroIngresado;
            bool esNroEntero;

            do
            {
                if (!esPrimerIntento)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Debe seleccionar una opcion valida");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                esNroEntero = int.TryParse(Console.ReadLine(), out nroIngresado);
                esPrimerIntento = false;
            }
            while (nroIngresado == 0 || nroIngresado < numero1 || nroIngresado > numero2 || esNroEntero == false);

            return nroIngresado;
        }

        public static double solicitarPeso()
        {
            bool esPrimerIntento = true;
            double nroIngresado;
            bool esNumeroValido;

            do
            {
                if (!esPrimerIntento)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El peso de encomienda debe ser superior a 0.0 KG y menor a 30 KG");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                esNumeroValido = double.TryParse(Console.ReadLine(), out nroIngresado);
                esPrimerIntento = false;
            }
            while (nroIngresado == 0 || nroIngresado < 0 || nroIngresado > 30 || esNumeroValido == false);

            return nroIngresado;
        }

        public static bool validarInputSiNO()
        {
            string valorIngresado;
            bool esPrimerIntento = true;

            do
            {
                if (!esPrimerIntento)
                {
                    Console.Clear();
                    Console.WriteLine("Recuerde que debe responder con 'SI' o 'NO'");
                }
                valorIngresado = Console.ReadLine().ToUpper();
                esPrimerIntento = false;
            } while (!valorIngresado.Equals("SI") && !valorIngresado.Equals("NO"));

            Console.Clear();

            if (valorIngresado.Equals("SI"))
            {
                return true;
            }

            return false;
        }

    }
}


