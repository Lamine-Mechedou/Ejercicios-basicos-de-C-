using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que imprime Hola 5 veces

            int n = 0;
            for(n = 0; n < 5; n++)
            {
                Console.WriteLine($"Hola {n}"); // me va a imprimir hola y el valor de n
                // Console.ReadLine(); aca va a imprimir pero cuando hago enter cada vez
            }
            Console.ReadLine();
        }
    }
}
