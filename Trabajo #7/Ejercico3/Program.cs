using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             3.	Conversión de horas, minutos y segundos a segundos. Solicite al usuario ingresar una 
            cantidad de horas, una cantidad de minutos y una cantidad de segundos, y el programa debe 
            indicar cuantos segundos representan los datos ingresados. Ejemplo: 1 hora, 26 minutos y
            40 segundos, equivalen a 5200 segundos.
             * */

            Console.WriteLine("Conversión de horas, minutos, segundos a segundos \n");
            Console.WriteLine("Digite una cantidad de horas");
            int horas, minutos, segundos, segundosTotales;
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite una cantidad de minutos");
            minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite una cantidad de segundos");
            segundos = int.Parse(Console.ReadLine());

            segundosTotales = (horas*60*60)+(minutos*60)+segundos;
            Console.WriteLine("La cantidad total de segundos es de: " + segundosTotales); 
            Console.ReadKey(); 
        }
    }
}
