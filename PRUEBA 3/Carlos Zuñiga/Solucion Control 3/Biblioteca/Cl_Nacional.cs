using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public enum TipoRegion { Norte, Centro, Sur}
    public class Cl_Nacional:Cl_Buses
    {
        private string _terminal;
        private TipoRegion _region;

        public TipoRegion Region
        {
            get { return _region; }
            set { _region = value; }
        }
        

        public string Terminal
        {
            get { return _terminal; }
            set { _terminal = value; }
        }

        public Cl_Nacional():base()
        {
            Init();
        }
        public Cl_Nacional(string pa, int pre, string nom, DateTime fe, TipoRegion re, string ter):base(pa,pre,nom,fe)
        {
            Patente = pa; Precio = pre; NombreChofer = nom; Fecha = fe; Region = re; Terminal = ter;
        }

        private void Init()
        {
            Patente = string.Empty; NombreChofer = string.Empty; Precio = 0;
            Fecha = DateTime.Now; Region = TipoRegion.Sur; Terminal = string.Empty;
        }

        public override int PrecioTotal()
        {
            int pt = 0;
            pt = (int)(Precio * 1.015);
            return pt;
        }
        public override int TiempoDemora()
        {
            int td = 0;
            switch (Region)
            {
                case TipoRegion.Norte:
                    td = 5;
                    break;
                case TipoRegion.Centro:
                    td = 4;
                    break;
                case TipoRegion.Sur:
                    td = 6;
                    break;
                default:
                    break;
            }
            return td;
        }
    }
}
