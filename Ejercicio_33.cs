using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular el promedio de 5 numeros
            //Usamos metodos(funciones)
            //Reutilizacion de codigo
            //Esoecializacion:en llevar algo en particular
            //Mas facil mantenimiento y depuracion

            //Variables:
            double num1 = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            double num5 = 0.0;
            double promedio = 0.0;

            //Pedir numero 1
            num1 = Pedir(1);
            //Pedir numero 2
            num2 = Pedir(2);
            //Pedir numero 3
            num3 = Pedir(3);
            //Pedir numero 4
            num4 = Pedir(4);
            //Pedir numero 5
            num5 = Pedir(5);
            //Calcular promedio
            promedio = (num1 + num2 + num3 + num4 + num5) / 5;
            //Mostrar el promedio
            Console.WriteLine($"El promedio de los 5 numerios es: {promedio}");
            Console.ReadLine();//siempre en main method
        }
        public static double Pedir(int n) //Esto en el metodo pedir que hace las peticiones de numeros y los guarda
             //public:es el acceso
             //static:Un metodo
            // double es el tipo de retorno(que va a regresar el metodo)
            //Pedir:El nombre del metodo:a traves de el llevamos a cabo la invocacion.empieza con mayuscula y describe su funcion(verbo)
            //(int n):despues del nombre del metodo viene la seccion de parametros(metodos pueden o no tener parametros):para enviar informacion al metodo
        { 
            double numero = 0.0;
            string dato = "";
            Console.WriteLine($"-> Dame el numero{n}");
            dato = Console.ReadLine();
            numero = Convert.ToDouble(dato);

            return numero; // me devuelve el numero que pidio al metodo main 
        }
       

    }
    
    }

