using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_23
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int n = 0;
            int m = 0;
            // Ciclo de cierto numero a otro
            Console.WriteLine("Antes del ciclo");

            for (n = 0; n < 5; n++) //errores comunes:poner ; despues de for y en la condicion agregar o igual <=:esto generaria una repeticion mas
                              //otro error es en vez de n++ pongo m++;ahi seria infinito
            {
                Console.WriteLine("En el ciclo");
                Console.WriteLine(n); 
            }
            Console.WriteLine("Fuera del ciclo");
            Console.ReadLine();
        }
        
    }
}
