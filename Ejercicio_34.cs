using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que realiza operaciones aritmeticas usando metodos
            
            //Tenemos 4 tipos de metodos:
            //1-Metodos que solo ejecutan codigo:void es para metodos que 
            //no regresan ningun tipo de valor ni reciben del exterior ningun valor(solo ejecutan)

            //2-Metodo que recibe valores por medio de sus parametros.

            //3-Metodos que regreesan un valor:calcula algun valor internamente y lo regresa al invocarlo externamente para que podamos trabajar

            //4-Metodos que reciben parametros y regresan valor



            // Variables
            string dato = "";
            int opcion = 0;
            double a = 0.0;
            double b = 0.0;
            double r = 0.0;

            // Presentamos menu
            do
            {
                Console.WriteLine("1.Suma , 2.Resta , 3.Multiplicacion , 4.Division , 5.Salir");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                if (opcion == 1) // invoco el primer metodo
                    Suma();
                if (opcion == 2) // Asigno los dos valores para el metodo dos 
                {
                  Console.WriteLine("Ingrese el valor x");                 
                  dato = Console.ReadLine();
                  a = Convert.ToDouble(dato);

                   Console.WriteLine("Ingrese el valor y");
                   dato = Console.ReadLine();
                   b = Convert.ToDouble(dato);
                    Resta(a, b);//Invoco el segundo metodo despues de haberle asignado los valores
                }

                if(opcion == 3)
                {
                    r = Multi(); // invocacion del tercer metodo;asi se hace siempre asignando a una variable el metodo para invocarlo correctamente
                    Console.WriteLine($"El resultado de la multiplicacion es: {r}");
                }

                if(opcion == 4)
                {
                    Console.WriteLine("Dame el primer valor");
                    dato = Console.ReadLine();
                    a = Convert.ToDouble(dato);

                    Console.WriteLine("Dame el segundo valor");
                    dato = Console.ReadLine();
                    b = Convert.ToDouble(dato);

                    r = Div(a, b); //invoco el metodo Div colocando los dos parametros con el mismo tipo de dato
                    Console.WriteLine($"El resultado de la division es: {r}");
                }


            } while (opcion != 5);//El ciclo do se va a repetir hasta que seleccione 5
        }
        //1- Metodo que sola ejecuta codigo
        public static void Suma() //El metodo siempre tiene que ser afuera de main(n0 puedo crear un metodo dentro de un metodo,pero debe estar adentro de la misma clase aca es class Program)
                // void es para metodos que no regresan ningun tipo de valor ni reciben del exterior ningun valor(solo ejecutan todo adentro del metodo)
                // este tipo de metodos no tiene parametros ()
        {
            double x = 0;
            double y = 0;
            double resul = 0;
            string valor = "";

            Console.WriteLine("Dame el primer valor");
            valor = Console.ReadLine();
            x = Convert.ToDouble(valor);

            Console.WriteLine("Dame el segundo valor");
            valor = Console.ReadLine();
            y = Convert.ToDouble(valor);

            resul = x + y;

            Console.WriteLine($"El resultado de la suma es: {resul}");
            Console.ReadLine();

        }
        //2- Metodo que recibe valores
        public static void Resta(double x, double y)
            // este metodo es void(no regresa nada)
            // estos dos parametros son los dos que necesita recibir el metodo para poder trabajar
            //aca es responsabilidad de main de obtener los dos valores x , y 
        {
            double resul = 0;
            resul = x - y;

            Console.WriteLine($"El resultado de la resta es: {resul}");//WriteLine es un metodo void(recibe parametros) de la clase Console
        }

        //3-Metdodo que regresa valores
        public static double Multi()
            // aca el tipo de valor que va a regresar es double,void es cuando no regresa nada
            //como es un metodo que regresa un valor no necesita de parametros
        {
            double x = 0;
            double y = 0;
            double resul = 0;
       

            Console.WriteLine("Dame el primer valor");            
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame el segundo valor");      
            y = Convert.ToDouble(Console.ReadLine());

            resul = x * y;
            return resul; // return sirve para regresar un valor al exterior,el valor de retorno tiene que ser en este caso double
       //Readline es un metodo que regresa un valor del tipo string
        }
        //4-Metodos que reciben parametros y regresan valor
        public static double Div(double x, double y)
        {
            double resul = 0;
            resul = x / y;
            return resul;
        }
    }
}
