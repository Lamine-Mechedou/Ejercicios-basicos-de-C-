using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando if crea un programa que convierte de millas a kilometros o de kilometros a millas,segun
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

            //Determinar si es de km a millas
            if(opcion == 1)
            {
                //calcular
                resultado = numero * 0.62;
                //mostrar resultado
                Console.WriteLine($"{numero} kilometros son {resultado} de millas");
            } // determinar si es de millas a kilometros
            else if(opcion == 2)
            {
                //calcular
                resultado = numero / 0.62;
                //Mostrar resultado
                Console.WriteLine($"{numero} millas son {resultado} de kilometros");

            }

            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();

            //Determinar si es de millas a km

            //Mostrar resultado
        }
    }
}
