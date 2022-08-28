using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convertir pesos argentinos a dolares.

            int pesos = 0;
            int tasaCambio = 0;
            int dolares = 0;

          
            Console.WriteLine("Ingresa la cantidad de pesos que quieres cambiar a dolares");
            pesos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cual es la tasa de cambio hoy?");
            tasaCambio = Convert.ToInt32(Console.ReadLine());

            dolares = pesos / tasaCambio;

            Console.WriteLine("Con {0} pesos,puedes comprar {1} dolares", pesos, dolares);
            Console.ReadLine();
         
         
        }
    }
}
