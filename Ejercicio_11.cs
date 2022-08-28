using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar la suma ,resta,multi,div de dos numeros segun lo desee el usuario

            //variables

            double num1 = 0;
            double num2 = 0;
            double resultado = 0;
            int opcion = 0;

            //pedir los dos numeros

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            //opciones

            Console.WriteLine("1.Suma , 2.Resta , 3.Multiplicacion , 4.Division");
            Console.WriteLine("Seleccione una opcion");
            opcion = Convert.ToInt32(Console.ReadLine());

           
            //determinar si es suma
            if(opcion == 1)
            
                // hacer la suma
                resultado = num1 + num2;
                //Mostrar el resultado
                
           
            //determinar si es resta
            else if (opcion == 2)
            
                // hacer la resta
                resultado = num1 - num2;
                //Mostrar el resultado
               
            

            //determinar si es multiplicacion
           else if (opcion == 3)
            
                // hacer la multiplicacion
                resultado = num1 * num2;
                         

            //determinar si esdivision

            else if (opcion == 4)
            
                // hacer la division
                resultado = num1 / num2;
              
            
            else // Determinar si la opcion es invalida
            
                //Mostrar el mensaje
                Console.WriteLine("Debes elegir una opcion valida");
            // Mostramos el resultado
            Console.WriteLine($"El resultado es {resultado}");


            Console.ReadLine();



        }
    }
}
