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
            CL_DVD dvd = new CL_DVD("rapido y furioso",2000,12,120);
            CL_BLUERAY blue = new CL_BLUERAY("rapido lento",2001,200,2);
            List<CL_PELICULA> lista = new List<CL_PELICULA>();
            lista.Add(dvd);
            lista.Add(blue);
            foreach (CL_PELICULA item in lista)
            {
                Console.WriteLine(item.Imprimir());
                if (item.GetType()==typeof(CL_DVD))
                {
                    Console.WriteLine("Cantidad de Minutos:"+((CL_DVD)item).CantidadM);
                    Console.WriteLine("Actualizacion:"+((CL_DVD)item).Actualizacion);
                    Console.WriteLine("Duplicado:"+((CL_DVD)item).Duplicado());
                }
                if (item.GetType()==typeof(CL_BLUERAY))
                {
                    Console.WriteLine("Cantidad de camaras:"+((CL_BLUERAY)item).CantidadC);
                    Console.WriteLine("Actualizacion:"+((CL_BLUERAY)item).Actualizacion);
                    Console.WriteLine("Duplicado:"+((CL_BLUERAY)item).Duplicado());
                }
            }
            Console.ReadKey();
        }
    }
}
