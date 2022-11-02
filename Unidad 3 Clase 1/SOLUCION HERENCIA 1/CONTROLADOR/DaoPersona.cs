using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIBLIOTECA;

namespace CONTROLADOR
{
    public class DaoPersona
    {
        private List<Cl_Persona> personas;
        public DaoPersona()
        {
            personas = new List<Cl_Persona>();
        }
        //metodos basicos C.R.U.D (Crate, Read, Update, Delete)
        public bool Agregar(Cl_Persona persona)
        {
            personas.Add(persona);
            return true;
        }

        public Cl_Persona Buscar(string nombre)
        {
            foreach (Cl_Persona item in personas)
            {
                if (item.Nombre.Equals(nombre))
                {
                    return item;
                }
            }
            return null;
        }

        public List<Cl_Persona> Listar()
        {
            return personas;
        }

        public bool Eliminar(string nombre)
        {
            foreach (Cl_Persona item in personas)
            {
                personas.Remove(item);
                return true;
            }
            return false;
        }

        public bool Actualizar(Cl_Persona nuevaPer)
        {
            foreach (Cl_Persona item in personas)
            {
                if (item.Nombre.Equals(nuevaPer.Nombre))
                {
                    personas.Remove(item);
                    personas.Add(nuevaPer);
                    return true;
                }
            }
            return false;
        }
    }
}
