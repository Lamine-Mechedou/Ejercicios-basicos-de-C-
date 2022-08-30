using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que convierte el peso en la Tirra al peso en Mercurio,Venus o Marte

            //Variable

            double pesoTierra = 0.0;
            double pesoPlaneta = 0.0;
            
            int opcion = 0;

            //Pedir el planeta
            Console.WriteLine("1.Mercurio , 2.Venus , 3.Marte");
            Console.WriteLine("seleccione un planeta");
            opcion = Convert.ToInt32(Console.ReadLine());

            //pedir el peso en la tierra

            Console.WriteLine("Cual es la cantidad de pesos en la tierra?");           
            pesoTierra = Convert.ToDouble(Console.ReadLine());

            //determinar si es Mercurio
            switch (opcion)
            {
                case 1://determinar si es Mercurio
                    pesoPlaneta = pesoTierra * 0.38; // hacer el calculo
                    break;
                case 2://determinar si es Venus
                    pesoPlaneta = pesoTierra * 2.33; //hacer el calculo
                    break;
                case 3://determinar si es Marte
                    pesoPlaneta = pesoTierra * 1.5; // hacer el calculo
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            } 
            //Mostrar la conversion
            Console.WriteLine($"{pesoTierra} en este planeta  son {pesoPlaneta} ");
            Console.ReadLine();

         


        }
    }
}
