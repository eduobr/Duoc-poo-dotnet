using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIBLIOTECA_CLASES;
namespace TES
{
    class Program
    {
        static CL_TAXI[] taxis = new CL_TAXI[5];

        static void Main(string[] args)
        {
            try
            {
                int numero = Generar_Id(TipoTaxi.Uber);
                CL_TAXI taxi = new CL_TAXI(TipoTaxi.Uber, numero.ToString());
                taxis[0] = taxi;
                Console.WriteLine(taxi.Imprimir());

                numero = Generar_Id(TipoTaxi.Uber);
                taxi = new CL_TAXI(TipoTaxi.Uber, numero.ToString());
                taxis[1] = taxi;
                Console.WriteLine(taxi.Imprimir());

                numero = Generar_Id(TipoTaxi.Normal);
                taxi = new CL_TAXI(TipoTaxi.Normal, numero.ToString());
                taxis[2] = taxi;
                Console.WriteLine(taxi.Imprimir());

                numero = Generar_Id(TipoTaxi.Uber);
                taxi = new CL_TAXI(TipoTaxi.Uber, numero.ToString());
                taxis[3] = taxi;
                Console.WriteLine(taxi.Imprimir());

            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            Console.ReadKey();
        }

        private static int Generar_Id(TipoTaxi tipoTaxi)
        {
            int pos = 0;
            foreach (CL_TAXI item in taxis)
            {
                if (item!=null)
                {
                    if (item.Tipo==tipoTaxi)
                    {
                        pos++;
                    }
                }
            }
            pos++;
            return pos;
        }
    }
}
