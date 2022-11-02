using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int op;
            do
            {
                op = Menu();
            } while (op != 11);
            Console.WriteLine("");
            Console.WriteLine("Adios");
            Pausa();
        }

        private static int Menu()
        {
            int op = 0;
            Console.WriteLine("---------Menu-----------");
            Console.WriteLine("1. Ciclo1");
            Console.WriteLine("2. Ciclo2");
            Console.WriteLine("3. Ciclo3");
            Console.WriteLine("4. Ciclo4");
            Console.WriteLine("5. Ciclo5");
            Console.WriteLine("6. Ciclo6");
            Console.WriteLine("7. Ciclo7");
            Console.WriteLine("8. Ciclo8");
            Console.WriteLine("9. Ciclo9");
            Console.WriteLine("10. Ciclo10");
            Console.WriteLine("11.Salir");
            Console.WriteLine("Seleccione una opcion...");
            if (int.TryParse(Console.ReadLine(), out op))
            {
                if (op>0 && op<12)
                {
                    switch (op)
                    {
                        case 1:
                            Ciclo1();
                            break;
                        case 2:
                            Ciclo2();
                            break;
                        case 3:
                            Ciclo3();
                            break;
                        case 4:
                            Ciclo4();
                            break;
                        case 5:
                            Ciclo5();
                            break;
                        case 6:
                            Ciclo6();
                            break;
                        case 7:
                            Ciclo7();
                            break;
                        case 8:
                            Ciclo8();
                            break;
                        case 9:
                            Ciclo9();
                            break;
                        case 10:
                            Ciclo10();
                            break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("elija una opcion del 1 - 11");
                }
                
            }
            else
            {
                Console.WriteLine("Solo puede escribir numeros");
            }
            return op;
            
        }

        private static void Ciclo10()
        {
            Console.WriteLine("Escriba las filas de la matriz");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba las columnas de la matriz");
            int columnas = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[,] numeros = new int[filas, columnas];
            Random rnd = new Random();
            for (int i = 0; i < filas; i++)
			{
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("{0} ",numeros[i, j] = rnd.Next(1, 56));
                }
                Console.Write("\n");
			}            

        }

        private static void Ciclo9()
        {
            Console.WriteLine("Multiplos del numero 5");
            int numero = 5 ;
            int[] multiplos = new int [12];
            for (int i = 0; i < multiplos.Length; i++)
            {
                Console.WriteLine(multiplos[i] = numero);
                numero += 5;
            }
        }

        private static void Ciclo8()
        {
            Console.WriteLine("TABLAS DE MULTIPLICAR");
            Console.WriteLine("");
            for (int i = 2; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}",i,j,i*j);
                }
                Console.WriteLine("");
            }
        }

        private static void Ciclo7()
        {
            Random rnd = new Random();          
            for (int i = 0; i < 20; i++)
            {
                int numero = rnd.Next(10, 60);
                Console.WriteLine(numero);
            }           
        }

        private static void Ciclo6()
        {
            int contador = 0;
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra.Substring(i,1) == "a")
                {
                    contador++;
                }
            }
            Console.WriteLine("La palabra {0} tiene {1} letras a",palabra,contador);
        }

        private static void Ciclo5()
        {
            Console.WriteLine("Palabra portafolio en orden inverso");
            string palabra = "portafolio";
            Console.WriteLine("");
            for (int i = palabra.Length-1; i >= 0; i--)
            {
                Console.WriteLine(palabra.Substring(i,1));
            }
            
        }

        private static void Ciclo4()
        {
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            Console.WriteLine("");
            for (int i = 0; i < palabra.Length; i++)
            {
                Console.WriteLine(palabra.Substring(i,1));
            }
        }

        private static void Ciclo3()
        {
            Console.WriteLine("Palabra correspondencia:");
            string palabra = "correspondencia";
            for (int i = 0; i < palabra.Length; i++)
            {
                Console.WriteLine(palabra.Substring(i, 1)); 
            }
        }

        private static void Ciclo2()
        {            
            int numero = 0;
            bool correcto = true;
            do
            {
                Console.WriteLine("Ingrese un numero");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", numero, i, numero * i);
                    }
                    correcto = false;
                }
                else
                {
                    Console.WriteLine("Escriba un numero");
                }
            } while (correcto);
            
            

        }

        private static void Ciclo1()
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("4 * {0} = {1}",i,4*i);
            }
        }

        private static void Pausa()
        {
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
