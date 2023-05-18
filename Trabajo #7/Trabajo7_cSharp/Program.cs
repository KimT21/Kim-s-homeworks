using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo7_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinar el área en metros cuadrados de un terreno");
            Console.WriteLine("Ingrese el frente del terreno en pies");
            float frente; float fondo;

            frente = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el fondo del terreno en pies");
            fondo = float.Parse(Console.ReadLine());

            float piesCuadrados = (frente * fondo);
            float metrosCuadrados = (float)(piesCuadrados / 10.764);

            Console.WriteLine("El terreno tiene un área de " + metrosCuadrados + "m2.");
            Console.ReadKey(); 
        }
    }
}
