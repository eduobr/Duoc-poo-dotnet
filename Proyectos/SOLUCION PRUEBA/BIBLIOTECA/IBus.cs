using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA
{
    interface IBus
    {
        int PrecioTotal();
        int TiempoDemora { get; }
    }
}
