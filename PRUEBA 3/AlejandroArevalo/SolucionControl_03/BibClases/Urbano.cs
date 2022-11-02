using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibClases
{
    public enum TipoRegion { Seleccione, Norte, Sur, Centro }
    public class Urbano : Bus, IntViaje
    {
        public string Terminal { get; set; }
        public TipoRegion RegionDestino { get; set; }
        public Urbano()
            : base()
        {
            Init();
        }
        public Urbano(string pat, int pre, string nomcho, DateTime fh, TipoViaje tv, string ter, TipoRegion rd)
            : base(pat, pre, nomcho, fh, tv)
        {
            Terminal = ter;
            RegionDestino = rd;
        }
        private void Init()
        {
            Terminal = string.Empty;
            RegionDestino = TipoRegion.Centro;
        }
        public int PrecioTotal
        {
            get
            {
                return (int)(base.Precio * 1.015);
            }
        }

        public int TiempoDemora
        {
            get
            {
                int resp = 0;
                switch ((TipoRegion)RegionDestino)
                {
                    case TipoRegion.Norte:
                        resp = 5;
                        break;
                    case TipoRegion.Sur:
                        resp = 6;
                        break;
                    case TipoRegion.Centro:
                        resp = 4;
                        break;
                }
                return resp;
            }
        }
    }
}
