using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMensajeria
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

    }
}

