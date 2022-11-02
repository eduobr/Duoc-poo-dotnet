using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_EJERCICIO
{
    public enum TipoRaza
    {
        Labrador, Pastor, Beagle, Poddle
    }
    public enum TipoSexo
    {
        Macho, Hembra
    }
    public class Cl_Mascota
    {
        //campos
        private int _codigo;
        private string _nombre;
        private TipoRaza _raza;
        private int _edad;
        private DateTime _fechaInscripcion;
        private TipoSexo _sexo;
        //propiedades
        public TipoSexo Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public DateTime FechaInscripcion
        {
            get { return _fechaInscripcion; }
            set {
                DateTime hoy = DateTime.Now;
                TimeSpan intervalo = hoy - value;
                int dias = intervalo.Days;
                if (dias < 365)
                {
                    _fechaInscripcion = value;
                }
                else {
                    throw new Exception("fecha de inscripcion mayor al año");
                }
            }
        }
        public int Edad
        {
            get { return _edad; }
            set {
                if (value >= 1 && value <= 5)
                {
                    _edad = value;
                }
                else {
                    throw new Exception("edad debe estar entre 1 y 5");
                }
            }
        }
        public TipoRaza Raza
        {
            get { return _raza; }
            set { _raza = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set {
                if (value.Length >= 3)
                {
                    _nombre = value;
                }
                else {
                    throw new Exception("nombre debe tener minimo 3 caracteres");
                }
            }
        }
        public int Codigo
        {
            get { return _codigo; }
            set {
                if (value >= 1 && value <= 20)
                {
                    _codigo = value;
                }
                else {
                    throw new Exception("codigo debe estar entre 1 y 20");
                }
            }
        }

        public Cl_Mascota()
        {
            Init();
        }
        
        private void Init()
        {
            Codigo = 1;
            Nombre = "S/N";
            Raza = TipoRaza.Labrador;
            Edad = 1;
            FechaInscripcion = DateTime.Now;
            Sexo = TipoSexo.Macho;
        }
        public string Imprimir() {
            return
                string.Format("Cod:{0} Nombre:{1} Raza:{2} Edad:{3} Fecha:{4} Sexo:{5}",
                Codigo, Nombre, Raza, Edad, FechaInscripcion, Sexo);
        }
    }
}
