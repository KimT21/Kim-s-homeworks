using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio09
{
    class Program
    {   /*9.Leer una cantidad de números variables hasta que se ingrese un número múltiplo de 5.
         * Indicar el número de datos que fueron ingresados, sin contar el múltiplo de la condición de término.*/
        static void Main(string[] args)
        {
            int i = 0, numeros;//variables
            bool salir = true;
            while (salir)
            {
                Console.WriteLine($"Digite un número");
                numeros = int.Parse(Console.ReadLine()); //leyendo números
                i++;
                if (numeros % 5 == 0) //verificando que el número sea divisible entre 5 
                {
                    salir = false;
                }

                
            }

            Console.WriteLine($"Se ingresaron {i} números.");
            Console.ReadKey();
        }
    }
}
