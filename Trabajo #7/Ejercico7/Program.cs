using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              7.	Se tiene un terreno rectangular cuyas dimensiones de largo y ancho están en
                relación 2 a 1. Solicite el ancho del terreno al usuario.
	            Para cercar con malla este terreno se colocan postes a lo largo del perímetro a 
            una distancia de 2 m uno del otro. ¿Cuántos postes son necesarios para cercar el terreno?
             */

            Console.WriteLine("Digite la cantidad de metros de ancho del terreno");
            float ancho, largo, perimetro; int cantidadPostes; 
            ancho = float.Parse(Console.ReadLine());
            largo = ancho * 2;
            perimetro = ancho + ancho + largo + largo;
            cantidadPostes = (int)(perimetro / 2);

            Console.WriteLine("\nEl terreno con un ancho de " + ancho + " metros y con un largo de " + largo + 
                " metros con un perimetro de " + perimetro + " metros necesita " + cantidadPostes + " postes" +
                " para cercar el terreno con un poste cada 2 metros"); 

            Console.ReadKey();
        }
    }
}
