using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public enum TipoSalud {  Isapre,Fonasa }
    public abstract class CL_PACIENTE
    {
        private int _numeroFicha;
        private string _nombre;
        private int _edad;
        private int _costo;
        private TipoSalud _salud;
        private DateTime _fecha;
        private int _hora;

        public int Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }        
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }        
        public TipoSalud Salud
        {
            get { return _salud; }
            set { _salud = value; }
        }       
        public int Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }        
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }        
        public int NumeroFicha
        {
            get { return _numeroFicha; }
            set { _numeroFicha = value; }
        }

        public CL_PACIENTE()
        {
            Init();
        }

        private void Init()
        {
            NumeroFicha = 1; Nombre = "SN"; Edad = 1; Costo = 0;
            Salud = TipoSalud.Fonasa; Fecha = DateTime.Now; Hora = 10;
        }
        public CL_PACIENTE(int nf,string nom,int ed,int cost,
            TipoSalud ts,DateTime fec,int hor)
        {
            NumeroFicha = nf; Nombre = nom; Edad = ed; Costo = cost;
            Salud = ts; Fecha = fec; Hora = hor;
        }
        //metodos customer
        public string NombreDoctor() {
            if (Hora>=10 && Hora<=12)
            {
                return "Dr. Daniel Gomez";
            }
            if (Hora>=13  && Hora<=16)
            {
                return "Dr. Andres Parra";
            }
            if (Hora >= 17 && Hora <= 20) {
                return "Dra. Barbara Herrera";
            }
            return "Sin Doctor";
        }
        public abstract int ValorAtencion();


        
    }
}
