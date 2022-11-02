using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class Cl_Gerente: Cl_Persona
    {

        private string _sucursal;
        private string _region;
        private string _ciudad;

        public string Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }
        
        public string Region
        {
            get { return _region; }
            set { _region = value; }
        }
        
        public string Sucursal
        {
            get { return _sucursal; }
            set { _sucursal = value; }
        }

        public Cl_Gerente():base()
        {
            Init();
        }
        public Cl_Gerente(string nom,string ape,int ed, string suc,string reg,string ciu)
            :base(nom,ape,ed)
        {
            Sucursal = suc; Region = reg; Ciudad = ciu;
        }

        private void Init()
        {
            Sucursal = "SS"; Region = "SR"; Ciudad = "SC";
        }
        public string Imprimir() {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n Nombre: " + Nombre);
            sb.Append("\n Apellido: " + Apellido);
            sb.Append("\n Edad: " + Edad);
            sb.Append("\n Sucursal:" + Sucursal);
            sb.Append("\n Region:" + Region);
            sb.Append("\n Ciudad:" + Ciudad);
            return sb.ToString();
        }
    }
}
