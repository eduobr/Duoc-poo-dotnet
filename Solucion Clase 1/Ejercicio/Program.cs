using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1-Sumar");
                Console.WriteLine("2-Restar");
                Console.WriteLine("3-Multiplicar");
                Console.WriteLine("4-Divide");
                Console.WriteLine("5-Salir");
                Console.WriteLine("Seleccione alternativa:");
                respuesta = int.Parse(Console.ReadLine());
                int num1;
                int num2;
                double numero1;
                double numero2;
                Cl_Operacionescs operacion = new Cl_Operacionescs();
                switch (respuesta)
                {
                    case 1:
                        Console.WriteLine("Ingrese el numero 1");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el numero 2");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma de los numeros es {0}", operacion.Sumar(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el numero 1");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el numero 2");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La resta de los numeros es {0}", operacion.Restar(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el numero 1");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el numero 2");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de los numeros es {0}", operacion.Multiplicar(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el numero 1");
                        numero1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el numero 2");
                        numero2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("La division de los numeros es {0}", operacion.Dividir(numero1, numero2));
                        break;
                    default:
                        Console.WriteLine("La opcion no es correcta ");
                        break;
                }

            } while (respuesta != 5);
        }
    }
}
