using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que le va a pedir al usuario escribir un numeros de 0 a 10
            //depues el programa me dice cuantas veces aparecio cada numero y por ultimo me
            //indica cual es el numero que se repitio mas veces

            //Variables
            int[] valores = new int[11];
            int numero = 0;
            string dato = "";
            int n = 0; //para el control del arreglo
            int mayor = 0;

            for(n = 0; n < 11; n++)
            {
                Console.WriteLine("Dame un numero entre 0 y 10");
                dato = Console.ReadLine();
                numero = Convert.ToInt32(dato);

                valores[numero]++; // me sirve como contado
            }
            for (n = 0; n < 11; n++)
            {
              Console.WriteLine($"El numero: {n} aparecio: {valores[n]} veces");
            }
            for (n = 0; n < 11; n++)
            {
                if (valores[n] > mayor) //cada vez que hace una repeticion y encuentra un mayor lo guarda en n
                    mayor = n;
             
            }
            Console.WriteLine($"El numero que se repetio mas veces es: {mayor}");

            Console.ReadLine();

        }
        
    }

}
