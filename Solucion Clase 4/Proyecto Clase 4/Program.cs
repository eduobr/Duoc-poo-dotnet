using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Clase_4
{
    class Program
    {
        static Cl_Persona[] personas = new Cl_Persona[3];
        static int pos = 0;
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                op = Menu();
            } while (op!=3);
        }

        private static int Menu()
        {
            Console.WriteLine("Menu Agenda");
            Console.WriteLine(new string('-',15));
            Console.WriteLine("1.- Agregar Personas");
            Console.WriteLine("2.- Listar Personas");
            Console.WriteLine("3.-Salir");
            Console.WriteLine("Seleccione (1-3)");
            int op = 0;
            if (int.TryParse(Console.ReadLine(), out op))
            {
                if (op > 0 && op <= 3)
                {
                    switch (op)
                    {
                        case 1:
                            Agregar();
                            break;
                        case 2:
                            Listar();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Solo numeros entre 1 y 3");
                }
            }
            else
            {
                Console.WriteLine("Solo ingrese numeros");
            }
            Pausa();
            return op;
        }

        private static void Listar()
        {
            foreach(Cl_Persona item in personas){
                if (item!=null)
                {
                    Console.WriteLine(item.Imprimir());
                }
            }
            Console.WriteLine("Fin del listado");
        }

        private static void Agregar()
        {
            if (pos == 3)
            {
                Console.WriteLine("Arreglo Lleno");
                return;
            }
            Cl_Persona per = new Cl_Persona();
            Console.WriteLine("Ingrese Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese Edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese sexo (f,m):");
            char sexo = char.Parse(Console.ReadLine());
            per.Nombre = nombre;
            per.Apellido = apellido;
            per.Edad = edad;
            per.Sexo = sexo;            
            personas[pos] = per;
            pos++;
            Console.WriteLine("Grabo {0}", pos);
        }

        private static void Pausa()
        {
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
