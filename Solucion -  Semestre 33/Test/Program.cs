using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Semestre_3;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {


            Nacional nac = new Nacional(599990, "Eduardo Andres", 10, "B111", TipoDestino.Centro);
            Internacional inter = new Internacional(699990, "Eduardo Fuentes", 20, "B222", TipoPais.Brazil);

            List<Pasajes_Aereos> Pasajes = new List<Pasajes_Aereos>();
            Pasajes.Add(nac);
            Pasajes.Add(inter);

            foreach (var item in Pasajes)
            {
                if (item.GetType() == typeof(Nacional))
                {
                    Console.WriteLine("- Viaje Nacional -");
                    Console.WriteLine("Nombre: " + nac.NombrePasajero);
                    Console.WriteLine("Hora Pasaje: " + nac.HoraPasaje);
                    Console.WriteLine("Destino: " + nac.ElDestino);
                    Console.WriteLine("Codigo Pasaje: " + nac.CodigoPasaje);
                    Console.WriteLine("Precio: " + nac.Precio);
                    Console.WriteLine("Precio Total del pasaje es: " + ((Nacional)item).PrecioTotal());
                }
                if (item.GetType() == typeof(Internacional))
                {
                    Console.WriteLine("- Viaje Internacional -");
                    Console.WriteLine("Nombre: " + inter.NombrePasajero);
                    Console.WriteLine("Hora Pasaje: " + inter.HoraPasaje);
                    Console.WriteLine("Pais: " + inter.ElPais);
                    Console.WriteLine("Codigo Pasaje: " + inter.CodigoPasaje);
                    Console.WriteLine("Precio: " + inter.Precio);
                    Console.WriteLine("Precio Total del pasaje es: " + ((Internacional)item).PrecioTotal());
                }
            }

            Console.ReadKey();
        }
    }
}
