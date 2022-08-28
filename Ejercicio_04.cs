using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Realizar la suma,resta,multiplicacion o division de 2 numeros segun lo desse el usuario.


            //variables

            double num1 = 0;
            double num2 = 0;
            int seleccion = 0;
            double resultado = 0;


            //pedir el primer numero

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());


            // pedir el segundo numero

            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            // pedeir que operacion se desea realizar

            Console.WriteLine("1.Suma , 2.Resta , 3.Multiplicacion , 4.Division");
            Console.WriteLine("Seleccione una operacion");

           seleccion = Convert.ToInt32(Console.ReadLine());

            //Realizar la operacion

            if(seleccion == 1) { 
                resultado = num1 + num2; 
            }

            if (seleccion == 2)
            {

                resultado = num1 - num2;
            }


            if (seleccion == 3)
            {

                resultado = num1 * num2;
            }

            if (seleccion == 4)
            {

                resultado = num1 / num2;
            }    
            
            if( seleccion == 0 || seleccion > 4)
            {
                Console.WriteLine("Su seleccion es invalida");
            }
            
            //Mostrar la operacion

             Console.WriteLine($"El resultado es {resultado}");

            Console.ReadLine();


        }
    }
}
