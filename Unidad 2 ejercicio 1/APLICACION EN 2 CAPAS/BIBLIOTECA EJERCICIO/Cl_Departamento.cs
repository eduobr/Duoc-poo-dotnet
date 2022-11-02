using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_EJERCICIO
{
    public enum TipoHabitaciones { 
        Doble,Simple,High
    }
    public class Cl_Departamento
    {
        private int _numero;
        private string _direccion;
        private string _fono;
        private TipoHabitaciones _habitaciones;
        private int _baños;
        private DateTime _fechaEntrega;
        private int _valor;

        public int Valor
        {
            get { return _valor; }
            set {
                if (value >= 780 && value <= 3400)
                {
                    _valor = value;
                }
                else {
                    throw new Exception("valor debe estar entre 780 y 3400 UF");
                }
            }
        }
        public DateTime FechaEntrega
        {
            get { return _fechaEntrega; }
            set {
                DateTime hoy = DateTime.Now;
                if (value <= hoy)
                {
                    _fechaEntrega = value;
                }
                else {
                    throw new Exception("fecha no debe ser mayor a la fecha actual");
                }
            }
        }
        public int Baños
        {
            get { return _baños; }
            set {
                if (value >= 1 && value <= 3)
                {
                    _baños = value;
                }
                else {
                    throw new Exception("numero de baños entre 1 y 3");
                }
            }
        }
        public TipoHabitaciones Habitaciones
        {
            get { return _habitaciones; }
            set { _habitaciones = value; }
        }
        public string Fono
        {
            get { return _fono; }
            set {
                if (value.Length == 8)
                {
                    _fono = value;
                }
                else {
                    throw new Exception("fono de largo 8 caracteres");
                }
            }
        }
        public string Direccion
        {
            get { return _direccion; }
            set {
                int palabras = value.Split(' ').Length;
                if (palabras >= 2)
                {
                    _direccion = value;
                }
                else {
                    throw new Exception("debe tener minimo 2 palabras");
                }
            }
        }
        public int Numero
        {
            get { return _numero; }
            set {
                if (value >= 10 && value <= 74)
                {
                    _numero = value;
                }
                else {
                    throw new Exception("numero solo entre 10 y 74");
                }
            }
        }

        public Cl_Departamento()
        {
            Init();
        }

        private void Init()
        {
            Numero = 10;
            Direccion = "sin direccion";
            Fono = "88888888";
            Habitaciones = TipoHabitaciones.Simple;
            Baños = 1;
            FechaEntrega = DateTime.Now;
            Valor = 780;
        }

        public string Imprimir() {
            return
                string.Format("Num:{0} Direc:{1} Fono:{2} Habit:{3} Baños:{4} Fecha:{5} Valor:{6}",
                Numero,Direccion,Fono,Habitaciones,Baños,FechaEntrega,Valor);
        }

        public int Pesos(int valorUF) {
            return valorUF * Valor;
        }
    }
}
