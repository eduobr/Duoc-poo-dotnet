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
            CL_IMPRESO imp = new CL_IMPRESO("Amores Perros",1985,"Chuleta",250);
            CL_DIGITAL dig = new CL_DIGITAL("50 sobras de max",2010,"Max Power",17);
            List<CL_LIBRO> lista = new List<CL_LIBRO>();
            lista.Add(imp); lista.Add(dig);
            foreach (CL_LIBRO item in lista)
            {
                Console.WriteLine(item.Imprimir());
                if (item.GetType() == typeof(CL_IMPRESO))
                {
                    Console.WriteLine("Cantidad Paginas:" + ((CL_IMPRESO)item).CantidadPaginas);
                    Console.WriteLine("Renovacion:"+((CL_IMPRESO)item).Renovacion);
                    Console.WriteLine("Reproduccion"+((CL_IMPRESO)item).Reproduccion());
                }
                else
                {
                    Console.WriteLine("Tamaño MB:"+((CL_DIGITAL)item).Tamano);
                    Console.WriteLine("Renovacion:"+((CL_DIGITAL)item).Renovacion);
                    Console.WriteLine("Reproduccion"+((CL_DIGITAL)item).Reproduccion());
                }
            }
            Console.ReadKey();
        }
    }
}
