using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class CL_LIBRO
    {

        public string Titulo { get; set; }
        public int Anno { get; set; }
        public string NombreAutor { get; set; }

        public CL_LIBRO()
        {
            Init();
        }

        private void Init()
        {
            Titulo = string.Empty; Anno = 0; NombreAutor = string.Empty;
        }

        public CL_LIBRO(string titulo,int anno,string autor)
        {
            Titulo = titulo; Anno = anno; NombreAutor = autor;
        }

        public string Imprimir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n Titulo:"+Titulo);
            sb.Append("\n Año:"+Anno);
            sb.Append("\n Autor:" + NombreAutor);
            return sb.ToString();
        }
    }
}
