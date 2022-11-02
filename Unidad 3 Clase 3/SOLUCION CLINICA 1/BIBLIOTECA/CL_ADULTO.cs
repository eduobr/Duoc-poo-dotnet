using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class CL_ADULTO:CL_PACIENTE,IPaciente
    {
        private string _trabajo;

        public string Trabajo
        {
            get { return _trabajo; }
            set { _trabajo = value; }
        }

        public CL_ADULTO():base()
        {
            Init();
        }

        private void Init()
        {
            Trabajo = "ST";
        }
        public CL_ADULTO(int nf,string nom,int ed,TipoSalud ts,
            DateTime fech,int ho, string tra):base(nf,nom,ed,0,ts,fech,ho)
        {
            Trabajo = tra;
        }

        public override int ValorAtencion()
        {
            int costo = CalculoCosto();
            switch (Salud)
            {
                case TipoSalud.Isapre:
                    costo += (int)(costo * 0.05);
                    break;
                case TipoSalud.Fonasa:
                    costo += (int)(costo * 0.02);
                    break;
                default:
                    break;
            }
            return costo;
        }

        public int CalculoCosto()
        {
            return 5000;
        }
    }
}
