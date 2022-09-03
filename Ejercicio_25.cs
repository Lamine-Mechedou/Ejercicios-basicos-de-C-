using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que muestra el ciclo while
            //Puede no llevarse a cabo ni una vez
            //Se usa cuando no sabemos el numero de repeticiones
            // Crear un programa que me indica cuanto gaste en un producto y cuanto 
            //dinero me quedo usando el ciclo while
            //variables
            int dinero = 0;
            int opcion = 0;
            int total = 0;

            //Pedimos la cantidad de dinero
            Console.WriteLine("Cuanto dinero tienes?");
            dinero = Convert.ToInt32(Console.ReadLine());

            while(dinero > 0 && opcion != 5)
            {
                //Presentamos menu
                Console.WriteLine("1.Dulces , 2.Papas , 3.Chocolates , 4.Helado , 5.Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        dinero -= 3; //Nos indica cuanto dinero me quedo al comprar dulces
                        total += 3;//Me indica cuanto gaste al comprar el dulce
                        break;

                    case 2:
                        dinero -= 12;
                        total += 12;
                        break;

                    case 3:
                        dinero -= 7;
                        total += 7;
                        break;

                    case 4:
                        dinero -= 25;
                        total += 25;
                        break;
                }
                Console.WriteLine($"Tienes {dinero} y has gastado {total}");
            }
            // fin del ciclo
            Console.WriteLine("Chau!");
        }
    }
}
