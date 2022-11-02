using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca_Modelo
{
    public class Cl_Persona
    {
        //campo
        private string _rut;
        private string _nombre;
        private string _apellido;
        private int _edad;
        private char _sexo;

        //propiedades
        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set
            {
                if (value > 0)
                {
                    _edad = value;
                }
                else
                {
                    throw new Exception("Edad menor o igual a 0");
                }
            }
        }

        public char Sexo
        {
            get { return _sexo; }
            set {
                if (value.Equals('F') || value.Equals('M'))
                {
                    _sexo = value;
                }
                else
                {
                    throw new Exception("Solo F o M");
                }
            }
        }

        public Cl_Persona() {
            Init();
      
        }

        private void Init()
        {
            Rut = string.Empty;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Sexo = 'F';
            Edad = 1;
        }

        //customer
        public string Imprimir()
        {
            return "Rut:" + Rut + " Nombre Completo:" + Nombre + " " + Apellido + " Edad:" + Edad + " Sexo:" + Sexo;

        }
    }
}
