using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTBD
{
    class UsuariosN
    {

        public static int AgregarU(Usuarios pUsuarios)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into users (UserName, UserPassword, Paterno, Materno, Nombre,Ventas) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
               pUsuarios.UserName, pUsuarios.UserPassword, pUsuarios.Paterno, pUsuarios.Materno, pUsuarios.Nombre, pUsuarios.Ventas), Conexion.ObtenerConexion());


            //MySqlCommand comando = new MySqlCommand(string.Format("Insert into users (UserName, UserPasword, Paterno, Materno, Nombre, Ventas, Administrar, Reportes, Catalogos, Consultas, DeshacerVenta) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
            //    pUsuarios.UserName, pUsuarios.UserPassword, pUsuarios.Paterno, pUsuarios.Materno, pUsuarios.Nombre, pUsuarios.Ventas, pUsuarios.Administrar, pUsuarios.Reporte, pUsuarios.Catalogo, pUsuarios.Consulta, pUsuarios.DeshacerVenta), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

    }
}
