using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_CLASES
{
    public enum TipoTaxi { 
        Normal,Uber
    }
    public class CL_TAXI
    {
        private TipoTaxi _tipo;
        private string _identificador;

        public string Identificador
        {
            get { return _identificador; }
            set {
                _identificador = value;
                GenerarIdentificador();
            }
        }

        private void GenerarIdentificador()
        {
            string Ident = "TRN-";
            switch (Tipo)
            {
                case TipoTaxi.Normal:
                    Ident += "NOR-";
                    break;
                case TipoTaxi.Uber:
                    Ident += "UBE-";
                    break;
                default:
                    break;
            }
            Ident += _identificador.PadLeft(5, '0');
            _identificador = Ident;
        }
        
        public TipoTaxi Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public CL_TAXI(TipoTaxi ta,string id)
        {
            Tipo = ta; Identificador = id;
        }
        public string Imprimir() {
            return string.Format("Tipo {0} Identificador:{1}", Tipo, Identificador);
        }
    }
}
