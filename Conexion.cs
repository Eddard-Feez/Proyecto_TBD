using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ProyectoTBD
{
    public class Conexion
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=ventas; Uid=eddard; pwd=mysql;");

            conectar.Open();
            return conectar;
        }

    }
}
