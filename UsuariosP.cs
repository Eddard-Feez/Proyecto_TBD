using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTBD
{
    public partial class UsuariosP : Form
    {
        public UsuariosP()
        {
            InitializeComponent();
        }
        bool Cventas;
        bool cAdministrar;
        bool cReportes;
        bool cCatalogos;
        bool cConsultas;
        bool cDeshacer;

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string constring = "datasource = localhost;port=3306;username=eddard;password=mysql";
            string Query = "insert into ventas.users(user_name, user_password, paterno, materno, nombre,ventas,administrar,reportes,catalogos,consultas,deshacer_venta)values('" 
                + this.txtUserName.Text + "','" + this.txtUserPassword.Text + "','" + this.txtPaterno.Text + "','" + this.txtMaterno.Text + "','" + this.txtNombre.Text + "','" 
                +  Cventas + "','" + cAdministrar + "','" + cReportes + "','" + cCatalogos + "','" + cConsultas + "','" + cDeshacer + "');";
            MySqlConnection conexion = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conexion);
            MySqlDataReader myReader;
            try
            {
                conexion.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Guardado");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserPassword.Text) ||
            //              string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPaterno.Text) || 
            //              string.IsNullOrWhiteSpace(txtMaterno.Text))

            //    //if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserPassword.Text) ||
            //    //               string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPaterno.Text)|| 
            //    //string.IsNullOrWhiteSpace(txtMaterno.Text) ||
            //    //               string.IsNullOrWhiteSpace(cbVentas.Text) || string.IsNullOrWhiteSpace(cbAdministrar.Text) ||
            //    //               string.IsNullOrWhiteSpace(cbReportes.Text) || string.IsNullOrWhiteSpace(cbCatalogos.Text) ||
            //    //               string.IsNullOrWhiteSpace(cbConsultas.Text) || string.IsNullOrWhiteSpace(cbDeshacerVenta.Text))

            //    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //else

            //{

            //    Usuarios pUsuarios = new Usuarios();

            //    //pUsuarios.UserName = _reader.GetString(0);
            //    //pUsuarios.Desc = _reader.GetString(1);
            //    //pUsuarios.PrecioUC = _reader.GetInt32(0);
            //    //pUsuarios.PrecioUV = _reader.GetInt32(0);
            //    //pUsuarios.Cantidad = _reader.GetInt32(0);
            //    //pUsuarios.IVA = _reader.GetInt32(0);
            //    //pUsuarios.IdDepartamento = _reader.GetString(4);
            //    //pUsuarios.PrecioUM = _reader.GetInt32(0);
            //    //pUsuarios.PrecioSM = _reader.GetInt32(0);



            //    //int convertir1;
            //    //pProducto.IdProducto = convertir1 = Convert.ToInt32(txtidProducto.Text);
            //    //convertir1 = int.Parse(txtidProducto.Text);

            //    //int convertir2;
            //    //pProducto.PrecioUC = convertir2 = Convert.ToInt32(txtpuCompra.Text);
            //    //convertir2 = int.Parse(txtpuCompra.Text);

            //    //int convertir3;
            //    //pProducto.PrecioUV = convertir3 = Convert.ToInt32(txtpuVenta.Text);
            //    //convertir3 = int.Parse(txtpuVenta.Text);

            //    //int convertir4;
            //    //pProducto.Cantidad = convertir4 = Convert.ToInt32(txtCantidad.Text);
            //    //convertir4 = int.Parse(txtCantidad.Text);

            //    //int convertir5;
            //    //pProducto.IVA = convertir5 = Convert.ToInt32(txtiva.Text);
            //    //convertir5 = int.Parse(txtiva.Text);

            //    //int convertir6;
            //    //pProducto.PrecioUM = convertir6 = Convert.ToInt32(txtpuMayoreo.Text);
            //    //convertir6 = int.Parse(txtpuMayoreo.Text);

            //    //int convertir7;
            //    //pProducto.PrecioSM = convertir7 = Convert.ToInt32(txtpsMayoreo.Text);
            //    //convertir7 = int.Parse(txtpsMayoreo.Text);



            //    pUsuarios.UserName = txtUserName.Text.Trim();
            //    pUsuarios.UserPassword = txtUserPassword.Text.Trim();
            //    pUsuarios.Nombre = txtNombre.Text.Trim();
            //    pUsuarios.Paterno = txtPaterno.Text.Trim();
            //    pUsuarios.Materno = txtMaterno.Text.Trim();
            //    pUsuarios.Ventas = cbVentas.Checked;

            //    //public Boolean Administrar { get; set; }
            //    //public Boolean Reporte { get; set; }
            //    //public Boolean Catalogo { get; set; }
            //    //public Boolean Consulta { get; set; }
            //    //public Boolean DeshacerVenta { get; set; }

            //    //pUsuarios.Ventas = Convert.ToBoolean(drLogin["VENTAS"]);

            //    //int convertir1;
            //    //pProducto.IdProducto = convertir1 = Convert.ToInt32(txtidProducto.Text);
            //    //convertir1 = int.Parse(txtidProducto.Text);

            //    //string MyString2 = "True";
            //    //bool MyBool = bool.Parse(MyString2);

            //    //bool conv1;
            //    //pUsuarios.Ventas = conv1 =Convert.ToBoolean(cbVentas.Text.Trim());
            //    //conv1 = bool.Parse(cbVentas.Text);
            //    //bool conv2;
            //    //pUsuarios.Administrar = conv2 = Convert.ToBoolean(cbAdministrar.Text.Trim());
            //    //conv2 = bool.Parse(cbVentas.Text);
            //    //bool conv3;
            //    //pUsuarios.Reporte = conv3 = Convert.ToBoolean(cbReportes.Text.Trim());
            //    //conv3 = bool.Parse(cbVentas.Text);
            //    //bool conv4;
            //    //pUsuarios.Catalogo = conv4 = Convert.ToBoolean(cbCatalogos.Text.Trim());
            //    //conv4 = bool.Parse(cbVentas.Text);
            //    //bool conv5;
            //    //pUsuarios.Consulta = conv5 = Convert.ToBoolean(cbConsultas.Text.Trim());
            //    //conv5 = bool.Parse(cbVentas.Text);
            //    //bool conv6;
            //    //pUsuarios.DeshacerVenta = conv6 = Convert.ToBoolean(cbDeshacerVenta.Text.Trim());
            //    //conv6 = bool.Parse(cbVentas.Text);
            //    //---------------------------------------------------------------------------------------

            //    //pUsuarios.Administrar = Convert.ToBoolean(cbAdministrar.Text.Trim());
            //    //pUsuarios.Reporte = Convert.ToBoolean(cbReportes.Text.Trim());
            //    //pUsuarios.Catalogo = Convert.ToBoolean(cbCatalogos.Text.Trim());
            //    //pUsuarios.Consulta = Convert.ToBoolean(cbConsultas.Text.Trim());
            //    //pUsuarios.DeshacerVenta = Convert.ToBoolean(cbDeshacerVenta.Text.Trim());

            //    //---------------------------------------------------------------------------------------




            //    //pProducto.IdProducto = txtidProducto.TextLength;

            //    ////pProducto.PrecioUC = txtpuCompra.TextLength;
            //    ////pProducto.PrecioUV = txtpuVenta.TextLength;
            //    //pProducto.Cantidad = txtCantidad.TextLength;
            //    //pProducto.IVA = txtiva.TextLength;

            //    //pProducto.PrecioUM = txtpuMayoreo.TextLength;
            //    //pProducto.PrecioSM = txtpsMayoreo.TextLength;


            //    int resultado = UsuariosN.AgregarU(pUsuarios);

            //    if (resultado > 0)
            //    {
            //        MessageBox.Show("Usuario Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo guardar el usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //}
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbVentas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVentas.Checked)
            {
                Cventas = true;
            }
            else
            {
                Cventas = false;
            }
        }

        private void cbAdministrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdministrar.Checked)
            {
                cAdministrar = true;
            }
            else
            {
                cAdministrar = false;
            }
        }

        private void cbReportes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReportes.Checked)
            {
                cReportes = true;
            }
            else
            {
                cReportes = false;
            }
        }

        private void cbCatalogos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCatalogos.Checked)
            {
                cCatalogos = true;
            }
            else
            {
                cCatalogos = false;
            }
        }

        private void cbConsultas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConsultas.Checked)
            {
                cConsultas = true;
            }
            else
            {
                cConsultas = false;
            }
        }

        private void cbDeshacerVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDeshacerVenta.Checked)
            {
                cDeshacer = true;
            }
            else
            {
                cDeshacer = false;
            }
        }
    }
}
