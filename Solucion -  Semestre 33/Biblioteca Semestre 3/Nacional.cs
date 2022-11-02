using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Semestre_3
{
    public class Nacional : Pasajes_Aereos, IPasajes
    {
        private TipoDestino _elDestino;

        public TipoDestino ElDestino
        {
            get { return _elDestino; }
            set { _elDestino = value; }
        }

        public Nacional() : base()
        {
            Init();
        }

        private void Init()
        {
            ElDestino = TipoDestino.Norte;
        }

        public int PrecioTotal()
        {
            int impuesto = (int)(Precio * 0.03);
            return Precio + impuesto;
        }

        public int TiempoDemora()
        {
            switch (ElDestino)
            {
                case TipoDestino.Norte:
                    return 9;
                case TipoDestino.Centro:
                    return 3;
                case TipoDestino.Sur:
                    return 7;
                default:
                    return 0;
            }
            return Precio;
        }

        public Nacional(int prs, string nbr, int hr, string cod, TipoDestino des) : base(prs, nbr, hr, cod)
        {
            ElDestino = des;
        }
    }
}
