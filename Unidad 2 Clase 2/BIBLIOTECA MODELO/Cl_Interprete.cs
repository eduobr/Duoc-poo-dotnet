using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_MODELO
{
    public enum EstilosMusicales { Salsa, Pop, Metal, Cumbia, H2 }
    public enum Nacionalidad { Nacional, Extranjero }
    public enum Tiposexo { Femenino,Masculino}
    public class Cl_Interprete
    {

        //campos  ,, atributos
        private string _nombre;
        private int _edad;
        private Tiposexo _sexo;
        private EstilosMusicales _estilo;
        private Nacionalidad _pais;
        // propiedades get y sets
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value.Length >= 3)
                {
                    _nombre = value;
                }
                else
                {
                    throw new Exception("Largo minimo nombre 3 caracteres");
                }
            }
        }
        public int Edad {
            get { return _edad; }
            set
            {
                if (value >0 && value <=100)
                {
                    _edad = value;
                }
                else
                {
                    throw new Exception("entre 1 y 100");
                }
            }
        }
        public Tiposexo Sexo {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public Nacionalidad Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
        public EstilosMusicales Estilo
        {
            get { return _estilo; }
            set { _estilo = value; }
        }

        public Cl_Interprete()
        {
            init();
        }

        private void init()
        {
            Nombre = "S/N"; Edad = 1; Sexo = Tiposexo.Femenino;
            Estilo = EstilosMusicales.H2; Pais = Nacionalidad.Nacional;
        }
        public string Imprimir() {
            return string.Format("Nombre:{0}, Edad:{1}, Sexo:{2}, Estilo:{3},Pais:{4}",Nombre,Edad,Sexo,Estilo,Pais);
        }
    }
}
