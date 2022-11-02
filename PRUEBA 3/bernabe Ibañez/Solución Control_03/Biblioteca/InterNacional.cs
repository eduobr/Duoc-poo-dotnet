using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public enum TipoPais
    {
        Seleccione, Argentina, Brasil, Perú
    }
    public class InterNacional : Bus, IBus
    {
        private TipoPais _destino;
        private string _ciudadDes;

        public string CiudadDes
        {
            get { return _ciudadDes; }
            set { _ciudadDes = value; }
        }


        public TipoPais Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        public InterNacional()
            : base()
        {
            _destino = TipoPais.Argentina;
            _ciudadDes = "blasobia";
        }
        public InterNacional(string pa, int pre, string nocho, DateTime feho,TipoBus tb, TipoPais tp, string cd)
            : base(pa, pre, nocho, feho,tb)
        {
            _destino = tp;
            _ciudadDes = cd;
        }

        public double PrecioTotal()
        {
            double pt = base.Precio * 1.4;
            return pt;
        }
        public int TiempoDemora()
        {
            int ch = 0;

            switch (Destino)
            {
                case TipoPais.Argentina:
                    ch = 6;
                    break;
                case TipoPais.Brasil:
                    ch = 10;
                    break;
                case TipoPais.Perú:
                    ch = 8;
                    break;
                default:
                    throw new Exception("Debe Seleccionar un campo valido");                  
            }


            return ch;
        }


    }
}
