using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que hace la suma de dos numeros solo si uno de los dos es menor a 10

            //variables
            double num1 = 0;
            double num2 = 0;
            double suma = 0;

            //Pedir los numeros al usuario

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            //Determinar si uno de los dos numeros o ambos es menor a 10

            if(num1 < 10 || num2 < 10)
            {
                // Calcular la suma
                suma = num1 + num2;
                // mostrar el resultado
                Console.WriteLine($"La suma del numero {num1} y {num2} es : {suma}");
            }

            // Detrerminar si uno de los numeros o ambos es mayor o igual a 10
            else
            {
                // Mostrar el mensaje de no poder hacer la suma
                Console.WriteLine("Disculpe,uno o ambos numeros es mayor a 10");
            }
            Console.ReadLine();


        }
    }
}
