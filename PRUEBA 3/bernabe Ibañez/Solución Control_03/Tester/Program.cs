using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca;
namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {

            DaoBus cole = new DaoBus();
            

            InterNacional i = new InterNacional("PA1234", 1200, "perez dalma", DateTime.Now,TipoBus.Internacional, TipoPais.Argentina, "tuGfa");
            Urbano ur=new Urbano("BD1234", 1400, "Julio Borg", DateTime.Now,TipoBus.Urbano,"los alpes",TipoLocacion.norte);

            try
            {
                if (cole.Agregar(i))
                {
                    Console.WriteLine("Agregado Exitosamente");

                }
                else
                {
                    Console.WriteLine("No se pudo agregar");
                }
                if (cole.Agregar(ur))
                {
                    Console.WriteLine("Agregado Exitosamente");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar");
                }
                Console.WriteLine(""+cole.Listar());
                 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Console.ReadKey();
            
        }
    }
}
