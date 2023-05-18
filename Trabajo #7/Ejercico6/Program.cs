using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6.Dados 12 salarios de un trabajador, determine cuál es el monto de aguinaldo que le corresponde. */
            float salario, sumaSalario, aguinaldo;
            sumaSalario = 0; 
            Console.WriteLine("Calcular aguinaldo");

            for (int i = 1; i <= 12 ; i++)
            {
                Console.WriteLine("Digite el salario obtenido en el mes " + i);
                salario = float.Parse(Console.ReadLine());
                sumaSalario += salario; 
            }
            aguinaldo = sumaSalario / 12;

            Console.WriteLine("El aguinaldo del trabajador es de: " + aguinaldo);
            Console.ReadKey(); 
        }
    }
}
