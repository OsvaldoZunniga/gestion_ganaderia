using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace Datos
{
    public class Conexion
    {
        public NpgsqlConnection conexion;
        public NpgsqlConnection ConexionBD()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "MISTER...";
            string badeDatos = "gestion_ganadera";

            string cadenaConexion = "Server=" + servidor + ";" +
                                    "Port=" + puerto + ";" +
                                    "User Id=" + usuario + ";" +
                                    "Password=" + clave + ";" +
                                    "Database=" + badeDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
            conexion.Open();

            return conexion;
        }
    }
}
