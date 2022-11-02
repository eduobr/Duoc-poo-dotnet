using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca_Modelo;

namespace Biblioteca_Controlador
{
    public class DaoPersona
    {
        private Cl_Persona[] personas;
        private int Pos = 0;

        public DaoPersona(int tamaño_arreglo)
        {
            personas = new Cl_Persona[tamaño_arreglo];
        }
        //metodos
        public bool Agregar(Cl_Persona persona)
        {
            if (Pos < personas.Length)
            {
                personas[Pos] = persona;
                Pos++;
                return true;

            }
            else
            {
                return false;
            }
            
        }

        public bool ExistePersona(string rut)
        {
            foreach(Cl_Persona item in personas){
                if (item!=null)
                {
                    if (item.Rut.Equals(rut))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Eliminar(string rut)
        {
            Cl_Persona[] persoTemp = new Cl_Persona[personas.Length];
            int posTemp = 0;
            foreach(Cl_Persona item in personas){
                if (item!=null)
                {
                    if (!item.Rut.Equals(rut))
                    {
                        persoTemp[posTemp] = item;
                        posTemp++;
                    }
                }
            }
            personas = persoTemp;
            Pos = posTemp;
            return true;
        }

        public Cl_Persona[] Listado()
        {
            return personas;
        }

    }
}
