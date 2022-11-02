using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    class Cl_Nino:Cl_Paciente,IPaciente
    {
        private string _colegio;

        public string Colegio
        {
            get { return _colegio; }
            set { _colegio = value; }
        }

        public Cl_Nino()
        {
            Init();
        }

        private void Init()
        {
            Colegio = "SC";
        }

        public Cl_Nino(int nf,string nom,int ed,TipoSalud salud, DateTime fech,int ho,string cole):base(nf,nom,ed,0,salud,fech,ho)
        {
            Colegio = cole;
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

        public int CalculoCosto()
        {
            switch (TipoSalud)
            {
                case TipoSalud.Isapre:
                    return 1500;
                case TipoSalud.Fonasa:
                    return 4500;
                default:
                    break;

            }
            return 0;
        }
    }
}
