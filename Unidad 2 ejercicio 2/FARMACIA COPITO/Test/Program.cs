using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIBLIOTECA_DE_CLASES;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cl_Cliente Cli = new Cl_Cliente(1,"Juan Perez",new DateTime(2016,1,1),TipoCliente.Fonasa);
                Cl_Producto Prod = new Cl_Producto(1,new DateTime(2016,05,01),"confort",20000,10,TipoCategoria.Adulto);
                Cl_Venta Vent = new Cl_Venta();
                Vent.Numero = 1;
                Vent.Producto = Prod;
                Vent.Cliente = Cli;
                Vent.Cantidad = 50;
                Console.WriteLine("Cantidad Credito {0}",Cli.Credito);
                Console.WriteLine("Cantidad a Comprar {0}",Prod.Cantidad);
                Vent.RealizarCompra();
                Console.WriteLine("Venta Realizada");
                Console.WriteLine("Cantidad Nuevo Credito {0}",Cli.Credito);
                Console.WriteLine("Stock producto {0}",Prod.Cantidad);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
