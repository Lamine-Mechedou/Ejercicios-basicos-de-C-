using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este programa muestra los primos del 1 al 100
            //Un numero primo es aquel que puede dividirse entre si mismo y la unidad unicamente
            //ejemplo 12 no es primo porque se puede dividir por 3 entre 4 y 12
            //pero 7 es un numero primo porque solamente lo puedo dividir entre el 1 y si mismo "7"

            // Variables
            int n = 0;
            int m = 0;
            bool primo = true;//Me sirve para saber si ha encontrado un numero primo o no

            for(n = 2; n<100; n++)
            {
                primo = true;
                for (m = 2; m < n; m++)
                {
                    if (n % m == 0) // si se divide entre otro numero y el resto es 0 entonces no es primo,sino primo es true y lo imprime
                        primo = false;
                }   
                    if(primo == true)                    
                    Console.WriteLine($"{n}");
                    

                }
            
            Console.ReadLine();
        }
        }
    }

