using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    class Program
    {
        /*5.Construya un programa que permita leer una cantidad variable de números
         * hasta que se ingresen 5 números negativos. Indicar cantidad total de números leídos. */
        static void Main(string[] args)
        {
            int i = 0, numero, cantNegativos = 0;//variables
            bool salir = true; 

            while (salir) {
                Console.WriteLine("Digite un número, cuando se digiten 5 negativos el programa termina");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0) // cuenta los números negativos 
                {
                    cantNegativos++;

                    if (cantNegativos >= 5) //cuando llegue a 5 se saldrá del programa
                        salir = false;
                }

                i++; // Cantidad de ciclos 
            }
            Console.WriteLine($"Cantidad total de números digitados {i}");
            Console.ReadKey();
        }
    }
}
