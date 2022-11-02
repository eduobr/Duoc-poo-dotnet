using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Clase_4
{
    class Cl_Persona
    {
        //campos
        private string _nombre;
        private string _apellido;
        private int _edad;
        private char _sexo;


        //Propiedades
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public char Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value.Trim().Length > 0)
                {
                    _nombre = value;
                }
                else
                {
                    Console.WriteLine("Ingrese letras");
                }

            }

        }

        public Cl_Persona()
        {

        }

        public string Imprimir()
        {
            return Nombre + " " + Apellido + " " + Sexo + " " + Edad;
        }

    }
}
