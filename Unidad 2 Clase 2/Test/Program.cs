using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIBLIOTECA_MODELO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Cl_Interprete sakira = new Cl_Interprete();
            sakira.Nombre = "Juanita Perez";
            sakira.Sexo = Tiposexo.Femenino;
            sakira.Pais = Nacionalidad.Extranjero;
            sakira.Estilo = EstilosMusicales.Pop;
            sakira.Edad = 85;

            Cl_Album wakatela = new Cl_Album(3);
            wakatela.Interprete = sakira;
            wakatela.Nombre = "Wakatela POP";
            wakatela.Precio = 20000;
            wakatela.FechaPublicacion = new DateTime(1972, 04, 12);
            
            wakatela.AgregarTema("Cabeza de chancho POP");
            wakatela.AgregarTema("el erizo");
            wakatela.AgregarTema("El baile del perrito H2");
            Console.WriteLine("Interprete:{0}",sakira.Imprimir());
            Console.WriteLine("Album:{0}",wakatela.Imprimir());
            Console.WriteLine("Temas:{0}",wakatela.ListaDeTemas());
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
