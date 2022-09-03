using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que muestra el uso del ciclo do while
            //Se lleva a cabo al menos una vez
            //Se usa cuando no sabemos la cantidad de repeticiones(no es como for que se lo usamos cuando sabemos la cantidad de repeticiones)

            // Crear un programa de cambio de pesos a dolares o al reves,pero no sabemos cuantas veces el usuario va a llevar a cambio estas consultas
            //Variables
            int opcion = 0;
            double tipoCambio = 18.20;
            double pesos = 0.0;
            double dolares = 0.0;

            //Hacemos el ciclo do while
            do
            {
                //Mostramos el menu
                Console.WriteLine("1.Pesos a dolares , 2.Dolares a pesos , 3.Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    //pedimos los pesos
                    Console.WriteLine("Cuantos pesos?");
                    pesos = Convert.ToDouble(Console.ReadLine());

                    //Convertimos
                    dolares = pesos / tipoCambio;
                    Console.WriteLine($"Son {dolares} dolares");
                }
                if (opcion == 2)
                {
                    //Pedidmos los dolares
                    Console.WriteLine("Cuantos dolares");
                    dolares = Convert.ToDouble(Console.ReadLine());
                    //Convertimos
                    pesos = dolares * tipoCambio;
                    Console.WriteLine($"{dolares} dolares son: {pesos} pesos");

                }

            } while (opcion != 3); //hay que poner ; aqui
            Console.WriteLine("Chau!");
            Console.ReadLine();

        }
    }
}
