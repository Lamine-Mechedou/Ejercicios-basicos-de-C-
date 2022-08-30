using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando switch crea un programa que convierte de millas a kilometros o de kilometros a millas,segun
            //lo desea el usuario

            //Variables
            double numero = 0.0;
            double resultado = 0.0;
            int opcion = 0;

            // Pedir el numero
            Console.WriteLine("Ingrese el numero que quiere convertir");
            numero = Convert.ToDouble(Console.ReadLine());

            //Pedir elegir una opcion
            Console.WriteLine("1.de kilometros a millas , 2.de millas a kilometros");
            Console.WriteLine("Seleccione una opcion");
            opcion = Convert.ToInt32(Console.ReadLine());

            
            switch (opcion)
            {
                case 1: //determinar si es de km a millas
                    resultado = numero * 0.62; //calcular
                    break;
                case 2://determinar si es de km a millas
                    resultado = numero / 0.62; // calcular
                    break;

                default:
                    Console.WriteLine("La opcion es invalida");
                    break;
            }

            //Mostrar resultado
            Console.WriteLine($"El resultado es : {resultado}");
            Console.ReadLine();

     
        }
    }
}
