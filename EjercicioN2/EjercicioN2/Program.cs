using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN2
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
            Console.WriteLine("");
            Console.WriteLine("Adios");
            Pausa();
        }

        private static void Pausa()
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese una tecla para continuar...");
            Console.WriteLine("");
            Console.ReadKey();
        }

        private static int Menu()
        {
            Console.WriteLine("---------Menu------------");
            Console.WriteLine("1. Metodo1");
            Console.WriteLine("2. Metodo2");
            Console.WriteLine("3. Metodo3");
            Console.WriteLine("4. Metodo4");
            Console.WriteLine("5. Metodo5");
            Console.WriteLine("6. Metodo6");
            Console.WriteLine("7. Metodo7");
            Console.WriteLine("8. Metodo8");
            Console.WriteLine("9. Metodo9");
            Console.WriteLine("10. Metodo10");
            Console.WriteLine("11. Salir");
            Console.WriteLine("Seleccione una opcion");
            int opcion = 0;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Metodo1();
                        break;
                    case 2:
                        Metodo2();
                        break;
                    case 3:
                        Metodo3();
                        break;
                    case 4:
                        Metodo4();
                        break;
                    case 5:
                        Metodo5();
                        break;
                    case 6:
                        Metodo6();
                        break;
                    case 7:
                        Metodo7();
                        break;
                    case 8:
                        Metodo8();
                        break;
                    case 9:
                        Metodo9();
                        break;
                    case 10:
                        Metodo10();
                        break;
                }
            }

            return opcion;
        }



        private static void Metodo10()
        {
            string[,] arreglo;
            string palabra;
            bool correcto = true;
            Console.WriteLine("Escriba las filas de la matriz");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba las columnas de la matriz");
            int columnas = int.Parse(Console.ReadLine());
            arreglo = new string[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    do
                    {
                        Console.WriteLine("Escriba una palabra pa la pos [{0},{1}]", i, j);
                        palabra = Console.ReadLine();
                        if (palabra.Length >= 3)
                        {
                            arreglo[i, j] = palabra;
                            correcto = false;
                        }
                        else
                        {
                            Console.WriteLine("la palabra debe tener como minimo 3 caracteres");
                            correcto = true;
                        }
                    } while (correcto);
                }
            }
            Console.WriteLine("");
            foreach (string i in arreglo)
            {
                Console.WriteLine("Palabras guardadas");
                Console.WriteLine(i);
            }


        }

        private static void Metodo9()
        {
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            string nueva = "";
            if (palabra.Length >= 5)
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra.Substring(i, 1) == " ")
                    {
                        Console.WriteLine("Puede ingresar solo una palabra");
                        return;
                    }
                    else
                    {
                        string temp = palabra.Substring(i, 1);
                        if (temp == "a" || temp == "e" || temp == "i" || temp == "o" || temp == "u")
                        {
                            temp = "X";
                        }
                        nueva += temp;
                    }
                }
                Console.WriteLine(nueva);
            }
            else
            {
                Console.WriteLine("La palabra debe contener por lo menos 5 caracteres");
            }

        }

        private static void Metodo8()
        {
            string[] arreglo;
            Console.WriteLine("Ingrese una frase");
            string frase = Console.ReadLine();
            arreglo = frase.Split(' ');
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(arreglo[i].ToUpper());
                }
                else
                {
                    Console.WriteLine(arreglo[i].ToLower());
                }
            }
        }

        private static void Metodo7()
        {
            int contador = 0;
            Console.WriteLine("Ingrese una frase");
            string frase = Console.ReadLine().Trim();
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase.Substring(i, 1) == " ")
                {
                    contador++;
                }
            }
            Console.WriteLine("La frase contiene {0} palabras", contador);
        }

        private static void Metodo6()
        {
            Console.WriteLine("Ingrese una palabra");
            string respuesta = Console.ReadLine();
            string nueva = "";
            if (respuesta.Length > 5)
            {
                for (int i = 0; i < respuesta.Length; i++)
                {
                    string temp = respuesta.Substring(i, 1);
                    if (temp != "a" && temp != "e" && temp != "i" && temp != "o" && temp != "u")
                    {
                        nueva += temp;
                    }

                }
                Console.WriteLine("La frase sin vocales es {0}", nueva);
            }
            else
            {
                Console.WriteLine("La frase debe tener mas de 5 caracteres");
            }
        }

        private static void Metodo5()
        {
            Console.WriteLine("Ingrese una fecha");
            DateTime respuesta;
            if (DateTime.TryParse(Console.ReadLine(), out respuesta))
            {
                Console.WriteLine("Ingreso la fecha correctamente");
            }
            else
            {
                Console.WriteLine("No ingreso una fecha");
            }

        }

        private static void Metodo4()
        {
            Console.WriteLine("Ingrese una palabra");
            string respuesta = Console.ReadLine();
            if (respuesta.Length > 5)
            {
                Console.WriteLine("La palabra ingresada es correcta");
            }
            else
            {
                Console.WriteLine("La palabra debe tener mas de 5 caracteres");
            }
        }

        private static void Metodo3()
        {
            Console.WriteLine("Ingrese true o false");
            bool correcto;
            if (bool.TryParse(Console.ReadLine(), out correcto))
            {
                Console.WriteLine("El dato es correcto");
            }
            else
            {
                Console.WriteLine("Solo puede ingresar true o false");
            }
        }

        private static void Metodo2()
        {
            int entero = 0;
            Console.WriteLine("Ingrese entre 10 y 20 para convertirlo a entero");
            string respuesta = Console.ReadLine();
            if (int.TryParse(respuesta, out entero))
            {

                if (entero > 9 && entero < 21)
                {
                    Console.WriteLine("El dato se pudo convertir a entero");
                }
                else
                {
                    Console.WriteLine("ingrese un numero entre 10 y 20");
                }
            }
            else
            {
                Console.WriteLine("El dato no se pudo convertir a entero");
            }
        }

        private static void Metodo1()
        {
            Console.WriteLine("Ingrese un dato para intentar convertirlo a entero");
            int entero = 0;
            if (int.TryParse(Console.ReadLine(), out entero))
            {
                Console.WriteLine("El dato se pudo convertir a entero");
            }
            else
            {
                Console.WriteLine("El dato no se pudo convertir a entero");
            }

        }
    }
}
