using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patron_de_diseño_comportamiento
{
    class GestionarConexiones
    {
        private IConexion conexion;
        public void ConexionesOracle()
        {
            this.conexion = new Oracle();
        }
        
        public void ConexionesSQL()
        {
            this.conexion = new SQL();
        }
        public string Conectar()
        {
            return this.conexion.Conectar();
        }
        public Boolean conexionCorrecta()
        {
            return this.conexion.conexionEstablecida();
        }
    }
}