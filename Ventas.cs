using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTBD
{
    public class Ventas
    {


        public int Folio { get; set; }
        public string Fecha { get; set; }
        public int IdUser { get; set; }
        public decimal Total { get; set; }
        public int IdCaja { get; set; }
        public int IdCliente { get; set; }
        public string Serie { get; set; }



        public Ventas() { }


        public Ventas(int pFolio, string pFecha, int pIdUser, decimal pTotal, int pIdCaja, int pIdCliente, string pSerie)
        {
            this.Folio = pFolio;
            this.Fecha = pFecha;
            this.IdUser = pIdUser;
            this.Total = pTotal;
            this.IdCaja = pIdCaja;
            this.IdCliente = pIdCliente;
            this.Serie = pSerie;

        }

        public static int Agregar(Ventas pVentas)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into ventas (folio,fecha, id_user,total, id_caja, id_cliente, serie) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                pVentas.Folio, pVentas.Fecha, pVentas.IdUser, pVentas.Total, pVentas.IdCaja, pVentas.IdCliente, pVentas.Serie), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

    }
}
