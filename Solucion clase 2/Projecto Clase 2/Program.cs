using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projecto_Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1- Parsing");
                Console.WriteLine("2- Ciclo For");
                Console.WriteLine("3- Ciclo while");
                Console.WriteLine("4- Ciclo Do/While");
                Console.WriteLine("5- Bifurcar (if/switch)");
                Console.WriteLine("6- Numero Primos");
                Console.WriteLine("7- Palindromos");
                Console.WriteLine("8- Salir");
                Console.WriteLine("Seleccione");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Parsing();
                        break;
                    case 2:
                        CicloFor();
                        break;
                    case 3:
                        CicloWhile();
                        break;

                    case 4:
                        CicloDoWhile();
                        break;
                    default:
                        break;
                }
            }
            while (num < 8);


        }

        private static void CicloDoWhile()
        {
            string continuar;
            do
            {
                int vocal = 0; int cons = 0;
                Console.WriteLine("Ingrese palabra: ");
                string texto = Console.ReadLine();
                for (int i = 0; i < texto.Length; i++)
                {
                    string caracter = texto.Substring(i, 1);
                    if (caracter.Equals("a") || caracter.Equals("e") || caracter.Equals("i") || caracter.Equals("o") || caracter.Equals("u"))
                    {
                        vocal++;
                    }
                    else
                    {
                        cons++;
                    }

                }
                Console.WriteLine("vocales {0} consonantes {1}", vocal, cons);
                Console.WriteLine("Desea continuar s/n");
                continuar = Console.ReadLine();
            } while (continuar == "s");

        }

        private static void CicloWhile()
        {
            int puntaje = 1000;
            string seguir = "s";
            while (puntaje > 0 && seguir.Equals("s"))
            {
                Random rmd = new Random();
                int numero = rmd.Next(2);
                Console.WriteLine("Cara (1) o Sello (2)");
                int respuesta = int.Parse(Console.ReadLine());
                if (numero == respuesta)
                {
                    puntaje += 150;
                    Console.WriteLine("Gano Suertody {0}", puntaje);
                }
                else
                {
                    puntaje -= 200;
                    Console.WriteLine("Perdio Lotody {0}", puntaje);
                }
                Console.WriteLine("Desea seguir jugando (s/n)");
                seguir = Console.ReadLine();

            }
        }

        private static void CicloFor()
        {
            Console.WriteLine("ingrese numero de veces");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine("Hola Mundo {0}", i);
            }
            Console.ReadKey();
        }

        private static void Parsing()
        {
            Console.WriteLine("Ingrese un dato");
            string valor = Console.ReadLine();
            //int
            int salida_numero;
            if (int.TryParse(valor, out salida_numero))
            {
                Console.WriteLine("Pudo convertir en entero");
            }
            else
            {
                Console.WriteLine("No se puede convertir en entero");
            }

            bool salida_numero1;
            if (bool.TryParse(valor, out salida_numero1))
            {
                Console.WriteLine("Pudo convertir en booleano");
            }
            else
            {
                Console.WriteLine("No se puede convertir en booleano");
            }

            DateTime salida_numero2;
            if (DateTime.TryParse(valor, out salida_numero2))
            {
                Console.WriteLine("Pudo convertir en fecha");
            }
            else
            {
                Console.WriteLine("No se puede convertir en fecha");
            }
            Console.ReadKey();
        }
    }
}
