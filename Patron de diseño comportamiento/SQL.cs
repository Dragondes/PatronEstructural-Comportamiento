using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patron_de_diseño_comportamiento
{
    class SQL : IConexion
    {
        Boolean conexionCorrecta = false;

        public string Conectar()
        {
            conexionCorrecta = false;
            return "Conectando con SQL";
        }
        public Boolean conexionEstablecida()
        {
            return conexionCorrecta;
        }
    }
}