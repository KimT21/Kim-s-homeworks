﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    class Program
    {
        /*6.Leer 10 números e indicar cuánto es la suma de todos ellos.*/
        static void Main(string[] args)
        {
            int i = 1 ,numeros = 0, suma = 0;//variables

            while(i <= 10)
            {
                Console.WriteLine($"{i}).Digite un número para sumarlo");
                numeros = int.Parse(Console.ReadLine());
                suma += numeros;
                i++;
                Console.WriteLine("\n"); // salto de linea 
            }

            Console.WriteLine($"La suma de los números digitados es de: {suma}"); //mostrar en pantalla
            Console.ReadKey();

        }
    }
}
