using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2.	Los empleados de una tienda reciben un salario base mensual, más un 
            10% por comisión sobre las ventas realizadas mensualmente. Realice un
            programa en C# que calcule el salario bruto del empleado. 
            */
            Console.WriteLine("Calcular salario bruto, según salario base y la comisión según ventas \n");
            Console.WriteLine("Digite el salario base del empleado");
            int salarioBase;
            salarioBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el monto total en ventas obtenido en este mes");
            float ventas, comision; 
            ventas = float.Parse(Console.ReadLine());
            comision = (float)(ventas * .1);
            float salarioBruto;
            salarioBruto = salarioBase + comision;

            Console.WriteLine("\n El salario bruto del empleado es de " + salarioBruto);
            Console.ReadKey();
        }
    }
}
