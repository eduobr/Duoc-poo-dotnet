using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class CL_BUS
    {
        public string Patente { get; set; }
        public string Chofer { get; set; }
        public DateTime Fecha { get; set; }
        public int Hora { get; set; }
        public int Precio { get; set; }

        public CL_BUS()
        {
            Init();
        }

        private void Init()
        {
            Patente = string.Empty; Chofer = string.Empty; Fecha = DateTime.Now; Hora = 0; Precio = 0;     
        }
        public CL_BUS(string patente,string chofer,DateTime fecha,int hora,int precio)
        {
            Patente = patente; Chofer = chofer; Fecha = fecha; Hora = hora; Precio = precio;     
        }
        public string Imprimir() {
            return string.Format("\n Patente:{0} \n Chofer:{1} \n Fecha:{2} \n Hora:{3}", Patente, Chofer, Fecha, Hora);
        }
    }
}
