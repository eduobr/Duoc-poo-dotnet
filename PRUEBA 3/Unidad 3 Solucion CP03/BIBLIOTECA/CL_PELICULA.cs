using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class CL_PELICULA
    {
        public string Titulo { get; set; }
        public int Anno { get; set; }
        public int Censura { get; set; }

        public CL_PELICULA()
        {
            Init();
        }

        private void Init()
        {
            Titulo = string.Empty;
            Anno = 0;
            Censura = 18;
        }

        public CL_PELICULA(string titulo, int anno, int censura)
        {
            Titulo = titulo;
            Anno = anno;
            Censura = censura;
        }

        public string Imprimir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n Titulo:" + Titulo);
            sb.Append("\n Año:" + Anno);
            sb.Append("\n Censura:" + Censura);
            return sb.ToString();
        }
    }
}
