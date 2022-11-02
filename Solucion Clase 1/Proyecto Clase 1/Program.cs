using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            
            do
            {
                
            
            Console.WriteLine("Ingrese 2 numeros");
            int numero1;
            int numero2;
            Console.WriteLine("Ingrese numero 1");
            if (int.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("gracias por ingresar un numero");
            }
            else
            {
                Console.WriteLine("ingreso MAL el numero 1");
            }
            Console.WriteLine("Ingrese numero 2");
            if (int.TryParse(Console.ReadLine(), out numero2))  //si puede convertir a entero guardelo en el numero 2
            {
                Console.WriteLine("gracias por ingresar un numero");
            }
            else
            {
                Console.WriteLine("ingreso MAL el numero 2");
            }
                Cl_Operacionescs operacion = new Cl_Operacionescs();

            Console.WriteLine("la suma es {0}",operacion.Sumar(numero1,numero2));
            
            Console.WriteLine("Desea Continuar? S/N");

            //respuesta = char.Parse(Console.ReadLine().ToUpper());
            if (char.TryParse(Console.ReadLine().ToUpper(), out respuesta))
            {
            }
            else
            {
                Console.WriteLine("ingreso mal respuesta");
                respuesta = 'S';
            }
            } while (respuesta=='S');
            Console.WriteLine("chaooqrvtfg");
            Console.ReadKey();
        }
    }
}
