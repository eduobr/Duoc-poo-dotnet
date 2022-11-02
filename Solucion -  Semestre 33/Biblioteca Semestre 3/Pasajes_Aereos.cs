using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Semestre_3
{
    public class Pasajes_Aereos
    {
        private int _precio;
        private string _nombrePasajero;
        private int _horaPasaje;
        private string _codigoPasaje;

        public string CodigoPasaje
        {
            get { return _codigoPasaje; }
            set { _codigoPasaje = value; }
        }



        public int HoraPasaje
        {
            get { return _horaPasaje; }
            set { _horaPasaje = value; }
        }


        public string NombrePasajero
        {
            get { return _nombrePasajero; }
            set { _nombrePasajero = value; }
        }


        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }


        public Pasajes_Aereos()
        {
            Init();
        }

        private void Init()
        {
            Precio = 23000;
            NombrePasajero = "Osama BINBAN";
            HoraPasaje = 8;
            CodigoPasaje = "987e198ue1";
        }
        public Pasajes_Aereos(int prs, string nbr, int hr, string cod)
        {
            Precio = prs;
            NombrePasajero = nbr;
            HoraPasaje = hr;
            CodigoPasaje = cod;
        }

        public string imprimir()
        {
            return string.Format("precio:{0}, nombre:{1}, hora pasaje:{2}, codigo:{3}",_precio,_nombrePasajero,_horaPasaje,_codigoPasaje);
        }
    }
}
