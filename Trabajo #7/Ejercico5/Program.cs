using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5.	Realice un programa en C# en donde solicite al usuario ingresar una cantidad de MB, 
                y se muestre en pantalla su equivalencia en bits, byte, kilobyte y Gigabytes.
             */
            float MB, b, B, KB, GB;
            Console.WriteLine("Ingrese una cantidad de MB"); 
            MB = float.Parse(Console.ReadLine());
            KB = MB * 1024;
            B = KB * 8;
            b = B * 1;
            GB = MB / 1024;

            Console.WriteLine("\n\n");
            Console.WriteLine(MB + " MB son " + b + " bits");
            Console.WriteLine(MB + " MB son " + B + " bytes");
            Console.WriteLine(MB + " MB son " + KB + " kilobytes");
            Console.WriteLine(MB + " MB son " + GB + " gigabytes");

            Console.ReadKey();
        }
    }
}
