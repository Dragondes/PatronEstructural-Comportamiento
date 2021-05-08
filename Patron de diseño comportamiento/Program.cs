using System;

namespace Patron_de_diseño_comportamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionarConexiones conexion = new GestionarConexiones();
            conexion.ConexionesSQL();
            Console.WriteLine(conexion.Conectar());
            if (!conexion.conexionCorrecta())
                Console.WriteLine("Error al conectar con el servidor");
                conexion.ConexionesOracle();
                Console.WriteLine(conexion.Conectar());
            Console.ReadLine();
        }
    }
}
