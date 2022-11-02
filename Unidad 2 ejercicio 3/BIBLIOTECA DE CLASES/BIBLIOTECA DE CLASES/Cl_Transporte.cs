using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_DE_CLASES
{
    public enum MarcaCamion
    {
        Mercedez, Toyota, Renault
    }

    public enum TipoCaja 
    {
        Automatica,Manual
    }
    class Cl_Transporte
    {
        private string _patente;
        private MarcaCamion _marcaCamion;
        private string _nombreChofer;
        private int _taraMaxima;
        private bool _aclopado;
        private TipoCaja _tipoCaja;
        private string _ciudadOrigen;
        private string _ciudadDestino;

        public string CiudadDestino
        {
            get { return _ciudadDestino; }
            set { _ciudadDestino = value; }
        }
        

        public string CiudadOrigen
        {
            get { return _ciudadOrigen; }
            set { _ciudadOrigen = value; }
        }
        

        public TipoCaja TipoCaja
        {
            get { return _tipoCaja; }
            set { _tipoCaja = value; }
        }
        

        public bool Acoplado
        {
            get { return _aclopado; }
            set { _aclopado = value; }
        }


        public int TarifaMaxima
        {
            get { return _taraMaxima; }
            set { _taraMaxima = value; }
        }


        public string NombreChofer
        {
            get { return _nombreChofer; }
            set { _nombreChofer = value; }
        }


        public MarcaCamion MarcaCamion
        {
            get { return _marcaCamion; }
            set { _marcaCamion = value; }
        }


        public string Patente
        {
            get { return _patente; }
            set {
                string abc = "QWERTYUIOPASDFGHJKLÑZXCVBNM";
                for (int i = 0; i < 4; i++)
                {
                    string letra = value.Substring(i,1).ToUpper();
                }
                _patente = value;
            }
        }

    }
}
