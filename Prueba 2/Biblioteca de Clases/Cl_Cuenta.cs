using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca_de_Clases
{
    public enum TipoCuenta
    {
        Corriente, Vista, Ahorro
    }
    public class Cl_Cuenta
    {
        private TipoCuenta _cuenta;
        private DateTime _apertura;
        private string _identificador;
        private int _saldoInicial;
        private int _costoMantencion;
        private Cl_Cliente _cliente;

        public Cl_Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public int CostoMantencion
        {
            get
            {
                int valorUf = 23000;
                double uf = 0.01;
                int edad = _cliente.Edad;
                switch (TipoCuenta)
                {
                    case TipoCuenta.Corriente:
                        uf += 0.03;
                        break;
                    case TipoCuenta.Vista:
                        uf += 0.02;
                        break;
                    case TipoCuenta.Ahorro:
                        uf += 0.01;
                        break;
                }
                if (edad >= 18 && edad <= 35)
                {
                    uf +=0.03;
                }
                else if (edad >= 35 && edad <= 45)
                {
                    uf += 0.02;
                }
                else
                {
                    uf += 0.01;
                }
                _costoMantencion = (int)(valorUf *uf);
                return _costoMantencion;
            }

        }


        public int SaldoInicial
        {
            get { return _saldoInicial; }
            set {
                if (value > 0)
                {
                    _saldoInicial = value;
                }
                else
                {
                    throw new Exception("El saldo debe ser mayor a 0");
                }
                

            }
        }


        public string Identificador
        {
            get {
                string cta="CTA";
                string parte2 = "";
                switch (TipoCuenta)
                {
                    case TipoCuenta.Corriente:
                        parte2 = "CCC";
                        break;
                    case TipoCuenta.Vista:
                        parte2 = "VIS";
                        break;
                    case TipoCuenta.Ahorro:
                        parte2 = "AHO";
                        break;
                    default:
                        break;
                }
                string parte3 = _identificador.PadLeft(5, '0');
                return cta + "-" + parte2 + "-" + parte3; 
            }
        }


        public DateTime Apertura
        {
            get { return _apertura; }
            set {
                if (value>new DateTime(01,01,1980) && value<DateTime.Now)
                {
                    _apertura = value;
                }
                
            }
        }

        public TipoCuenta TipoCuenta
        {
            get { return _cuenta; }
            set { _cuenta = value; }
        }

        public Cl_Cuenta()
        {
            Init();
        }

        private void Init()
        {
            _cuenta = TipoCuenta.Corriente;
            _apertura = new DateTime(02, 02, 1981);
            _cliente = new Cl_Cliente();
            _saldoInicial = 0;
        }

        public Cl_Cuenta(TipoCuenta tc,DateTime fe,Cl_Cliente cli, int sal)
        {
            _cuenta = tc;
            _apertura = fe;
            _cliente = cli;
            _saldoInicial = sal;
        }
    }
}
