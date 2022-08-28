using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular el promedio de 3 numeros

            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double promedio = 0;

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero");
            num3 = Convert.ToDouble(Console.ReadLine());

            promedio = (num1 + num2 + num3) / 3.0;

            Console.WriteLine($"El promedio de los numeros {num1}, y {num2} y {num3} es : {promedio}");
            Console.ReadLine();


        }
    }
}
