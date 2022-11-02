using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_CLASES
{
    public enum TipoCarga
    {
        Nacional, Internacional
    }
    public enum TipoDestino
    {
        Norte, Sur, Centro
    }
    public class Cl_Carga
    {
        private TipoCarga _tipo;
        private string _identificador;
        private DateTime _fechaIngreso;
        private DateTime _fechaEntrega;
        private string _descripcion;
        private int _valor;
        private int _peso;
        private Cl_Transporte _camion;
        private TipoDestino _destino;
        private int _impuesto;

        public int Impuesto
        {
            get {
                GenerarImpuesto();
                return _impuesto; 
            }          
        }

        private void GenerarImpuesto()
        {
            int imp = 0;
            switch (Destino)
            {
                case TipoDestino.Norte:
                    imp = (int)(Valor * 0.03);
                    break;
                case TipoDestino.Sur:
                    imp = (int)(Valor * 0.05);
                    break;
                case TipoDestino.Centro:
                    imp = (int)(Valor * 0.02);
                    break;
                default:
                    break;
            }
            _impuesto = imp;
        }
        public TipoDestino Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }
        public Cl_Transporte Camion
        {
            get { return _camion; }
            set { _camion = value; }
        }
        public int Peso
        {
            get { return _peso; }
            set {
                if (value >= 1 && value <= 20)
                {
                    _peso = value;
                }
                else {
                    throw new Exception("peso entre 1 y 20");
                }
                
            }
        }
        public int Valor
        {
            get { return _valor; }
            set
            {
                if (value >= 100 && value <= 30000)
                {
                    _valor = value;
                }
                else
                {
                    throw new Exception("valor entre 100 y 30000");
                }

            }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                if (value.Trim().Length >= 5)
                {
                    _descripcion = value;
                }
                else
                {
                    throw new Exception("descripcion minimo 5 caracteres");
                }

            }
        }
        public DateTime FechaEntrega
        {
            get { return _fechaEntrega; }
            set
            {
                if (value >= FechaIngreso)
                {
                    _fechaEntrega = value;
                }
                else
                {
                    throw new Exception("fecha de entrega incorrecta");
                }
            }
        }
        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set
            {
                if (value <= DateTime.Now)
                {
                    _fechaIngreso = value;
                }
                else
                {
                    throw new Exception("fecha de ingreso incorrecta");
                }
            }
        }
        public string Identificador
        {
            get
            {
                return GenerarIdentificador();
            }
            set
            {
                _identificador = value;
            }
        }

        private string GenerarIdentificador()
        {
            string parte1 = "TRN";
            string parte2 = "";
            switch (Tipo)
            {
                case TipoCarga.Nacional:
                    parte2 = "NAC";
                    break;
                case TipoCarga.Internacional:
                    parte2 = "INT";
                    break;
                default:
                    break;
            }
            string parte3 = _identificador.PadLeft(5, '0'); //1  - 00001
            return parte1 + "-" + parte2 + "-" + parte3;
        }
        public TipoCarga Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public Cl_Carga()
        {
            Init();
        }
        public Cl_Carga(string Id,TipoCarga tc,DateTime fi,DateTime fe,string desc,int val,int pes,
            Cl_Transporte cam,TipoDestino destino)
        {
            Tipo = tc; FechaIngreso = fi; FechaEntrega = fe; Descripcion = desc; Valor = val;
            Peso = pes; Camion = cam; Destino = destino;
            Identificador = Id;
            GenerarImpuesto();
        }
        private void Init()
        {
            Tipo = TipoCarga.Nacional; FechaIngreso = DateTime.Now; FechaEntrega = DateTime.Now;
            Descripcion = "sin descripcion"; Valor = 100; Peso = 1; Camion = new Cl_Transporte();
            Destino = TipoDestino.Centro; Identificador = "1";
            GenerarImpuesto();
        }
        public int ValorCarga(int valorUF) {
            return (Valor + Impuesto) * valorUF;
        }
        public int ValorTransportado(int valorUF) {
            int valor = (int)( (Valor + Impuesto) * 0.05 );
            switch (Destino)
            {
                case TipoDestino.Norte:
                    valor += (int)(valor * 0.04);
                    break;
                case TipoDestino.Sur:
                    valor += (int)(valor * 0.06);
                    break;
                case TipoDestino.Centro:
                    valor += (int)(valor * 0.02);
                    break;
                default:
                    break;
            }
            return valor * valorUF;
        }
    }
}
