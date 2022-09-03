using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que permite calcular el promedio de cualquier cantidad de numeros usando el ciclo "for"

            // Variables
            int cantidad = 0;
            int n = 0;
            double sumatoria = 0;
            double valor = 0.0;
            double promedio = 0.0;

            //Pedimos la cantidad de numeros
            Console.WriteLine("Cuantos numeros van a ser?");
            cantidad = Convert.ToInt32(Console.ReadLine());//con la cantidad voy a controlar el ciclo for

            for(n = 0;n < cantidad; n++) //n++ ==> n = n+1
            {
                Console.WriteLine("Dam2 el numero");
                valor = Convert.ToDouble(Console.ReadLine());
                sumatoria += valor; // es lo mismo que sumatoria = sumatoria + valor;
                //sumatoria es un acumulador
            }

            promedio = sumatoria / cantidad;
            Console.WriteLine($"El promedio es: {promedio} ");
            Console.ReadLine();
        }
    }
}
