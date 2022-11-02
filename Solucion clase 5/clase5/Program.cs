using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase5
{
    class Program
    {
        static string Frase;
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                op = Menu();
            } while (op!=6);
            Console.WriteLine("Adios");
            Pausa();
        }

        private static int Menu() {
            Console.WriteLine("Menu principal");
            Console.WriteLine(new string ('*',20));
            Console.WriteLine("1.- Ingrese Frase");
            Console.WriteLine("2.- Invertir frase");
            Console.WriteLine("3.- Presentar por palarbras");
            Console.WriteLine("4.- Cambiar caracter");
            Console.WriteLine("5.- Mayusculas y minusculas intercaladas");
            Console.WriteLine("6.- Salir");
            Console.WriteLine("Seleccione:");

            int op = 0;
            if (int.TryParse(Console.ReadLine(), out op))
            {
                if (op >= 1 && op <= 6)
                {
                    switch (op)
                    {
                        case 1:
                            IngreseFrase();
                            break;
                        case 2:
                            InvertirFrase();
                            break;
                        case 3:
                            PresentarPorPalabras();
                            break;
                        case 4:
                            CambiarCaracter();
                            break;
                        case 5:
                            MayusculasyMinusculas();
                            break;
                        default:
                            break;
                    }
                }
                else {
                    Console.WriteLine("Seleccione entre 1 y 6");
                }

            }
            else
            {
                Console.WriteLine("Ingrese un numero");
            }
            return op;
        }

        private static void MayusculasyMinusculas()
        {
            try
            {
                string[] arreglo = Frase.Split(' ');
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("{0} ", arreglo[i].ToUpper());
                    }
                    else
                    {
                        Console.Write("{0} ", arreglo[i].ToLower());
                    }

                }
                Pausa();
            }
            catch (Exception)
            {

                Console.WriteLine("Ingrese Primero una frase");
            }
            
        }

        private static void CambiarCaracter()
        {
            try
            {
                Console.WriteLine("Ingrese Caracter a Buscar");
                string caracter = Console.ReadLine().Trim();
                Console.WriteLine("Ingrese caracter a cambiar:");
                string nuevo = Console.ReadLine().Trim();
                Frase = Frase.Replace(caracter, nuevo);
                Console.WriteLine(" OK ");
                Console.WriteLine("Nueva Frase: {0}", Frase);
            }
            catch (Exception)
            {

                Console.WriteLine("Ingrese Primero una frase");
            }
            
        }

        private static void PresentarPorPalabras()
        {
            try
            {
                string[] arreglo = Frase.Split(' ');
                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.WriteLine("{0} {1}", i + 1, arreglo[i]);
                }
                Pausa();
            }
            catch (Exception)
            {

                Console.WriteLine("Ingrese Primero una frase");
            }
           
        }

        private static void InvertirFrase()
        {
            try
            {
                string[] arreglo = Frase.Split(' ');
                int largo = arreglo.Length;
                for (int i = largo - 1; i >= 0; i--)
                {
                    Console.Write("{0} ", arreglo[i]);
                }
                Console.WriteLine(" \n ");
            }
            catch (Exception)
            {

                Console.WriteLine("Ingrese Primero una frase");
            }
        }

        private static void IngreseFrase()
        {
            try
            {
                Console.WriteLine("Ingrese Frase: ");
                string frase = Console.ReadLine().Trim();
                string[] palabras = frase.Split(' ');
                if (palabras.Length > 5)
                {
                    Console.WriteLine("Palabra bien ingresada {0}", palabras.Length);
                    Frase = frase;
                }
                else
                {
                    Console.WriteLine("la frase solo tiene {0} palabras", palabras.Length);
                    Frase = string.Empty;
                }
                Pausa();
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
            }
            
        }

        private static void Pausa()
        {
            Console.WriteLine("Presione cualquier tecla para continuar....");
            Console.ReadKey();
        }
    }
}
