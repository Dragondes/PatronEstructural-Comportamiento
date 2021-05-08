using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patron_de_diseño_comportamiento
{
    interface IConexion
    {
        string Conectar();
        Boolean conexionEstablecida();
    }
}