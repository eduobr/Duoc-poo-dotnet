using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    interface IPelicula
    {
        bool Actualizacion { get;}
        bool Duplicado();
    }
}
