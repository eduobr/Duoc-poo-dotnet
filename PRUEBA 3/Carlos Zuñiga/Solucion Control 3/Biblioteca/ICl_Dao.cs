using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    interface ICl_Dao
    {
        bool Agregar(Cl_Buses bus);
        List<Cl_Buses> Listar();
    }
}
