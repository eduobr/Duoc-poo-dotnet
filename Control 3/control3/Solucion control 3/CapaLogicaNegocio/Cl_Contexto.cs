using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDALC;

namespace CapaLogicaNegocio
{
    public class Cl_Contexto
    {
        private CONDORESEntities conn;

        public CONDORESEntities entidades
        {
            get
            {
                if (conn == null)
                {
                    conn = new CONDORESEntities();
                }
                return conn;
            }

        }
    }
}
