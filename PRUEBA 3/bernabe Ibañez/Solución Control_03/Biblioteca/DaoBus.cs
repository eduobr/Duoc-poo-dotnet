using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
   
    public class DaoBus
    {
        private static List<Bus> Coleccion;

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        

        public DaoBus()
        {
            if (Coleccion == null)
            {
                Coleccion = new List<Bus>();
            }
        }
        public bool Agregar(Bus b)
        {
            if (!Buscar(b.Patente))
            {
                Coleccion.Add(b);
                return true;
            }
            return false;
        }
        public bool Buscar(string pk)
        {
            foreach (Bus item in Coleccion)
            {
                if (item.Patente == pk)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Bus> Listar()
        {

            return Coleccion;
        }
        
    }
}
