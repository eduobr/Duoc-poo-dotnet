using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BIBLIOTECA_CLASES;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cl_Transporte trans =
                    new Cl_Transporte("QWUO77", MarcaCamion.Toyota, "JUANITO JARA", 3, 
                                       false, TipoCaja.Automatica, "Santiago", "Chillan");
                Cl_Carga carga = new Cl_Carga("1", TipoCarga.Nacional, DateTime.Now, DateTime.Now, 
                    "Papeles", 150, 1, trans, TipoDestino.Norte);

                Console.WriteLine("Valor carga:{0}",carga.ValorCarga(26000));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
