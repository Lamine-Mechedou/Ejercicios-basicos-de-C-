using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muestra un ciclo de ejemplos anidados
            // Crear un programa que muestra la tabla de multiplicacion
            // variables
            int n = 0;
            int m = 0;
            int producto = 0;

            //Imprime las tablas de multiplicar
            for(n = 1; n<= 10; n++)
            {
                for(m = 1; m<= 10; m++) //El ciclo interno se ejecuta mas rapido que el externo
                                        // o sea;empieza con el ciclo externo de n = 1 despues
                                        //el ciclo m = 1;ejecuta n*m = producto,y va a seguir haciendo repiticiones 
                                        //en el ciclo m(interno) y cuando se acaba,vuelve al ciclo n
                                        // y ahora n = a 2,...etc
                {
                    producto = n * m;
                    Console.WriteLine($"{n} x {m} = {producto}");
                    // Console.ReadLine(); aca va a imprimir una sola operacion a cada click de enter
                }
                Console.WriteLine(""); // para que deje un especio entre cada ciclo m;o sea grupo de multiplicacion
                // Console.ReadLine();aca va a imprimir todo el ciclo interno m

            }
            Console.ReadLine();//aca imprime todo el ciclo n

        }
    }
}
