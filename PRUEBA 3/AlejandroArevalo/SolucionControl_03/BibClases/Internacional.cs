using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibClases
{
    public enum TipoPais { Seleccione, Argentina, Brasil, Peru }
    public class Internacional : Bus, IntViaje
    {
        public TipoPais PaisDestino { get; set; }
        public string CiudadDestino { get; set; }
        public Internacional()
            : base()
        {
            Init();
        }
        public Internacional(string pat, int pre, string nomcho, DateTime fh, TipoViaje tv, TipoPais pd, string cd)
            : base(pat, pre, nomcho, fh, tv)
        {
            PaisDestino = pd;
            CiudadDestino = cd;
        }
        private void Init()
        {
            PaisDestino = TipoPais.Argentina;
            CiudadDestino = string.Empty;
        }

        public int PrecioTotal
        {
            get
            {
                return (int)(base.Precio * 1.04);
            }
        }

        public int TiempoDemora
        {
            get
            {
                int resp = 0;
                switch ((TipoPais)PaisDestino)
                {
                    case TipoPais.Argentina:
                        resp = 6;
                        break;
                    case TipoPais.Brasil:
                        resp = 10;
                        break;
                    case TipoPais.Peru:
                        resp = 8;
                        break;
                }
                return resp;
            }
        }
    }
}
