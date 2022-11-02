using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Semestre_3
{
    public class Internacional : Pasajes_Aereos, IPasajes
    {
        private TipoPais _elPais;

        public TipoPais ElPais
        {
            get { return _elPais; }
            set { _elPais = value; }
        }

        public Internacional() : base()
        {
            Init();
        }

        private void Init()
        {
            ElPais = TipoPais.Brazil;
        }

        public int PrecioTotal()
        {
            int impuesto = (int)(Precio * 0.07);
            return Precio + impuesto;

        }

        public int TiempoDemora()
        {
           
            switch (ElPais)
            {
                case TipoPais.Brazil:
                    return 6;
                case TipoPais.España:
                    return 12;
                case TipoPais.EEUU:
                    return 9;
                default:
                    return 0;
            }

            return Precio;
        }

        public Internacional(int prs, string nbr, int hr, string cod, TipoPais tp) : base(prs, nbr, hr, cod)
        {
            ElPais = tp;
        }

        public string imprimir()
        {
            return string.Format("\n {0}, Total Pasaje {1}, Tiempo Demora {2}",base.imprimir(),PrecioTotal(),TiempoDemora());
        }
    }
}
