using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que calcula el promedio y diferencia de clificaciones
            // usando un array y sin saber el tamaño del arreglo.

            //si no sabemos el tamaño del arreglo y solo lo sabemos al momento de la ejecucion:

            //Variables
            //cree un arreglo llamado calif 
            double[] calif;

            double promedio = 0.0;
            double sumatoria = 0.0;
            double diferencia = 0.0;
            string dato = "";
            int n = 0;
            int cantidad = 0;

            //pedimos la cantidad de datos
            Console.WriteLine("Dame la cantidad de calificaciones");
            dato = Console.ReadLine();
            cantidad = Convert.ToInt32(dato);

            //aca inicializo el arreglo que habia creado despues de conseguir el tamaño del arreglo;asi se hace al no saber el tamaño del arreglo
            calif = new double[cantidad];

            //pedimos las calificaciones
            for (n = 0; n < calif.Length; n++) // es lo mismo que poner calif[cantidad]
            {
                Console.WriteLine("Dame la calificacion");
                dato = Console.ReadLine();
                cantidad = Convert.ToInt32(dato);
            }
            //Calculamos el promedio
            for (n = 0; n < calif.Length; n++)
            {
                sumatoria += calif[n];
            }
            promedio = sumatoria / calif.Length;

            //Calculamos la diferencia e imprimimos
            for (n = 0; n < calif.Length; n++)
            {
                diferencia = promedio - calif[n];
                Console.WriteLine($"La calificacion es: {calif.Length} , El promedio es: {promedio} , La diferencia es: {diferencia}");
            }

            Console.ReadLine();
        }
    }
}
