using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que muestra el uso de arreglos en dos dimensiones o matrices

            //Ejemplo:crear un programa que es una tabla para poder colocar la temperatura 
            //de los diferentes dias por semana despues calcular el promedio por semana y 
            //el promedio total.

            //Entonces creo mi tabla(matriz) que va a tener 4 renglones(cada renglon representa una semana)
            //y 7 columnas(cada columna representa un dia de la semana)

            //Variables
            int n = 0; //n y m son variables de control para el ciclo for
            int m = 0;
            double sumatoria = 0.0;
            double promedio = 0.0;
            Random rnd = new Random(); // lo que hace randon es seleccionar un numero al azar y nosotros lo podemos usar
                                       // aca lo usamos para rtellenar la informacion de la matriz
            int[,] datos = new int[4, 7]; // creamos la matriz;una coma indica que voy a usar dos indices

            //Llenamos los datos

            for(n = 0;n < 4;n++) //Creo un ciclo n que va avanzando en renglones
            {
                for(m = 0; m < 7; m++) //ciclo anidado m que avanza en las columnas
                                       //Con estos dos ciclos tengo llena mi matriz
                {
                    datos[n, m] = rnd.Next(30);//aca voy asignando valores a la matriz por medio de random,puedo usar datos del usuario si quiero,..etc
                }
            }
            //imprimimos los datos
            for(n = 0; n < 4; n++)
            {
                Console.WriteLine($"Semana {n}");
                for (m = 0; m < 7; m++)
                {
                    Console.Write($"{datos[n,m]} , ");
                }
                Console.WriteLine();
            }
            //Calculamos el promedio por semana
            for(n = 0; n < 4; n++)
            {
                sumatoria = 0.0;
                promedio = 0.0;

                for(m = 0; m < 7; m++)
                {
                    sumatoria += datos[n, m];
                }
                promedio = sumatoria / 7.0;
                   Console.WriteLine($"El promedio de la semana {n} es: {promedio}");
            }
            //Calculamos el promedio total
            sumatoria = 0.0;
            promedio = 0.0;
            for(n = 0; n < 4; n++)
            {
                for(m = 0; m < 7; m++)
                {
                    sumatoria += datos[n, m];
                }
            }
            promedio = sumatoria / 28.0;
            Console.WriteLine($"El promedio total es: {promedio}");
            Console.ReadLine();
        }
        
    }
}
