using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class Cl_Empleado:Cl_Persona
    {
        private DateTime _fechaIngreso;
        private string _cargo;
        private int _salario;

        public int Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }        
        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }        
        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }

        public Cl_Empleado():base()
        {
            Init();
        }

        private void Init()
        {
            FechaIngreso = DateTime.Now; Cargo = "Administrativo";
            Salario = 500000;
        }
        public Cl_Empleado(string nom,string ape,int ed,
            DateTime fi,string car,int sal):base(nom,ape,ed)
        {
            FechaIngreso = fi; Cargo = car;Salario = sal;
        }
        public string Imprimir() {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n Nombre: " + Nombre);
            sb.Append("\n Apellido: " + Apellido);
            sb.Append("\n Edad: " + Edad);
            sb.Append("\n Fecha Ingreso:" + FechaIngreso);
            sb.Append("\n Cargo:" + Cargo);
            sb.Append("\n Salario:" + Salario);
            return sb.ToString();
        }
    }
}
