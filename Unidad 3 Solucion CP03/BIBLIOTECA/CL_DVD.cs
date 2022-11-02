using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class CL_DVD:CL_PELICULA,IPelicula
    {
        public int CantidadM { get; set; }

        public CL_DVD():base()
        {
            Init();
        }

        private void Init()
        {
            CantidadM = 0;
        }

        public CL_DVD(string titulo,int anno,int censura,int cantidadM):base(titulo,anno,censura)
        {
            CantidadM = cantidadM;
        }


        public bool Actualizacion
        {
            get {
                int ano = DateTime.Now.Year;
                if (base.Anno - ano > 2)
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
            if (CantidadM < 120)
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
