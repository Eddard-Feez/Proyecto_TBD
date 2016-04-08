using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTBD
{
    public class Cliente
    {

        //public int IdCliente { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string Tipo { get; set; }
        public string RazónSocial { get; set; }

        public Cliente()
        {
        }

        public Cliente( string pPaterno, string pMaterno, string pNombre, string pRFC, string pTipo, string pRazónSocial)
        {
            //this.IdCliente= pIdCliente;
            this.Paterno = pPaterno;
            this.Materno = pMaterno;
            this.Nombre = pNombre;
            this.RFC = pRFC;
            this.Tipo = pTipo;
            this.RazónSocial = pRazónSocial;
        }


        public static int Agregar(Cliente pCliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into cat_cliente (paterno, materno, nombre, RFC, tipo, razon_social) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                pCliente.Paterno, pCliente.Materno, pCliente.Nombre, pCliente.RFC, pCliente.Tipo, pCliente.RazónSocial), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

    }
}
