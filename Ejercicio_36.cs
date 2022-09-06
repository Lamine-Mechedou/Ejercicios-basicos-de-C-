using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class Program
    {
        public struct empleado // Aca es donde creo la estructura(tipo de dato empleado)-->afuera de main
        { //aca van los datos de la estructura
            public string nombre;
            public int edad;
            public int id;
            public double sueldo;
        }
        static void Main(string[] args)
        {
            //Ahora en main creo variable de tipo empleado
            empleado uno;

            //Asignacion de valores
            uno.nombre = "Juan";
            uno.edad = 28;
            uno.id = 567;
            uno.sueldo = 10500.00;

            //Impresion de valores
            Console.WriteLine(uno.nombre);
            Console.WriteLine(uno.edad);
            Console.WriteLine(uno.id);
            Console.WriteLine(uno.sueldo);
            Console.ReadLine();
        }
       
    }
}
