using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    public class CL_DIGITAL:CL_LIBRO,ILibro
    {
        public int Tamano { get; set; }

        public CL_DIGITAL():base()
        {
            Init();
        }

        private void Init()
        {
            Tamano = 0;
        }

        public CL_DIGITAL(string titulo,int anno,string autor,int tamano):base(titulo,anno,autor)
        {
            Tamano = tamano;
        }

        //Interface

        public bool Renovacion
        {
            get
            {
                int ano = DateTime.Now.Year;
                if ((ano - base.Anno) > 5)
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
            if (Tamano < 8)
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
