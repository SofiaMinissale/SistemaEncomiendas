
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

        //Devuelve true si es valido el DNI
        public static bool esDNIValido(string dni)
        {
            //Comprobamos si el DNI tiene 8 digitos
            if (dni.Length != 8)
            {
                //No es un DNI Valido
                return false;
            }

            bool numbersValid = int.TryParse(dni, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                return false;
            }
            //DNI Valido
            return true;
        }

        public static int solicitarDocumento()
        {
            bool esPrimerIntento = true;
            int nroIngresado;
            bool esNumeroValido;

            do
            {
                if (!esPrimerIntento)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Debe ingresar un numero de documento valido");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                esNumeroValido = int.TryParse(Console.ReadLine(), out nroIngresado);
                esPrimerIntento = false;
            }
            while (nroIngresado < 10000000 || nroIngresado > 100000000 || esNumeroValido == false);

            return nroIngresado;
        }


        public static bool nroSeguimientoValido(string nroSeguimiento)
        {
            
            if (nroSeguimiento.Length != 5 && nroSeguimiento != "82884")
            {
                return false;
            }

            bool numbersValid = int.TryParse(nroSeguimiento, out int nroSeguimientoInteger);
            if (!numbersValid)
            {  
                return false;
            }
            return true;
        }

        public static void lineChanger(string newText, string fileName, int line_to_edit)
        {

            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        public static int solicitarNumeroEnvioExistente(List<int> envios)
        {
            bool esPrimerIntento = true;
            int nroIngresado;
            bool esNumeroValido;

            do
            {
                if (!esPrimerIntento)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Debe ingresar un numero de seguimiento valido");
                    Console.ForegroundColor = ConsoleColor.White;

                }

                esNumeroValido = int.TryParse(Console.ReadLine(), out nroIngresado);

                esPrimerIntento = false;
            }
            while (!(envios.IndexOf(nroIngresado) != -1) || esNumeroValido == false);


            return nroIngresado;

        }

    }
}


