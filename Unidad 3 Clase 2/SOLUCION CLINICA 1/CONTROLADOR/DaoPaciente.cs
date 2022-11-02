using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIBLIOTECA;

namespace CONTROLADOR
{
    class DaoPaciente:IDaoPaciente
    {
        private List<Cl_Paciente> pacientes;
        public DaoPaciente()
        {
            pacientes = new List<Cl_Paciente>();
        }

        public bool Agregar(Cl_Paciente paciente)
        {
            if (ExistePaciente(paciente.NumeroFicha)==true)
            {
                return false;
            }
            pacientes.Add(paciente);
            return true;
        }

        private bool ExistePaciente(int p)
        {
            foreach (Cl_Paciente item in pacientes)
            {
                if (item.NumeroFicha==p)
                {
                    return true;
                }
            }
            return false;
        }

        public Cl_Paciente Buscar(int numero_ficha)
        {
            throw new NotImplementedException();
        }

        public List<Cl_Paciente> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Actualizar(Cl_Paciente nuevo_paciente)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int numero_ficha)
        {
            throw new NotImplementedException();
        }
    }
}
