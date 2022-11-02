using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Clase_3
{
    class Program
    {
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

        private static int Menu()
        {
            Console.WriteLine("Menu Prinicpal");
            Console.WriteLine("1.- Palindromos");
            Console.WriteLine("2.- Digito Verificador del Rut");
            Console.WriteLine("3.- Arreglo Unidimensional");
            Console.WriteLine("4.- Arreglo Bidimensional");
            Console.WriteLine("5.- Ahorcado");
            Console.WriteLine("6.- Salir");
            int opcion = 0;
            if (int.TryParse(Console.ReadLine(),out opcion))
            {
                if (opcion>=1 && opcion<=6)
                {
                    switch (opcion)
                    {
                        case 1:
                            Palindromo();
                            break;
                        case 2:
                            Dv();
                            break;
                        case 3:
                            Arreglo();
                            break;
                        case 4:
                            ArregloBidimensional();
                            break;
                        case 5:
                            ahorcado();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Numero fuera de rango (1 a 6)");
                    Pausa();
                }
            }
            else
            {
                Console.WriteLine("ingrese una opcion numerica");
                Pausa();
            }
            return opcion;
        }

        private static void ahorcado()
        {
            string[] palabras = new string[]{"UC","reprobado","muerto","win","cruzao" };
            Random rnd = new Random();
            int numero = rnd.Next(5);
            string palabra = palabras[numero];
            Console.WriteLine("Selecciono: {0}",palabra);
            int vidas = 3;
            do
            {
                Console.WriteLine("seleccione letra:");
                string letra = Console.ReadLine();
                int contador = 0;
                for (int i = 0; i < palabra.Length; i++)
                {
                    string cara = palabra.Substring(i, 1);
                    if (cara.Equals(letra))
                    {
                        contador++;
                    }
                }
                Console.WriteLine("Existen {0} letras {1}",contador,letra);
                if (contador==0)
                {
                    Console.WriteLine("no hay letras parecidas");
                    vidas--;
                }

            } while (vidas>=1);
            Pausa();

        }

        private static void ArregloBidimensional()
        {
            string[,] horario = new string[6, 5];
            horario[0, 0] = "lunes";
            horario[0, 1] = "Martes";
            horario[0, 2] = "Miercoles";
            horario[0, 3] = "Jueves";
            horario[0, 4] = "viernes";
            for (int c = 0; c <= 4; c++)
            {
                Console.WriteLine("Dia : {0}",horario[0, c]);
                for (int f = 1; f <= 5; f++)
                {
                    Console.WriteLine("Modulo: {0}",f);
                    horario[f, c] = Console.ReadLine();
                }
            }
            for (int f = 0; f <= 5 ; f++)
            {
                string lunes = horario[f, 0];
                string martes = horario[f, 1];
                string miercoles = horario[f, 2];
                string jueves = horario[f, 3];
                string viernes = horario[f, 4];

                Console.WriteLine(lunes+" "+martes+" "+miercoles+" "+jueves+" "+viernes);
            }
            Pausa();
        }

        private static void Arreglo()
        {
            Console.WriteLine("ingrese numero de elementos");
            int numero;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                string[] arreglo = new string[numero];
                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.WriteLine("ingrese dato {0}",i+1);
                    arreglo[i] = Console.ReadLine();
                }
                foreach (string item in arreglo)
                {
                    Console.WriteLine("Item :"+item);
                }
                Pausa();
            }
            else {
                Console.WriteLine("ingrese un numero");
                Pausa();
            }
        }

        private static void Dv() //digito verificador
        {
            Console.WriteLine("ingrese rut");
            string rut = Console.ReadLine();
            int multiplicador = 2;
            int acumulador = 0;
            for (int i = 0; i < 8; i++)
            {
                int numero =int.Parse( rut.Substring(7 - i, 1));
                Console.WriteLine("Numero {0} Mul {1}",numero,multiplicador);
                acumulador += (numero * multiplicador);
                multiplicador++;
                if (multiplicador==8)
                {
                    multiplicador = 2;
                }
            }
            int resto = acumulador % 11;
            int dv = 11 - resto;
            if (dv==11)
            {
                dv = 0;
            }
            if (dv == 10)
            {
                Console.WriteLine("Digito verficador k");
            }
            else {
                Console.WriteLine("Digito verficador {0}",dv);
            }
            Pausa();
        }

        private static void Palindromo()
        {
            Console.WriteLine("ingrese una palabra:");
            string texto = Console.ReadLine();
            int largo= texto.Length-1;
            bool sw = true;
            for (int i = 0; i < (texto.Length)/2; i++)
            {
                string c_i = texto.Substring(i, 1);
                string c_f = texto.Substring(largo - i, 1);
                Console.WriteLine("CaracterInicial {0}, CaracterFinal {1}",c_i,c_f);
                if (!c_i.Equals(c_f))
                {
                    sw = false;
                    break;
                }
            }
            if (sw)
            {
                Console.WriteLine("es palindromo");
            }
            else {
                Console.WriteLine("no es palindromo");
            }
            Pausa();
        }

        private static void Pausa()
        {
            Console.WriteLine("Presione cualquier tecla para continuar....");
            Console.ReadKey();
        }
    }
}
