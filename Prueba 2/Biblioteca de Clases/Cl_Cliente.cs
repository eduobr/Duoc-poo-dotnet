using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca_de_Clases
{
    public enum TipoSexo
    {
        Masculino,Femenino
    }
    public class Cl_Cliente
    {
        private string _nombre;
        private TipoSexo _sexo;
        private DateTime _fechaNacimiento;
        private int _edad;


        public int Edad
        {
            get {
                DateTime hoy = DateTime.Now;
                TimeSpan intervalo = hoy - FechaNacimiento;
                _edad=intervalo.Days / 365;
                return _edad;
            }
        }
        

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set
            {
                if (value >= new DateTime(1900, 1, 1) && value <= DateTime.Now)
                {
                    _fechaNacimiento = value;
                }
                else
                {
                    throw new Exception("La fecha ingresada no es correcta");
                }
                
            }
        }
        

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }   

        public TipoSexo Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public Cl_Cliente()
        {
            Init();
        }

        private void Init()
        {
            Nombre = "";
            Sexo = TipoSexo.Masculino;
            FechaNacimiento = DateTime.Now;
            Sexo = TipoSexo.Masculino;
        }

        public Cl_Cliente(string nom, TipoSexo se, DateTime fe)
        {
            _nombre = nom;
            _fechaNacimiento = fe;
            _sexo = se;
        }
               
    }
}
