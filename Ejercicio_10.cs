using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que imprime la suma solo si el primer numero No sea menor a 10

            // variables

            double num1 = 0;
            double num2 = 0;
            double suma = 0;


            // pedir los numeros

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());


            // Determinar si el primer numero NO es menor a 10
            if(!(num1 < 10))
            {
                // Calucular la suma
                suma = num1 + num2;
                //Mostrar el resultado
                Console.WriteLine($"La suma del numero {num1} y {num2} es {suma}");
            }


            // Determinar si el primer numero ES menor a 10
            else
            {
                //Mostrar el resultado de no poder realizar la suma
                Console.WriteLine($"Disculpe! No se puede realizar la suma ya que el primer numero {num1} no es menor a 10");
            }
            Console.ReadLine();
           
        }
    }
}
