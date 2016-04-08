using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTBD
{
    public class Domicilio
    {

        public int CodPostal { get; set; }
        public string Calle { get; set; }
        public int NumExt { get; set; }
        public int NumInt { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string MunDel { get; set; }
        public string DF { get; set; }
        public string EntreCalles { get; set; }
        public string CallePost { get; set; }
        public string Desc { get; set; }
        public int telefono { get; set; }
        public int IdCliente {get;set;}

        public Domicilio() { }

        public Domicilio(int pCodPostal, string pCalle, int pNumExt, int pNumInt, string pColonia, string pLocalidad, string PMunDel, string pDF, string pEntreCalles, string pCallePost, string pDesc, int ptelefono, int pIdCliente)
        {
            this.CodPostal = pCodPostal;
            this.Calle = pCalle;
            this.NumExt = pNumExt;
            this.NumInt = pNumInt;
            this.Colonia = pColonia;
            this.Localidad = pLocalidad;
            this.MunDel = PMunDel;
            this.DF = pDF;
            this.EntreCalles = pEntreCalles;
            this.CallePost = pCallePost;
            this.Desc = pDesc;
            this.telefono = ptelefono;
            this.IdCliente = pIdCliente;

         
        }

        public static int Agregar(Domicilio pDomicilio)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into domicilio (codigo_postal, calle, num_ext, num_int, colonia, localidad, mun_del, distrito_federal, entre_calles, calle_posterior, descripcion,telefono, id_cliente) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                pDomicilio.CodPostal, pDomicilio.Calle, pDomicilio.NumExt, pDomicilio.NumInt, pDomicilio.Colonia, pDomicilio.Localidad, pDomicilio.MunDel, pDomicilio.DF, pDomicilio.EntreCalles, pDomicilio.CallePost, pDomicilio.Desc,pDomicilio.telefono,pDomicilio.IdCliente), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

    }
}
