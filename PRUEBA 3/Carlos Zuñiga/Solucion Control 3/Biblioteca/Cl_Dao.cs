using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class Cl_Dao:ICl_Dao
    {
        public static List<Cl_Buses> lista;

        public Cl_Dao()
        {
           if (lista != null)
	       {
		        lista = new List<Cl_Buses>();
	       }
        }


        public bool Agregar(Cl_Buses bus)
        {
            if (Existebus(bus.Patente) == false)
            {
                lista.Add(bus);
                return true;
            }
            return false;
        }

        private bool Existebus(string p)
        {
            foreach (Cl_Buses item in lista)
            {
                if (item.Patente == p)
                {
                    return true;
                }

            }
            return false;
        }
        public List<Cl_Buses> Listar()
        {
            return lista;
        }
        public int MayorPasaje()
        {
            int mp = lista.Max(p => p.PrecioTotal());
            return mp;
        }
        public int MenorPasaje()
        {
            int men = lista.Min(p => p.PrecioTotal());
            return men;

        }
        //public int CantidadSur()
       

		 
	}
        }
    
    

