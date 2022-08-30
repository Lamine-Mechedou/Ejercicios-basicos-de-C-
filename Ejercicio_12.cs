using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Realizar la suma,resta,multipilicacion y division de dos numeros,segun lo desee el usuario

            // Variables

            double num1 = 0;
            double num2 = 0;
            double resultado = 0;
            int opcion = 0;

            // Pedir el primer numero
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Pedir el segundo numero
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Pedir la operacion
            Console.WriteLine("1.Suma , 2.Resta , 3.Multiplicacion , 4.Division");
            Console.WriteLine("Seleccione una operacion");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                //Determinar si es suma
                case 1:
                    resultado = num1 + num2;
                    break;

                // determinar si es resta
                case 2:
                    resultado = num1 - num2;
                    break;

                //determinar si es multiplicacion
                case 3:
                    resultado = num1 * num2;
                    break;

                //determinar si es division
                case 4:
                    resultado = num1 / num2;
                    break;

                //Mostrar resultado
                default:
                    Console.WriteLine("Su seleccion es invalida");
                    break;
                    
            }
            
                Console.WriteLine($"El resultado es: {resultado}");
            Console.ReadLine();
            
        }
    }
}
