using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public enum TipoLocacion
    {
        Seleccione, norte, sur, centro
    }
    public class Urbano : Bus, IBus
    {
        private string _terminal;
        private TipoLocacion _locacionD;

        public TipoLocacion LocacionD
        {
            get { return _locacionD; }
            set { _locacionD = value; }
        }
        

        public string Terminal
        {
            get { return _terminal; }
            set { _terminal = value; }
        }

        public Urbano():base()
        {
            _terminal = "jojimbo";
            _locacionD = TipoLocacion.centro;
        }
        public Urbano(string pa,int pre,string nocho,DateTime feho,TipoBus tb,string ter,TipoLocacion tl):base(pa,pre,nocho,feho,tb)
        {
            _terminal = ter;
            _locacionD = tl;
        }

        //Interface Methods
        public double PrecioTotal()
        {
            double pt = base.Precio * 2.5;
            return pt;
        }
        public int TiempoDemora()
        {
            int ch = 0;
            switch (LocacionD)
            {
                case TipoLocacion.norte:
                    ch = 5;
                    break;
                case TipoLocacion.sur:
                    ch = 6;
                    break;
                case TipoLocacion.centro:
                    ch = 4;
                    break;
                default:
                    throw new Exception("Debe Seleccionar un campo valido");
            }

            return ch;
        }
    }
}
