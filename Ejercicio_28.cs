using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que calcula el promedio de tres calificaciones y que nos da el promedio y la diferencia de
            // cada calificacion usando un arreglo
            //Variables

            double[] calif = new double[3]; //Declaro el arreglo de tipo double y con 4 variables
           
            double promedio = 0.0;
            double sumatoria = 0.0;
            double diferencia = 0.0;
            int n = 0;
            //   string dato = ""; otra forma para para convertir array double a string

            //pedimos las calificaciones
            for(n = 0; n < 3; n++) // menos a 3 por los elementos del arreglo;para que sean tres variables
            {
                //pido las calificaciones
                Console.WriteLine("Dame la calificacion");
               // dato =Console.ReadLine();
               // calif[n] = Convert.ToDouble(dato);

                calif[n] = Convert.ToDouble(Console.ReadLine()); //cuando n = 0 el numero va a estar guardado en la 1era variable del array,etc
             }
            //Calculamos el promedio
            for(n = 0;n < 3; n++)
            {
                sumatoria += calif[n]; //Suma las tres calificaciones
            }
            promedio = sumatoria / 3;
            // Calculamos diferencia e imprimimos
            for(n = 0; n < 3; n++)
            {
                diferencia = promedio - calif[n];
                Console.WriteLine($"La calificacion es: {calif[n]}, el promedio es: {promedio}, y su diferencia es de: {diferencia}");
            }
            Console.ReadLine();
        }
    }
}
