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
        bool Agregar(Cl_Paciente paciente); //C
        Cl_Paciente Buscar(int numero_ficha);//R
        List<Cl_Paciente> Listar();//R
        bool Actualizar(Cl_Paciente nuevo_paciente);//U
        bool Eliminar(int numero_ficha);//D
    }
}
