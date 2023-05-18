using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4.	Realice un programa en C# que solicite al usuario una cantidad de segundos, 
            el programa debe mostrar en pantalla cuantas horas, cuantos minutos y cuantos segundos existen.
                    a.	Ejemplo 5200
                        i.	1 hora
                        ii.	26 minutos
                        iii.	40 segundos
             * */

            Console.WriteLine("Convertir de segundos a horas, minutos, segundos");
            Console.WriteLine("\nDigite una cantidad de segundos");
            int horas, segundos, minutos;
            segundos = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nLa conversión de " + segundos + " segundos da como resultado: \n");
            horas = segundos / 3600;
            minutos = (segundos - (horas * 3600)) /60;
            segundos = (segundos - (horas * 3600)) - (minutos * 60); 
            
            Console.WriteLine("Horas: "+ horas + "\nMinutos: "+ minutos + "\nSegundos: " + segundos); 
            Console.ReadKey(); 
        }
    }
}
