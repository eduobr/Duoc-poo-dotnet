using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIBLIOTECA;
namespace CONTROLADOR
{
    interface IDaoPaciente
    {
        //metodos C.R.U.D
        bool Agregar(CL_PACIENTE paciente);// C - Crear
        CL_PACIENTE Buscar(int numero_ficha); // R - buscar
        List<CL_PACIENTE> Listar(); // R -listado
        bool Actualizar(CL_PACIENTE nuevo_paciente); // U- update
        bool Eliminar(int numero_ficha);// D -delete
    }
}
