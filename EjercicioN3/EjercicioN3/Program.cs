using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioN3
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                op = Menu();
            } while (op != 11);
            Pausa();
        }

        private static void Pausa()
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese una palabra para continuar...");
            Console.ReadKey();
        }

        private static int Menu()
        {
            int resp = 0;
            Console.WriteLine("---------------MENU------------");
            Console.WriteLine("1. Vector1");
            Console.WriteLine("2. Vector2");
            Console.WriteLine("3. Vector3");
            Console.WriteLine("4. Vector4");
            Console.WriteLine("5. Vector5");
            Console.WriteLine("6. Vector6");
            Console.WriteLine("7. Vector7");
            Console.WriteLine("8. Vector8");
            Console.WriteLine("9. Vector9");
            Console.WriteLine("10. Vector10");
            Console.WriteLine("11. Salir");
            if (int.TryParse(Console.ReadLine(), out resp))
            {
                if (resp < 12 && resp > 0)
                {
                    switch (resp)
                    {
                        case 1:
                            Vector1();
                            break;
                        case 2:
                            Vector2();
                            break;
                        case 3:
                            Vector3();
                            break;
                        case 4:
                            Vector4();
                            break;
                        case 5:
                            Vector5();
                            break;
                        case 6:
                            Vector6();
                            break;
                        case 7:
                            Vector7();
                            break;
                        case 8:
                            Vector8();
                            break;
                        case 9:
                            Vector9();
                            break;
                        case 10:
                            Vector10();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("La opcion debe ser menor a 11");
                }

            }
            else
            {
                Console.WriteLine("Solo se pueden escribir numeros");
            }
            return resp;
        }

        private static void Vector10()
        {
            string[,] palindromos = new string[3, 3];
            int contador1 = 0;
            int contador2 = 0;
            string palabra;
            do
            {
                string mitad1 = "";
                string mitad2 = "";                                                                    
                do
                {
                    
                    Console.WriteLine("Ingrese una palabra");
                    palabra = Console.ReadLine();
                    for (int i = 0; i < palabra.Length / 2; i++)
                    {
                        mitad1 += palabra[i];
                    }
                    for (int i = palabra.Length - 1; i > palabra.Length / 2; i--)
                    {
                        mitad2 += palabra[i];
                    }
                    if (mitad1!=mitad2)
                    {
                        Console.WriteLine("No es Palindromo");
                    }
                } while (mitad1 != mitad2);
                palindromos[contador1, contador2] = palabra;
                contador2++;
                if (contador2 == 2)
                {
                    contador1++;
                    contador2 = 0;
                }

            } while (contador1 < 2 && contador2 < 2);
            Console.WriteLine("arreglo lleno");

            Pausa();
        }

        private static void Vector9()
        {
            char[] arreglo;
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            if (palabra.Length >= 5)
            {
                arreglo = palabra.ToCharArray(0, palabra.Length);
                foreach (char i in arreglo)
                {
                    Console.WriteLine(i);
                }

            }
            else
            {
                Console.WriteLine("La palabra debe contener al menos 5 caracteres");
            }
            Pausa();
        }

        private static void Vector8()
        {
            string[,] horario = new string[7, 1];
            Console.WriteLine("Ingrese el horario");
            horario[0, 0] = "Lunes"; horario[0, 1] = "Base de Datos";
            horario[1, 0] = "Martes"; horario[1, 1] = "POO .NET";
            horario[2, 0] = "Miercoles"; horario[2, 1] = "Aplicaciones de Internet";
            horario[3, 0] = "Jueves"; horario[3, 1] = "Ingenieria en Software";
            horario[4, 0] = "Viernes";

            Pausa();

        }

        private static void Vector7()
        {
            int[] numeros = new int[20];
            Random rnd = new Random();
            Console.WriteLine("Ingrese un numero");
            int resp = 0;
            int contMayores = 0;
            int contMenores = 0;
            if (int.TryParse(Console.ReadLine(), out resp))
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    int numRnd = rnd.Next(1, 100);
                    numeros[i] = numRnd;
                    if (resp > numeros[i])
                    {
                        contMenores++;
                    }
                    else
                    {
                        contMayores++;
                    }
                }
                Console.WriteLine("");
                foreach (int i in numeros)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("");
                Console.WriteLine("La cantidad de numeros mayores a {0} son: {1}", resp, contMayores);
                Console.WriteLine("La cantidad de numeros menores a {0} son: {1}", resp, contMenores);
                Pausa();
            }

        }

        private static void Vector6()
        {
            Random rnd = new Random();

            int[] arreglo = new int[15];
            for (int i = 0; i < arreglo.Length; i++)
            {
                int numRnd = rnd.Next(70, 90);
                Console.WriteLine(arreglo[i] = numRnd);
            }
            Array.Sort(arreglo);
            Console.WriteLine("");
            Console.WriteLine("Arreglo ordenado");
            Console.WriteLine("");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }

        private static void Vector5()
        {
            int[] arreglo = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < arreglo.Length; i++)
            {
                int numRnd = rnd.Next(0, 1000);
                Console.WriteLine(numRnd);
            }


        }

        private static void Vector4()
        {
            int contador = 0;
            int[] numPares = new int[100];
            for (int i = 2; i <= 200; i += 2)
            {
                numPares[contador] = i;
                Console.WriteLine(numPares[contador]);
                contador++;

            }

        }

        private static void Vector3()
        {

            Random rnd = new Random();
            Console.WriteLine("Escriba el tamaño del vector");
            int tamaño = int.Parse(Console.ReadLine());
            int[] arreglo = new int[tamaño];
            for (int i = 0; i < arreglo.Length; i++)
            {
                int numRnd = rnd.Next(1, 100);
                arreglo[i] = numRnd;
                Console.WriteLine(arreglo[i]);
            }
            Pausa();
        }

        private static void Vector2()
        {
            Console.WriteLine("Ingrese numero del mes para ver los dias que tiene");
            int numero = int.Parse(Console.ReadLine());
            int[] mesDias = new int[13];
            mesDias[0] = 31;
            mesDias[1] = 29;
            mesDias[2] = 31;
            mesDias[3] = 30;
            mesDias[4] = 31;
            mesDias[5] = 30;
            mesDias[6] = 31;
            mesDias[7] = 31;
            mesDias[8] = 30;
            mesDias[9] = 31;
            mesDias[10] = 30;
            mesDias[11] = 31;
            for (int i = 0; i < mesDias.Length; i++)
            {
                if (numero - 1 == i)
                {
                    Console.WriteLine("El mes {0} tiene {1} dias", numero, mesDias[i]);
                }

            }
            Pausa();
        }

        private static void Vector1()
        {
            string[] diaSemana = new string[7];
            diaSemana[0] = "Lunes";
            diaSemana[1] = "Martes";
            diaSemana[2] = "Miercoles";
            diaSemana[3] = "Jueves";
            diaSemana[4] = "Viernes";
            diaSemana[5] = "Sabado";
            diaSemana[6] = "Domingo";
            for (int i = 0; i < diaSemana.Length; i++)
            {
                Console.WriteLine(diaSemana[i]);
            }
            Pausa();
        }

    }
}
