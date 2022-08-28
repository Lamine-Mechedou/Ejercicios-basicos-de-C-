using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que dice si un programa es par o impar

            //pedir un numero

            Console.WriteLine("Ingresar un numero intero");
            int numero = 0;
            numero = Convert.ToInt32(Console.ReadLine());

            //verificar si es par
            if (numero % 2 == 0)
            {     //Mostrar
               Console.WriteLine($"el numero {numero} es par");
            }

            //verificar si es impar
            else
                    {  //Mostrar
                Console.WriteLine($"el numero {numero} es impar");
            }
            Console.ReadLine();
        }
    }
}