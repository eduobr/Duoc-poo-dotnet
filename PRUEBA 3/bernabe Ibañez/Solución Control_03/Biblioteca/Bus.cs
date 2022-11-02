using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public enum TipoBus
	{
	         Seleccione,Internacional,Urbano
	}
    public class Bus
    {
        private TipoBus _tbus;

        public TipoBus TBus
        {
            get { return _tbus; }
            set { _tbus = value; }
        }
        
        private string _patente;
        private int _precio;
        private string _nomChofer;
        private DateTime _fhViaje;

        public DateTime FhViaje
        {
            get { return _fhViaje; }
            set { _fhViaje = value; }
        }


        public string NomChofer
        {
            get { return _nomChofer; }
            set { _nomChofer = value; }
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

        public Bus()
        {
            Init();
        }
        public void Init()
        {
            _patente = "PJ2132";
            _precio = 4000;
            _nomChofer = "Juan constanzo";
            _fhViaje = DateTime.Now;
            _tbus = TipoBus.Internacional;
        }
        public Bus(string pa, int pre, string nocho, DateTime feho,TipoBus tb)
        {
            _patente = pa;
            _precio = pre;
            _nomChofer = nocho;
            _fhViaje = feho;
            _tbus = tb;
        }
       

    }
}
