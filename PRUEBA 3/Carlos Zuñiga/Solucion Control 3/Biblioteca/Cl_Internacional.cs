using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public enum TipoPais { Perú, Brasil, Argentina}

    public class Cl_Internacional:Cl_Buses
    {
        private TipoPais _pais;
        private string _ciudad;

        public string Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }
        

        public TipoPais Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
        public Cl_Internacional():base()
        {
            Init();
        }

        public Cl_Internacional(string pa, int pre, string nom, DateTime fe, string ci, TipoPais pais):base(pa,pre,nom,fe)
        {
            Patente = pa; Precio = pre; NombreChofer = nom; Fecha = fe; Ciudad = ci; Pais = pais;
        }
        private void Init()
        {
            Patente = string.Empty;
            Precio = 0;
            NombreChofer = string.Empty;
            Fecha = DateTime.Now;
            Ciudad = string.Empty;
            Pais = TipoPais.Brasil;
        }

        public override int PrecioTotal()
        {
            int pretot = 0;

            pretot = (int) (Precio * 1.04);
            return pretot;
        }
        public override int TiempoDemora()
        {
            int td = 0;
            switch (Pais)
            {
                case TipoPais.Perú:
                    td = 8;
                    break;
                case TipoPais.Brasil:
                    td = 10;
                    break;
                case TipoPais.Argentina:
                    td = 6;
                    break;
                default:
                    break;
            }
            return td;
        }
    }
}
