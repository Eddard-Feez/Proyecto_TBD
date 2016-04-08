using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTBD
{
    public class Departamento
    {

        public int IdDepartamento { get; set; }
        public string DescDPT { get; set; }

        public Departamento()
        {
        }

        public Departamento(int pIdDepartamento, string pDescDPT)
        {
            this.IdDepartamento = pIdDepartamento;
            this.DescDPT = pDescDPT;
        }


        public static int Agregar(Departamento pDepartamento)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into cat_departamento (id_departamento, desc_departamento) values ('{0}','{1}')",
                pDepartamento.IdDepartamento, pDepartamento.DescDPT), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

    }
}
