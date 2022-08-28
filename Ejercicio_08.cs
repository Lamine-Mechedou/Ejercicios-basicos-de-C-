using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que calcula la suma de dos numeros solo si los dos son menores a 10

            //Variables
            double num1 = 0;
            double num2 = 0;
            double suma = 0;

            //Pedir los dos numeros a sumar

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());


            //Determinar si los dos numeros son mayores a 10
            if(num1 >10 && num2 > 10)
            {    // Calcular la suma
                suma = num1 + num2;
                // Mostrar el resultado
                Console.WriteLine($"La suma del numero {num1} y del numero {num2} es: {suma}");
            }

            //Determinar si uno de los numeros o ambos son menores a 10

            else
            {
                //Mostrar un mensaje informando que uno o ambos son mayores a 10
                Console.WriteLine("Disculpe,uno de los numeros o ambos es menor a 10 y no se puede realizar la suma");

            }
            Console.ReadLine();

            


        }
    }
}
