using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoTBD
{
    class ProductoN
    {
        
        public static int Agregar(Producto pProducto)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into cat_productos (id_producto, desc_producto, idcat_unidad_medida, cantidad, p_u_compra, p_u_venta, id_departamento, cantidad_min, iva, p_u_mayoreo, p_s_mayoreo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                pProducto.IdProducto, pProducto.Desc, pProducto.IdUnidadMed, pProducto.Cantidad, pProducto.PrecioUC, pProducto.PrecioUV, pProducto.IdDepartamento, pProducto.CantidadMin, pProducto.IVA, pProducto.PrecioUM, pProducto.PrecioSM ), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }



        public static List<Producto> Buscar( string pDesc)
        {
            List<Producto> _lista = new List<Producto>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT  id_producto, desc_producto, id_unidad_medida, p_u_compra, p_u_venta, cantidad, iva, id_departamento, cantidad_min p_u_mayoreo, p_s_mayoreo FROM cat_productos  where descProducto='{0}'", pDesc), Conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto pProducto = new Producto();
                pProducto.IdProducto = _reader.GetInt32(0);
                pProducto.Desc = _reader.GetString(1);
                pProducto.IdUnidadMed = _reader.GetInt32(0);
                pProducto.PrecioUC = _reader.GetDecimal(0);
                pProducto.PrecioUV = _reader.GetDecimal(0);
                pProducto.Cantidad = _reader.GetDecimal(0);
                pProducto.IVA = _reader.GetInt32(0);
                pProducto.IdDepartamento = _reader.GetInt32(0);
                pProducto.PrecioUM = _reader.GetDecimal(0);
                pProducto.PrecioSM = _reader.GetDecimal(0);
                pProducto.CantidadMin = _reader.GetDecimal(0);



                _lista.Add(pProducto);
            }

            return _lista;
        }



        public static Producto ObtenerProducto(int pIdProducto)
        {
            Producto pProducto = new Producto();
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idProducto, descProducto, puCompra, puVenta, Cantidad, iva, idDepartamento, puMayoreo, psMayoreo FROM tproductos where idProducto={0}", pIdProducto), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                //Producto pProducto = new Producto();
                pProducto.IdProducto = _reader.GetInt32(0);
                pProducto.Desc = _reader.GetString(1);
                pProducto.IdUnidadMed = _reader.GetInt32(0);
                pProducto.PrecioUC = _reader.GetDecimal(0);
                pProducto.PrecioUV = _reader.GetDecimal(0);
                pProducto.Cantidad = _reader.GetDecimal(0);
                pProducto.IVA = _reader.GetInt32(0);
                pProducto.IdDepartamento = _reader.GetInt32(0);
                pProducto.PrecioUM = _reader.GetDecimal(0);
                pProducto.PrecioSM = _reader.GetDecimal(0);
                pProducto.CantidadMin = _reader.GetDecimal(0);

            }

            conexion.Close();
            return pProducto;

        }



        public static int Actualizar(Producto pProducto)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update cat_productos set desc_producto ='{0}', id_unidad_medida ='{1}', cantidad ='{2}', p_u_compra ='{3}', p_u_venta ='{4}', id_departamento ='{5}', cantidad_min ='{6}', iva ='{7}',p_u_mayoreo = '{8}', p_s_mayoreo = '{9}' where idProducto={10}",
                 pProducto.Desc, pProducto.IdUnidadMed, pProducto.Cantidad, pProducto.PrecioUC, pProducto.PrecioUV, pProducto.IdDepartamento, pProducto.CantidadMin, pProducto.IVA,pProducto.PrecioUM,pProducto.PrecioSM, pProducto.IdProducto), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


        public static int Eliminar(int pIdProducto)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From cat_cliente where idcat_cliente={0}", pIdProducto), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


    }
}

