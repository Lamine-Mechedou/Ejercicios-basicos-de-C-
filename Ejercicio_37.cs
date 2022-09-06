using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    class Program
    {
        public struct empleado // Crear la estructura
        {
            public string nombre;
            public int edad;
            public int id;
            public double sueldo;

            public override string ToString() // Esto nos va a servir para ahorra codigo e imprimir directamento lo que esta en el objeto que vamos a crear,aca es cadena
            {
                StringBuilder cadena = new StringBuilder();// La clase String Builder sirve para crear objetos

                cadena.AppendFormat($"Empleado: {id} , nombre: {nombre} \r\nEdad: {edad} , sueldo: {sueldo}");
                //todo lo que se escribe en el metodo AppendFormat se va a guardar en cadena,es como writeLine pero lo guarda en cadena
                return cadena.ToString();
            }
        }
        static void Main(string[] args)
        {
            //Creacion de una variable del tipo uno
            empleado uno;

            // Asignacion de valores
            uno.nombre = "Juan";
            uno.edad = 28;
            uno.id = 567;
            uno.sueldo = 10500.50;

            //impresion de valores
            Console.WriteLine(uno);//aca imprimo todos los valores del empleado uno sin necesidad del punto y el campo porque utilice override a ToString
            //o sea uno aca invoca a ToString en este caso es cadena;ahi me ahorro muchas lineas de codigo ya que me imprime lo que hay en cadena.AppendFormat

            //Ahora lo imprimimos de manera tradicional para ver la diferencia
            Console.WriteLine(".......................");
            Console.WriteLine(uno.edad);
            Console.ReadLine();
        }
    }
}
