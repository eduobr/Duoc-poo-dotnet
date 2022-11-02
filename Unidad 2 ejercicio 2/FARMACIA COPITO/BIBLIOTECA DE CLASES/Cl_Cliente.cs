using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_DE_CLASES
{
    public enum TipoCliente { 
        Fonasa,Isapre,Independiente
    }
    public class Cl_Cliente
    {
        private int _numero;
        private string _nombre;
        private DateTime _fechaNacimiento;
        private TipoCliente _tipo;
        private int _credito;

        public int Credito
        {
            get { return _credito; }            
        }
        public void CalcularCredito() {
            int valor = 80000;
            switch (Tipo)
            {
                case TipoCliente.Fonasa:
                    valor+= (int)(valor * 0.07);
                    break;
                case TipoCliente.Isapre:
                    valor += (int)(valor * 0.1);
                    break;
                case TipoCliente.Independiente:
                    int edad = SaberEdad();
                    if (edad > 20 && edad <= 50) {
                        valor += (int)(valor * 0.05);
                    }
                    if (edad > 50) {
                        valor += (int)(valor * 0.03);
                    }
                    break;
                default:
                    break;
            }
            _credito = valor;
        }
        private int SaberEdad()
        {
            DateTime hoy = DateTime.Now;
            TimeSpan intervalo = hoy - FechaNacimiento;
            return intervalo.Days / 365;
        }
        public TipoCliente Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }       
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set {
                if (value >= new DateTime(1930, 1, 1) && value <= DateTime.Now)
                {
                    _fechaNacimiento = value;
                }
                else {
                    throw new Exception("fecha entre 1/1/1930 y " +
                    DateTime.Now.ToString("dd/MM/yyyy"));
                }
            }
        }        
        public string Nombre
        {
            get { return _nombre; }
            set {
                if (value.Length >= 5)
                {
                    _nombre = value;
                }
                else {
                    throw
                    new Exception("nombre largo minimo 5 caracteres");
                }
            }
        }        
        public int Numero
        {
            get { return _numero; }
            set {
                if (value >= 0)
                {
                    _numero = value;
                }
                else {
                    throw new Exception("numero mayor a 0");
                }
            }
        }
        public int Compra(int valorCompra) { 
            if(_credito>=valorCompra){
                _credito =_credito- valorCompra;
                return _credito;
            }
            throw new Exception("saldo insuficiente " + _credito);
        }

        public Cl_Cliente()
        {
            Init();
        }
        public Cl_Cliente(int num,string nom,DateTime fn,
            TipoCliente tc)
        {
            Numero = num; Nombre = nom; FechaNacimiento = fn;
            Tipo = tc; CalcularCredito();
        }
        private void Init()
        {
            Numero = 0; Nombre = "sin nombre";
            FechaNacimiento = new DateTime(2011, 1, 1);
            Tipo = TipoCliente.Fonasa;
            CalcularCredito();
        }

    }
}
