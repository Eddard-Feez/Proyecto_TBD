using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTBD
{
   public class UnidadMedida
    {

        public int IdUnidadMedida { get; set; }
        public string DescUM { get; set; }

        public UnidadMedida()
        {
        }

        public UnidadMedida(int pIdUnidadMedida, string pDescUM)
        {
            this.IdUnidadMedida = pIdUnidadMedida;
            this.DescUM = pDescUM;
        }


        public static int Agregar(UnidadMedida pUnidadMedida)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into cat_unidad_medida (idcat_unidad_medida, desc_unidad_medida) values ('{0}','{1}')",
                pUnidadMedida.IdUnidadMedida, pUnidadMedida.DescUM), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
    }
}
