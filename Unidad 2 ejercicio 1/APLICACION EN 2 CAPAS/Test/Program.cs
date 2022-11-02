using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIBLIOTECA_EJERCICIO;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cl_Mascota mascota1 = new Cl_Mascota();
                mascota1.Codigo = 1;
                mascota1.Nombre = "CHULETA";
                mascota1.Raza = TipoRaza.Poddle;
                mascota1.Edad = 3;
                mascota1.FechaInscripcion = new DateTime(2016, 01, 01);
                mascota1.Sexo = TipoSexo.Macho;
                Console.WriteLine(mascota1.Imprimir());
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadKey();
            try
            {
                Cl_Departamento depto1 = new Cl_Departamento();
                depto1.Numero = 15;
                depto1.Habitaciones = TipoHabitaciones.Doble;
                depto1.Fono = "12547895";
                depto1.Baños = 3;
                depto1.Direccion = "Las albondigas #1313";
                depto1.FechaEntrega = new DateTime(2016, 04, 20);
                depto1.Valor = 1500;
                Console.WriteLine(depto1.Imprimir());
                Console.WriteLine("Pesos:{0}",depto1.Pesos(27000).ToString("$###,###,###"));
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadKey();
            try
            {
                Cl_Taxi taxi1 = new Cl_Taxi();
                taxi1.Patente = "HHHH99";
                taxi1.Modelo = TipoModelo.City;
                taxi1.Marca = TipoMarca.Chevrolet;
                taxi1.Puertas = 4;
                taxi1.ValorKM = 350;
                taxi1.FechaRegistro = new DateTime(2015, 02, 15);
                Console.WriteLine(taxi1.Imprimir());

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            Console.ReadKey();
        }
    }
}
