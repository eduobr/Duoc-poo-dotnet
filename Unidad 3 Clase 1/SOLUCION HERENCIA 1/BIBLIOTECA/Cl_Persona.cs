using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class Cl_Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public Cl_Persona()
        {
            Init();
        }

        private void Init()
        {
            Nombre = "SN"; Apellido = "SA"; Edad = 18;
        }
        public Cl_Persona(string nom,string ape,int ed)
        {
            Nombre = nom; Apellido = ape; Edad = ed;
        }
        
    }
}
