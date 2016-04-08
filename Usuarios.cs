using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTBD
{
    public class Usuarios
    {

        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }

        public bool Ventas { get; set; }
        public bool Administrar { get; set; }
        public bool Reportes { get; set; }
        public bool Catalogos { get; set; }
        public bool Consultas { get; set; }
        public bool DeshacerVenta { get; set; }
        //public Boolean Administrar { get; set; }
        //public Boolean Reporte { get; set; }
        //public Boolean Catalogo { get; set; }
        //public Boolean Consulta { get; set; }
        //public Boolean DeshacerVenta { get; set; }

        public Usuarios() { }

        //public Usuarios(string pUserName, string pUserPassword, string pNombre, string pPaterno, string pMaterno, Boolean pVentas, Boolean pAdministrar, Boolean pReporte, Boolean pCatalogo, Boolean pConsulta, Boolean pDeshacerVenta)
        public Usuarios(string pUserName, string pUserPassword, string pNombre, string pPaterno, string pMaterno, bool pVentas, bool pAdministrar, bool pReportes, bool pCatalogos, bool pConsultas, bool pDeshacerVenta)

        {
            this.UserName = pUserName;
            this.UserPassword = pUserPassword;
            this.Nombre = pNombre;
            this.Paterno = pPaterno;
            this.Materno = pMaterno;
            this.Ventas = pVentas;
            this.Administrar = pAdministrar;
            this.Reportes = pReportes;
            this.Catalogos = pCatalogos;
            this.Consultas = pConsultas;
            this.DeshacerVenta = pDeshacerVenta;

        }

        public static int AgregarU(Usuarios pUsuarios)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into users (user_name, user_password, paterno, materno, nombre,ventas,administrar,reportes,catalogos,consultas,deshacer_venta) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
               pUsuarios.UserName, pUsuarios.UserPassword, pUsuarios.Paterno, pUsuarios.Materno, pUsuarios.Nombre, pUsuarios.Ventas, pUsuarios.Administrar, pUsuarios.Reportes, pUsuarios.Catalogos, pUsuarios.Consultas, pUsuarios.DeshacerVenta), Conexion.ObtenerConexion());


            //MySqlCommand comando = new MySqlCommand(string.Format("Insert into users (UserName, UserPasword, Paterno, Materno, Nombre, Ventas, Administrar, Reportes, Catalogos, Consultas, DeshacerVenta) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
            //    pUsuarios.UserName, pUsuarios.UserPassword, pUsuarios.Paterno, pUsuarios.Materno, pUsuarios.Nombre, pUsuarios.Ventas, pUsuarios.Administrar, pUsuarios.Reporte, pUsuarios.Catalogo, pUsuarios.Consulta, pUsuarios.DeshacerVenta), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

    }
}
