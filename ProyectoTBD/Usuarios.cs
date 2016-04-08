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
        //public Boolean Ventas { get; set; }
        //public Boolean Administrar { get; set; }
        //public Boolean Reporte { get; set; }
        //public Boolean Catalogo { get; set; }
        //public Boolean Consulta { get; set; }
        //public Boolean DeshacerVenta { get; set; }

        public Usuarios() { }

        //public Usuarios(string pUserName, string pUserPassword, string pNombre, string pPaterno, string pMaterno, Boolean pVentas, Boolean pAdministrar, Boolean pReporte, Boolean pCatalogo, Boolean pConsulta, Boolean pDeshacerVenta)
        public Usuarios(string pUserName, string pUserPassword, string pNombre, string pPaterno, string pMaterno)

        {
            this.UserName = pUserName;
            this.UserPassword = pUserPassword;
            this.Nombre = pNombre;
            this.Paterno = pPaterno;
            this.Materno = pMaterno;
            //this.Ventas = pVentas;
            //this.Administrar = pAdministrar;
            //this.Reporte = pReporte;
            //this.Catalogo = pCatalogo;
            //this.Consulta = pConsulta;
            //this.DeshacerVenta = pDeshacerVenta;
        }


    }
}
