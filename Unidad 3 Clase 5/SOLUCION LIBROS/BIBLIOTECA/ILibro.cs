using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    interface ILibro
    {
        bool Renovacion { get; } //propiedad
        bool Reproduccion(); //metodo
    }
}
