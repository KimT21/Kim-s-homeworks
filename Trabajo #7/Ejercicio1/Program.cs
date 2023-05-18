using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Realice un programa en C# para determinar el área en metros cuadrados de
              un terreno rectangular cuyo frente y fondo se dan en pies. Solicite los datos de 
             frente y fondo, el sistema debe mostrar el área en m2.  */

            Console.WriteLine("Calcular área de un terreno de forma rectangular \n");
            Console.WriteLine("Digite el frente del terreno en pies");
            float frente, fondo, metrosCuadrados, piesCuadrados;

            frente = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el fondo del terreno en pies");
            fondo = float.Parse(Console.ReadLine());

            piesCuadrados = frente * fondo;
            metrosCuadrados = (float)(piesCuadrados / 10.764);

            Console.WriteLine("El área del terreno es de " + metrosCuadrados + "m2");
            Console.ReadKey();
        }
    }
}
