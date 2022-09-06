using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    class Program
    {                                  //Crear y usar arreglos de estructuras
        public struct empleado
        {
            public string nombre;
            public int edad;
            public int id;
            public double sueldo;

            public override string ToString()
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendFormat($"Empleado: {id} , nombre: {nombre}  \r\nEdad: {edad} , sueldo: {sueldo}");
                return cadena.ToString();
            }
        }
        static void Main(string[] args)
        {
            //Variables
            int n = 0;
            empleado[] gente = new empleado[3];
            //creo un arreglo de tipo empleado;fijate que es igual que al crear un arreglo de tipo double o int,..etc
            string dato = "";

            //Pedir la informacion
            for (n = 0; n < 3; n++)//creo ciclo para poder guardar los valores en las celdas correctas del arreglo
            {
                Console.WriteLine("Dame el id");
                dato = Console.ReadLine();
                gente[n].id = Convert.ToInt32(dato);//guardo el valor en el arreglo en la celda correspondiente
                // .id porque es una estructura no un arreglo normal
                Console.WriteLine("Dame el nombre");
                gente[n].nombre = Console.ReadLine();


                Console.WriteLine("Dame la edad");
                dato = Console.ReadLine();
                gente[n].edad = Convert.ToInt32(dato);

                Console.WriteLine("Dame el sueldo");
                dato = Console.ReadLine();
                gente[n].sueldo = Convert.ToDouble(dato);

            }
            //Mostramos la informacion
            for (n = 0; n < 3; n++)
            {
                Console.WriteLine(gente[n]);
                Console.WriteLine("...............");

            }
            for (n = 0; n < 3; n++)
            {
                if (gente[n].sueldo < 15000)
                    Console.WriteLine($"Aumento para: {gente[n].nombre}");

                // Console.ReadLine();

            }
            Console.ReadLine();
        }
    }
}
