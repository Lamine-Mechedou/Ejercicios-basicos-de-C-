using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {

            // Crear un programa que calcula el costo de construir una casa
            // El programa pedira la cantidad de habitaciones y las dimensiones de cada una
            // El costo por m2 de habitacion es $300 con impuesto de 5%
            // El costo por m2 de la cocina y sanitario es de $375 con impuesto de 12%
            // El costo por m2 de jardin es de $120 con impuesto del 0%

            //Datos
            int n = 0;
            int numHab = 0;
            int tipo = 0; //1.Habitacion , 2.Cocina , 3.Jardin
            double granTotal = 0.0;
            string dato = "";

            double area = 0.0;
            double costoHab = 0.0;

            //Pedir numero de habitaciones
            Console.WriteLine("Cuantos elementos hay en tu casa ?");
            dato = Console.ReadLine();
            numHab = Convert.ToInt32(dato);

            for (n = 0; n < numHab; n++)
            {
                //Calcular area
                area = CalcularArea();

                //Pedir tipo de habitacion
                Console.WriteLine("Que tipo es? 1.Habitacion , 2.Cocina , 3.Jardin");
                dato = Console.ReadLine();
                tipo = Convert.ToInt32(dato);

                //Calcular costo
                if (tipo == 1)
                costoHab = CalcularCosto(area, 300.0, 0.05);

                if (tipo == 2)
                    costoHab = CalcularCosto(area, 375.0, 0.12);

                if (tipo == 3)
                    costoHab = CalcularCosto(area, 120.0, 0.0);

                // Sumar el gran total
                granTotal += costoHab;

               
            }
           
            //Presentar resultado
            Console.WriteLine("el costo tota es de {0}", granTotal);
            Console.ReadLine();//Si no pones ReadLine aqui no va a mostrar el resultado,ReadLine siempre va al cerrar la llave del metodo main

        }
        //Metdodo para calcular areas
        public static double CalcularArea()
        {
            double area = 0.0;
            double ancho = 0.0;
            double largo = 0.0;
            string dato = "";

            Console.WriteLine("Dame el ancho de la habitacion");
            dato = Console.ReadLine();
            ancho = Convert.ToDouble(dato);

            Console.WriteLine("Dame el largo de la habitacion");
            dato = Console.ReadLine();
            largo = Convert.ToDouble(dato);

            area = ancho * largo;

            return area;
        }
        //Metodo para calcular el costo
        public static double CalcularCosto(double area, double pM2, double impuesto)
        {
            double costo = 0.0;
            double imp = 0.0;
            double total = 0.0;

            costo = area * pM2;
            imp = costo * impuesto;
            total = costo + imp;

            return total;
            
        }

    }

}
