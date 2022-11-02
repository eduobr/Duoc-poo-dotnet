using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class CL_IMPRESO:CL_LIBRO,ILibro
    {
        public int CantidadPaginas { get; set; }

        public CL_IMPRESO():base()
        {
            Init();
        }

        private void Init()
        {
            CantidadPaginas = 0;
        }

        public CL_IMPRESO(string titulo,int anno,string autor,int cantidadP):base(titulo,anno,autor)
        {
            CantidadPaginas = cantidadP;
        }

        //Interface

        public bool Renovacion
        {
            get {
                int ano = DateTime.Now.Year;
                if ((ano - base.Anno) > 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
            }
        }

        public bool Reproduccion()
        {
            if (CantidadPaginas < 500)
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
