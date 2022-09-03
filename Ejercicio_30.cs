using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que calcula el promedio y la diferencia de la calificacion pero creando e inicializando el
            //arreglo al mismo tiempo
            //Variables
            double[] calif = {7.5 , 8.0 , 9.2 , 6.7 };
            double promedio = 0.0;
            double sumatoria = 0.0;
            double diferencia = 0.0;
            int n = 0;

            //Calculamos el promedio
            for(n = 0; n < calif.Length; n++)
            {
                sumatoria += calif[n];
            }
            promedio = sumatoria / calif.Length;

            //calculamos la diferencia e imprimimos

            for(n = 0; n < calif.Length; n++)
            {
                diferencia = promedio - calif[n];
                Console.WriteLine($"La calificacion es: {calif[n]} , el promedio es: {promedio} , la diferencia es: {diferencia}");
            }
            Console.ReadLine();

        }
    }
}
