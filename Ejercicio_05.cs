using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convertir de metro a pies o de pies a metros,segun  seleccione el usuario

            // variable
            double metros = 0;
            double pies = 0;
            int opcion = 0;

            //Opcion
            Console.WriteLine("1.de metros a pies , 2.de pies a metros");
            Console.WriteLine("Seleccione una opcion");
            opcion = Convert.ToInt32(Console.ReadLine());


            //Determinar si es de metros a pies
            if(opcion == 1)
            {
                //pedir la cantidad de metros
                Console.WriteLine("Cuantos metros son?");
                metros = Convert.ToDouble(Console.ReadLine());

                //Calcular la conversion
                pies = metros * 3.28;
                //mostrar el resultado
                Console.WriteLine($"{metros} metros son {pies} pies");
            
            //determinar si es de pies a metros
            }

            if(opcion == 2)
            {
                //pedir la cantidad de pies
                Console.WriteLine("Cuantos pies son?");
                pies = Convert.ToDouble(Console.ReadLine());
                //Calcular
                metros = pies / 3.28;
                //Mostrar el resultado
                Console.WriteLine($"{pies} pies son {metros} metros");
            }

            Console.ReadLine();           
           
        }
    }
}
