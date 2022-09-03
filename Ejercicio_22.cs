using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ciclo que va de forma regresiva
            int n = 0;
            Console.WriteLine("Ciclo que cuenta regresivamente");
            for(n = 10;n > 0; n--)
            {
                Console.WriteLine(n);
                // Console.ReadLine(); aca imprime cada ciclo cada vez que hago enter
            }
            Console.ReadLine();//aca imprimi todos los ciclos de una
        }
    }
}
