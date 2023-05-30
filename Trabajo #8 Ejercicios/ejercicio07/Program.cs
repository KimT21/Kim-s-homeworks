using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
    class Program
    {
        /* 7.Leer 10 números e indicar cuánto suman los números pares.*/
        static void Main(string[] args)
        {
            int i = 1, numeros = 0, sumaPares = 0; //variable

            while (i <= 10)
            {
                Console.WriteLine($"{i}).Digite un número para sumarlo");
                numeros = int.Parse(Console.ReadLine()); //leer entero
                if (numeros % 2 == 0) //verificando si es par
                {
                    sumaPares += numeros;
                }
                    
                i++;
            }
            Console.WriteLine($"La suma de los números pares digitados es de: {sumaPares}");
            Console.ReadKey();
        }
    }
}
