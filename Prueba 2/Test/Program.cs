using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca_de_Clases;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cl_Cliente cli = new Cl_Cliente("Pedro",TipoSexo.Masculino,new DateTime(02,05,10));
                Cl_Cuenta cuenta = new Cl_Cuenta(TipoCuenta.Ahorro, new DateTime(01,01,10), cli,20000);
                
            }
            catch (Exception ex)
            {                           
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
