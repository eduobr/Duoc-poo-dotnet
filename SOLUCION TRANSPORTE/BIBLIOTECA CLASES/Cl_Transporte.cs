using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_CLASES
{
    public enum MarcaCamion {
        Mercedes, Toyota, Renault, Fiat
    }
    public enum TipoCaja { 
        Automatica, Manual
    }
    public class Cl_Transporte
    {
        //campos
        private string _patente;
        private MarcaCamion _marca;
        private string _chofer;
        private int _tara;
        private bool _acoplado;
        private TipoCaja _caja;
        private string _ciudadOrigen;
        private string _ciudadDestino;
        //propiedades
        public string CiudadDestino
        {
            get { return _ciudadDestino; }
            set {
                if (value.Trim().Length >= 5)
                {
                    _ciudadDestino = value;
                }
                else
                {
                    throw new Exception("ciudad destino minimo 5 caracteres");
                }
             }
        }       
        public string CiudadOrigen
        {
            get { return _ciudadOrigen; }
            set {
                if (value.Trim().Length >= 5)
                {
                    _ciudadOrigen = value;
                }
                else {
                    throw new Exception("ciudad de origen minimo 5 caracteres");
                }
            }
        }        
        public TipoCaja Caja
        {
            get { return _caja; }
            set { _caja = value; }
        }        
        public bool Acoplado
        {
            get { return _acoplado; }
            set { _acoplado = value; }
        }       
        public int Tara
        {
            get { return _tara; }
            set {
                if (value >= 1 && value <= 20)
                {
                    _tara = value;
                }
                else {
                    throw new Exception("tara entre 1 y 20");
                }
            }
        }        
        public string Chofer
        {
            get { return _chofer; }
            set {
                if (value.Trim().Length >= 10 &&
                    value.Trim().Split(' ').Length >= 2)
                {
                    _chofer = value;
                }
                else {
                    throw new Exception("nombre chofer incorrecto");
                }
            }
        }        
        public MarcaCamion Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }       
        public string Patente
        {
            get { return _patente; }
            set {
                if (validaPatente(value))
                {
                    _patente = value;
                }
                else {
                    throw new Exception("patente incorrecta");
                }
            }
        }
        private bool validaPatente(string value)
        {
            if (value.Trim().Length == 6)
            {
                bool resp = true;
                string abc = "qwertyuiopñlkjhgfdsazxcvbnm".ToUpper();
                for (int i = 0; i < 4; i++)
                {
                    string letra = value.Substring(i, 1).ToUpper();
                    int pos = abc.IndexOf(letra);
                    if (pos<0)
                    {
                        resp = false;
                    }
                }
                int num = 0;
                if (resp && int.TryParse(value.Substring(4, 2), out num))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }
        //constructores
        public Cl_Transporte()
        {
            Init();
        }
        public Cl_Transporte(string pat,MarcaCamion mc, string  cho,int tar,
            bool acop,TipoCaja tc,string cdes,string cori)
        {
            Patente = pat;
            Marca = mc; Chofer = cho;
            Tara = tar; Acoplado = acop; Caja = tc;
            CiudadDestino = cdes; CiudadOrigen = cori;

        }
        private void Init()
        {
            Patente = "AAAA99";
            Marca = MarcaCamion.Fiat; Chofer = "sin chofer registrado";
            Tara = 1; Acoplado = false; Caja = TipoCaja.Automatica;
            CiudadDestino = "sin ciudad"; CiudadOrigen= "sin Ciudad";
        }

    }
}
