using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class Cl_Adulto : Cl_Paciente, IPaciente
    {
        private string _trabajo;

        public string Trabajo
        {
            get { return _trabajo; }
            set { _trabajo = value; }
        }

        public override int ValorAtencion()
        {
            int costo = CalculoCosto();
            switch (TipoSalud)
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

        public Cl_Adulto()
            : base()
        {
            Init();
        }

        private void Init()
        {
            Trabajo = "Si";
        }

        public Cl_Adulto(int nf, string nomb, DateTime fech, int ho, TipoSalud ts, int ed, string tra)
            : base(nf, nomb, ed, 0, ts, fech, ho)
        {
            Trabajo = tra;
        }


        public int CalculoCosto()
        {
            return 5000;
        }
    }
}
