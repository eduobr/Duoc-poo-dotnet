using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class CL_NINO:CL_PACIENTE,IPaciente
    {
        private string _colegio;

        public string Colegio
        {
            get { return _colegio; }
            set { _colegio = value; }
        }

        public CL_NINO():base()
        {
            Init();
        }
        private void Init()
        {
            Colegio = "SC";
        }
        public CL_NINO(int nf,string nom,int ed,TipoSalud salud,
            DateTime fech,int ho, string cole):base(nf,nom,ed,0,salud,fech,ho)
        {
            Colegio = cole;
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
            switch (Salud)
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
