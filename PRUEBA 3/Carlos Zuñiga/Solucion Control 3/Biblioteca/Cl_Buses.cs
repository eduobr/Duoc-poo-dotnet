using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class Cl_Buses
    {
        private string _patente;
        private int _precio;
        private string _nombreChofer;
        private DateTime _fecha;

        

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        

        public string NombreChofer
        {
            get { return _nombreChofer; }
            set { _nombreChofer = value; }
        }
        

        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        

        public string Patente
        {
            get { return _patente; }
            set { _patente = value; }
        }
        public Cl_Buses()
        {
            Init();
        }
        public Cl_Buses(string pa, int pre, string nom, DateTime fe)
        {
            Patente = pa; Precio = pre; NombreChofer = nom; Fecha = fe;
        }

        private void Init()
        {
            Patente = string.Empty;
            Precio = 0;
            NombreChofer = string.Empty;
            Fecha = DateTime.Now;
        }

        public abstract int PrecioTotal();
        public abstract int TiempoDemora();
    }
}
