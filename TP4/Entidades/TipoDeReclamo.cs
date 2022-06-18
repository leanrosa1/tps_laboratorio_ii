using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoDeReclamo
    {
        [Description("Poda de árbol")]
        PodaDeArbol = 0,

        [Description("Alumbrado público")]
        AlumbradoPublico = 1,

        [Description("Ruidos molestos")]
        RuidosMolestos = 2,

        [Description("Otros")]
        Otro = 3
    }
}
