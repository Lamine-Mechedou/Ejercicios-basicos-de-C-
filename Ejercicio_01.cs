using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            // calcular el area y el perimetro de un rectangulo

            int ladoLargo ;
            int ladoAncho;
            int area;
            int perimetro;

            Console.WriteLine("Ingrese el lado largo del rectangulo");
            ladoLargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el lado ancho del rectangulo");
            ladoAncho = Convert.ToInt32(Console.ReadLine());

           
            perimetro = (ladoLargo + ladoAncho) * 2;
           
            area = ladoAncho * ladoLargo;
            Console.WriteLine("El lado {0} y {1}", ladoLargo,ladoAncho);
            Console.WriteLine("Tiene un perimetro de {0} y un area de {1}", perimetro, area);

         

            Console.ReadLine();


        }
    }
}
