using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class CL_INTERNACIONAL: CL_BUS, IBus
    {
        public TipoPais Pais { get; set; }
        public string Ciudad { get; set; }

        public CL_INTERNACIONAL()
        {
            Init();
        }

        private void Init()
        {
            Pais =TipoPais.Argentina; Ciudad = string.Empty;
        }
        public CL_INTERNACIONAL(string pa,string cho,DateTime fe,
            int ho,int pre,TipoPais tp,string ciu):base(pa,cho,fe,ho,pre)
        {
            Pais = tp; Ciudad = ciu;
        }


        public int PrecioTotal()
        {
            return (int)((Precio) + (Precio * 0.04));
        }

        public int TiempoDemora
        {
            get {
                switch (Pais)
                {
                    case TipoPais.Argentina:
                        return 6;                        
                    case TipoPais.Brasil:
                        return 10;                        
                    case TipoPais.Peru:
                        return 8;                        
                    default:
                        return 0;
                }
            }
        }
        public string Imprimir() {
            return string.Format("\n {0} \n Total Pasaje:{1} \n Tiempo Demora:{2}",
                base.Imprimir(), PrecioTotal(), TiempoDemora);
        }
    }
}
