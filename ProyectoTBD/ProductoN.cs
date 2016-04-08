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

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tproductos (idProducto, descProducto, puCompra, puVenta, Cantidad, iva, idDepartamento, puMayoreo, psMayoreo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                pProducto.IdProducto, pProducto.Desc, pProducto.PrecioUC, pProducto.PrecioUV, pProducto.Cantidad, pProducto.IVA, pProducto.IdDepartamento, pProducto.PrecioUM, pProducto.PrecioSM ), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }



        public static List<Producto> Buscar(int pIdProducto, string pDesc)
        {
            List<Producto> _lista = new List<Producto>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT idProducto, descProducto, puCompra, puVenta, Cantidad, iva, idDepartamento, puMayoreo, psMayoreo FROM tproductos  where idProducto ='{0}' or descProducto='{1}'", pIdProducto, pDesc), Conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto pProducto = new Producto();
                pProducto.IdProducto = _reader.GetInt32(0);
                pProducto.Desc = _reader.GetString(1);
                pProducto.PrecioUC= _reader.GetInt32(0);
                pProducto.PrecioUV = _reader.GetInt32(0);
                pProducto.Cantidad = _reader.GetInt32(0);
                pProducto.IVA = _reader.GetInt32(0);
                pProducto.IdDepartamento = _reader.GetString(4);
                pProducto.PrecioUM = _reader.GetInt32(0);
                pProducto.PrecioSM = _reader.GetInt32(0);



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

                pProducto.IdProducto = _reader.GetInt32(0);
                pProducto.Desc = _reader.GetString(1);
                pProducto.PrecioUC = _reader.GetInt32(0);
                pProducto.PrecioUC = _reader.GetInt32(0);
                pProducto.Cantidad = _reader.GetInt32(0);
                pProducto.IVA = _reader.GetInt32(0);
                pProducto.IdDepartamento = _reader.GetString(4);
                pProducto.PrecioUM = _reader.GetInt32(0);
                pProducto.PrecioSM = _reader.GetInt32(0);

            }

            conexion.Close();
            return pProducto;

        }



        public static int Actualizar(Producto pProducto)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update tproductos set descProducto ='{0}', puCompra ='{1}', puVenta ='{2}', Cantidad ='{3}', iva ='{4}', idDepartamento ='{5}', puMayoreo ='{6}', psMayoreo ='{7}' where idProducto={7}",
                 pProducto.Desc, pProducto.PrecioUC, pProducto.PrecioUC, pProducto.Cantidad, pProducto.IVA, pProducto.IdDepartamento, pProducto.PrecioUM, pProducto.PrecioUM, pProducto.IdProducto), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


        public static int Eliminar(int pIdProducto)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From clientes where IdCliente={0}", pIdProducto), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


    }
}

