using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un prpgrama que muestra un contador y un acumulador
            int n = 0;
            int contador = 0;
            int acumulador = 0;
            int valor = 0;

            //Ejemplo de contador
            for(n = 0;n<10;n = n + 1)
            {
                Console.WriteLine("En el ciclo");
                contador = contador + 1; // en cada vuekta del ciclo se incrementa con uno 

            } // aca me va a mostrar cual es el numero del contador(el numero de repeticiones)
            Console.WriteLine($"El contador tiene {contador}");

            //Ejemplod de acumulador
            //El operador ++ acondiciona uno a la variable
            // n = n + 1 es igual a n++
            for (n = 0; n < 5; n++)
            {
                Console.WriteLine("Dame un numero");
                valor = Convert.ToInt32(Console.ReadLine());
                acumulador = acumulador + valor; //Me va a dar la suma de los 5 numeros que el usuario le da(acumulado)
            }
            Console.WriteLine($"El acumulador es {acumulador}");  //Mostrar el valor acumulado
            Console.ReadLine();
        }
       
    }
}
