using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIBLIOTECA;
namespace CONTROLADOR
{
    public class DaoPaciente:IDaoPaciente
    {
        private static List<CL_PACIENTE> pacientes;

        public DaoPaciente()
        {
            if (pacientes == null)
            {
                pacientes = new List<CL_PACIENTE>();
            }
        }

        public bool Agregar(CL_PACIENTE paciente)
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
            foreach (CL_PACIENTE item in pacientes)
            {
                if (item.NumeroFicha==p)
                {
                    return true;
                }
            }
            return false;
        }

        public CL_PACIENTE Buscar(int numero_ficha)
        {
            foreach (CL_PACIENTE item in pacientes)
            {
                if (item.NumeroFicha == numero_ficha)
                {
                    return item;
                }
            }
            return null;
        }

        public List<CL_PACIENTE> Listar()
        {
            return pacientes;
        }

        public bool Actualizar(CL_PACIENTE nuevo_paciente)
        {
            foreach (CL_PACIENTE item in pacientes)
            {
                if (item.NumeroFicha == nuevo_paciente.NumeroFicha)
                {
                    pacientes.Remove(item);
                    pacientes.Add(nuevo_paciente);
                    return true;
                }
            }
            return false;
        }

        public bool Eliminar(int numero_ficha)
        {
            foreach (CL_PACIENTE item in pacientes)
            {
                if (item.NumeroFicha == numero_ficha)
                {
                    pacientes.Remove(item);
                    return true;
                }
            }
            return false;
        }
        //Metodos LinQ
        public DateTime MayorFechaAtencion() {
            return pacientes.Max(p => p.Fecha);
        }
        public DateTime MenorFechaAtencion() {
            return pacientes.Min(p => p.Fecha);
        }
        public int MayoresIsapre() {
            int mayores_isapre = pacientes
                .Where(p => p.Edad >= 18 && p.Salud == TipoSalud.Isapre)
                .Count();
            return mayores_isapre;
        }
        public int AdultosMenores13() {
            int am13 = pacientes
                .Where(p => p.Hora < 13 && p.GetType() == typeof(CL_ADULTO))
                .Count();
            return am13;
        }
        public double PromedioEdadNiños() {
            double pro = pacientes
                .Where(p => p.GetType() == typeof(CL_NINO))
                .Average(n => n.Edad);
            return pro;
        }

    }
}
