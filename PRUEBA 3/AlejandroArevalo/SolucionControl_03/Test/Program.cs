using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibClases;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bus> viajes = new List<Bus>();
            Internacional viajeInt = new Internacional();
            Urbano viajeUrb = new Urbano();
            int anio = DateTime.Today.Year;
            int mes = DateTime.Today.Month;
            int dia = DateTime.Today.Day;

            viajeInt.CiudadDestino = "Santiago";
            viajeInt.FechaHora = new DateTime(anio, mes, dia, 10, 0, 0);
            viajeInt.NombreChofer = "Juan Perez";
            viajeInt.PaisDestino = TipoPais.Argentina;
            viajeInt.Patente = "FFFS34";
            viajeInt.Precio = 10000;
            viajeInt.Tipo = TipoViaje.Internacional;
            viajes.Add(viajeInt);

            viajeUrb.FechaHora = new DateTime(anio, mes, dia, 10, 0, 0);
            viajeUrb.NombreChofer = "Pablo Perez";
            viajeUrb.Patente = "HLLC65";
            viajeUrb.Precio = 100000;
            viajeUrb.RegionDestino = TipoRegion.Sur;
            viajeUrb.Terminal = "TEMUCO";
            viajeUrb.Tipo = TipoViaje.Urbano;
            viajes.Add(viajeUrb);

            StringBuilder sb = new StringBuilder();

            foreach (Bus item in viajes)
            {
                if (item.GetType() == typeof(Internacional))
                {
                    sb.AppendLine("Viaje Internacional");
                    sb.AppendLine();
                    sb.AppendLine("Ciudad Destino : " + viajeInt.CiudadDestino);
                    sb.AppendLine("Fecha y Hora   : " + viajeInt.FechaHora.ToString());
                    sb.AppendLine("Nombre Chofer  : " + viajeInt.NombreChofer);
                    sb.AppendLine("País Destino   : " + viajeInt.PaisDestino);
                    sb.AppendLine("Patente        : " + viajeInt.Patente);
                    sb.AppendLine("Precio         : " + viajeInt.Precio.ToString());
                    sb.AppendLine("Tipo Viaje     : " + viajeInt.Tipo.ToString());
                    sb.AppendLine("Precio Total   : " + viajeInt.PrecioTotal.ToString());
                    sb.AppendLine("Tiempo Demora  : " + viajeInt.TiempoDemora.ToString());
                }
                if (item.GetType() == typeof(Urbano))
                {
                    sb.AppendLine("Viaje Urbano");
                    sb.AppendLine();
                    sb.AppendLine("Terminal Destino : " + viajeUrb.Terminal);
                    sb.AppendLine("Fecha y Hora     : " + viajeUrb.FechaHora.ToString());
                    sb.AppendLine("Nombre Chofer    : " + viajeUrb.NombreChofer);
                    sb.AppendLine("Región Destino   : " + viajeUrb.RegionDestino.ToString());
                    sb.AppendLine("Patente          : " + viajeUrb.Patente);
                    sb.AppendLine("Precio           : " + viajeUrb.Precio.ToString());
                    sb.AppendLine("Tipo Viaje       : " + viajeUrb.Tipo.ToString());
                    sb.AppendLine("Precio Total     : " + viajeUrb.PrecioTotal.ToString());
                    sb.AppendLine("Tiempo Demora    : " + viajeUrb.TiempoDemora.ToString());
                }
                sb.AppendLine(new string('-',40));
            }
            sb.AppendLine("Datos Estadísticos.");
            sb.AppendLine();
            sb.AppendLine("Mayor Precio : " + viajes.Max(v => v.Precio).ToString());
            sb.AppendLine("Menor Precio : "+viajes.Min(v => v.Precio).ToString());
            sb.AppendLine("Total Internacionales : "+viajes.Where(v => v.GetType() == typeof(Internacional)).Count().ToString());
            sb.AppendLine("Total Urbanos al Sur : " + viajes.Where(v => v.GetType() == typeof(Urbano) && ((Urbano)v).RegionDestino == TipoRegion.Sur).Count().ToString());
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
