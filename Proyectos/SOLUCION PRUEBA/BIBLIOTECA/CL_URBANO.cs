using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class CL_URBANO: CL_BUS, IBus
    {
        public string Terminal { get; set; }
        public TipoDestino Destino { get; set; }

        public CL_URBANO()
        {
            Init();
        }

        private void Init()
        {
            Terminal = ""; Destino = TipoDestino.Centro;
        }
        public CL_URBANO(string pa,string cho,DateTime fe,
            int ho,int pre,TipoDestino td,string ter):base(pa,cho,fe,ho,pre)
        {
            Terminal = ter; Destino = td;
        }

        public int PrecioTotal()
        {
            return (int)(Precio-(Precio*0.015));
        }

        public int TiempoDemora
        {
            get {
                switch (Destino)
                {
                    case TipoDestino.Norte:
                        return 5;                        
                    case TipoDestino.Sur:
                        return 6;                        
                    case TipoDestino.Centro:
                        return 4;                        
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
