using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un ciclo que incrementa de 2 en 2

            int n = 0;
            Console.WriteLine("Este ciclo avanza de dos en dos");
            for (n = 0; n < 100; n = n + 2) // ciclo que se va a repetir 100 veces saltando de a dos
                Console.Write($"{n}");
            Console.ReadLine();


        }
    }
}
