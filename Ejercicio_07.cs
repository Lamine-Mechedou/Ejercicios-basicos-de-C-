using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pide datos solo a los mayores de 18 años

            // variables
            int edad = 0;
            string nombre = "";
            string apellido = "";
            int diferencia = 0;
            string mensajeBienvenida = "Bienvenido al programa";
            string prohibicionIngreso = "Disculpe,sos menor y no puedes ingresar";


            //Preguntar la edad del usuario

            Console.WriteLine("Que edad tiene?");
            edad = Convert.ToInt32(Console.ReadLine());


            //determinar si es mayor a 18 años

            if (edad >= 18)
            {
                //preguntar nombre
                Console.WriteLine("Cual es su nombre?");
                nombre = Console.ReadLine();
                //preguntar apellido
                Console.WriteLine("Cual es su apellido?");
                apellido = Console.ReadLine();
                //Mensaje de bienvenida
                Console.WriteLine($"Sos {nombre} {apellido} ,{mensajeBienvenida}");
            }
            //determinar si es menor de 18

            else
            {
                //mostrar mensaje de prohibicion de ingreso
                diferencia = 18 - edad;
                Console.WriteLine($"{prohibicionIngreso}.Te faltan {diferencia} años ");
            }

            Console.ReadLine();
            //preguntar nombre

            //preguntar apellido

            //determinar si es menor a 18 años

            //Mostrar que no se puede ingresar
        }
    }
}
