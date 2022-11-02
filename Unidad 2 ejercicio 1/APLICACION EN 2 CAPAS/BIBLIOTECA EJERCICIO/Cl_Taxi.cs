using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_EJERCICIO
{
    public enum TipoModelo { 
        Station,Sedan,City
    }
    public enum TipoMarca { 
        Chevrolet, Suzuki,Nissan,Toyota
    }
    public enum TipoCiudad { 
        Santiago, Valparaiso, Chillan, Los_Angeles
    }
    public class Cl_Taxi
    {
        //campos
        private string _patente;
        private TipoModelo _modelo;
        private TipoMarca _marca;
        private int _puertas;
        private int _valorKM;
        private TipoCiudad _ciudad;
        private DateTime _fechaRegistro;
        //propiedades
        public DateTime FechaRegistro
        {
            get { return _fechaRegistro; }
            set {
                if (value<DateTime.Now)
                {
                    _fechaRegistro = value;
                }
                else
                {
                    throw new Exception("fecha debe ser menor a la fecha actual");
                }                
            }
        }        
        public TipoCiudad Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }       
        public int ValorKM
        {
            get { return _valorKM; }
            set {
                if (value >= 250 && value <= 380)
                {
                    _valorKM = value;
                }
                else {
                    throw new Exception("valor km entre 250 y 380");
                }
            }
        }
        public int Puertas
        {
            get { return _puertas; }
            set {
                if (value >= 1 && value <= 5)
                {
                    _puertas = value;
                }
                else {
                    throw new Exception("entre 1 a 5 puertas");
                }
            }
        }       
        public TipoMarca Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }     
        public TipoModelo Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }     
        public string Patente
        {
            get { return _patente; }
            set {
                string abc = "QWERTYUIOPÑLKJHGFDSAZXCVBNM";
                bool resp = true;
                for (int i = 0; i < 4; i++)
                {
                    string letra = value.Substring(i, 1).ToUpper();
                    int pos = abc.IndexOf(letra);
                    if (pos<0)
                    {
                        resp = false;
                    }
                }
                int x;
                if (resp && int.TryParse(value.Substring(4, 2), out x))
                {
                    _patente = value;
                }
                else {
                    throw new Exception("patente incorrecta");
                }
            }
        }
        //constructor   ctor
        public Cl_Taxi()
        {
            Init();
        }

        private void Init()
        {
            Patente = "ABCD78";
            Modelo = TipoModelo.Sedan;
            Marca = TipoMarca.Nissan;
            Puertas = 4;
            ValorKM = 300;
            Ciudad = TipoCiudad.Santiago;
            FechaRegistro = new DateTime(2010, 01, 23);
        }
        public string Imprimir() {
            return
            string.Format("Patente:{0} Marca:{1} Modelo:{2} Puertas:{3} Valor Km:{4} Ciudad:{5} " +
            "Fecha:{6}", Patente, Marca, Modelo, Puertas, ValorKM, Ciudad, FechaRegistro);
        }
    }
}
