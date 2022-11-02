using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_MODELO
{
    public class Cl_Album
    {
        public string Nombre { get; set; } // prop tab sale altok        
        public DateTime FechaPublicacion { get; set; }

        private int _precio;

        public int Precio
        {
            get { return _precio; }
            set
            {
                if (value>=5000 && value <=50000 )
                {
                    _precio = value;
                }
                else
                {
                    throw new Exception("valor entre 5000 y 50000");
                }
                 }
        }
        public Cl_Interprete Interprete { get; set; }
        public string[] Canciones{ get; set; }
        private int Pos = 0;
        public Cl_Album(int temas) // ctor tab sale el constructor
        {
            Nombre = string.Empty;
            Precio = 5000;
            Canciones = new string[temas];
            Interprete = new Cl_Interprete();
        }
        // custom
        public bool AgregarTema(string cancion) {
            if (Pos<Canciones.Length)
            {
                Canciones[Pos] = cancion;
                Pos++;
                return true;
            }
            else
            {
                throw new Exception("Album lleno");
            }
        }
        public string ListaDeTemas() {
            string temas = "";
            foreach (string item in Canciones) // es string porke el arreglo es string
            {
                temas = temas + " " + item;
            }
            return temas;
        }
        public string Imprimir() {
            return string.Format("Nombre:{0} Fecha Publicacion:{1} Precio:{2} Interprete:{3}", Nombre, FechaPublicacion, Precio, Interprete.Nombre);
        }
    }
}
