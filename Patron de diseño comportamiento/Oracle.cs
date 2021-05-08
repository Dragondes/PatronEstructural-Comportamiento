using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patron_de_diseño_comportamiento
{
    class Oracle : IConexion
    {
        Boolean conexionCorrecta = false;

        public string Conectar()
        {
            conexionCorrecta = true;
            return "Conectando con ORACLE";
        }
        public Boolean conexionEstablecida()
        {
            return conexionCorrecta;
        }
    }
}