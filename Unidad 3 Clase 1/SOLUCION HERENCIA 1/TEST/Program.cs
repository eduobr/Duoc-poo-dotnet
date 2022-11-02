using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BIBLIOTECA;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cl_Persona> personas = new List<Cl_Persona>();

            Cl_Empleado emp = 
                new Cl_Empleado("Juan", "Perez", 30, new DateTime(1999, 5, 12), "Contador", 780000);
            Cl_Gerente gerent = new Cl_Gerente("Andres", "Lopez", 56, "Providencia", "RM", "STGO");

            personas.Add(emp);
            personas.Add(gerent);

            //Console.WriteLine("Empleado:"+emp.Imprimir());
            //Console.WriteLine("Gerente:"+gerent.Imprimir());

            foreach (Cl_Persona item in personas)
            {
                //Console.WriteLine("Nombre:"+item.Nombre);
                //Console.WriteLine("Apellido:"+item.Apellido);
                if (item.GetType()== typeof(Cl_Gerente))
                {
                    Cl_Gerente ger=(Cl_Gerente)item;
                    Console.WriteLine("Gerente:"+ger.Imprimir());
                }
                if (item.GetType()==typeof(Cl_Empleado))
                {
                    Console.WriteLine("Empleado:"+  ( (Cl_Empleado)item ).Imprimir()  );
                }
            }

            Console.ReadKey();
        }
    }
}
