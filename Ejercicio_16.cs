using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que calcula el promedio de 3 numeros

            // variables
            double num1 = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double promedio = 0.0;

            //Pedimos los numeros
            Console.WriteLine("Dame el numero 1");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame el numero 2");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame el numero 3");
            num3 = Convert.ToDouble(Console.ReadLine());


            //Hacer el calculo

            promedio = (num1 + num2 + num3) / 3;


            //Mostrar el promedio
            Console.WriteLine($"El promedio de {num1}, {num2} y {num3} es: {promedio}");
            Console.ReadLine();

            //Esta correcto el codigo pero se el codigo se vuelve muy largo si tenemos que
            // sacar el promedio de muchos numeros o cualquier cantidad de numeros,para eso 
            // necesitamos de "for" ya que podemos precisar la cantidad de veces que necesitamos
            

        }
    }
}
