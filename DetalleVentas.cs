using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTBD
{
   public class DetalleVentas
    {

        public int IdProducto { get; set; }
        public int IdVenta { get; set; }        
        public decimal Cantidad { get; set; }
        public decimal PrecioUni { get; set; }
        public int IVA { get; set; }
       


        public DetalleVentas() { }


        public DetalleVentas(int pIdProducto, int pIdVenta, decimal PCantidad, decimal pPrecioUni, int pIVA)
        {
            this.IdProducto = pIdProducto;
            this.IdVenta = pIdVenta;
            this.Cantidad = PCantidad;
            this.PrecioUni = pPrecioUni;
            this.IVA = pIVA;
            
        }

        public static int Agregar(DetalleVentas pDetalleVentas)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into detalle_ventas (idproducto,id_venta, cantidad,p_unitario, iva) values ('{0}','{1}','{2}','{3}','{4}')",
                pDetalleVentas.IdProducto, pDetalleVentas.IdVenta, pDetalleVentas.Cantidad, pDetalleVentas.PrecioUni, pDetalleVentas.IVA), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

    }
}
