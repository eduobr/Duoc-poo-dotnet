using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibClases
{
    public enum TipoViaje { Seleccione, Internacional, Urbano }
    public class Bus
    {
        public string Patente { get; set; }
        public int Precio { get; set; }
        public string NombreChofer { get; set; }
        public DateTime FechaHora { get; set; }
        public TipoViaje Tipo { get; set; }
        public Bus()
        {
            Init();
        }

        public Bus(string pat, int pre, string nomcho, DateTime fh, TipoViaje tv)
        {
            Patente = pat;
            Precio = pre;
            NombreChofer = nomcho;
            FechaHora = fh;
            Tipo = tv;
        }
        private void Init()
        {
            Patente = string.Empty;
            Precio = 0;
            NombreChofer = string.Empty;
            FechaHora = DateTime.Now;
            Tipo = TipoViaje.Internacional;
        }
    }
}
