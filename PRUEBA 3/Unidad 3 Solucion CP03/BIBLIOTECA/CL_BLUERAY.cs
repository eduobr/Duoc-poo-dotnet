using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class CL_BLUERAY:CL_PELICULA,IPelicula
    {
        public int CantidadC { get; set; }

        public CL_BLUERAY():base()
        {
            Init();
        }

        private void Init()
        {
            CantidadC = 0;
        }

        public CL_BLUERAY(string titulo,int anno,int censura,int cantidadC):base(titulo,anno,censura)
        {
            CantidadC = cantidadC;
        }



        public bool Actualizacion
        {
            get {
                int ano = DateTime.Now.Year;
                if (base.Anno - ano > 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Duplicado()
        {
            if (CantidadC < 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
