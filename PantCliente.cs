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
    public partial class PantCliente : Form
    {
        public PantCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente pcliente = new Cliente();

            pcliente.Paterno = txtPaterno.Text.Trim();
            pcliente.Materno = txtMaterno.Text.Trim();
            pcliente.Nombre = txtNombre.Text.Trim();
            pcliente.RFC = txtRFC.Text.Trim();
            pcliente.Tipo = txtTipo.Text.Trim();
            pcliente.RazónSocial = txtRazónSocial.Text.Trim();
           
            int resultado = Cliente.Agregar(pcliente);

            if (resultado > 0)
            {
                MessageBox.Show("Cliente agregado !", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardarDom_Click(object sender, EventArgs e)
        {

            Domicilio pDomicilio = new Domicilio();

            int convertir1;
            pDomicilio.CodPostal= convertir1 = Convert.ToInt32(txtCodPos.Text);
            convertir1 = int.Parse(txtCodPos.Text);

            pDomicilio.Calle = txtCalle.Text.Trim();

            int convertir2;
            pDomicilio.NumExt = convertir2 = Convert.ToInt32(txtNumExt.Text);
            convertir2 = int.Parse(txtNumExt.Text);

            int convertir3;
            pDomicilio.NumInt = convertir3 = Convert.ToInt32(txtNumInt.Text);
            convertir3 = int.Parse(txtNumInt.Text);

            pDomicilio.Colonia = txtColonia.Text.Trim();
            pDomicilio.Localidad = txtLocalidad.Text.Trim();
            pDomicilio.MunDel = txtMun.Text.Trim();
            pDomicilio.DF = txtDF.Text.Trim();
            pDomicilio.EntreCalles = txtEntreCalles.Text.Trim();
            pDomicilio.CallePost = txtCallePost.Text.Trim();
            pDomicilio.Desc = txtDescDom.Text.Trim();

            int convertir4;
            pDomicilio.telefono = convertir4 = Convert.ToInt32(txtTel.Text);
            convertir4 = int.Parse(txtTel.Text);

            int convertir5;
            pDomicilio.IdCliente = convertir5 = Convert.ToInt32(txtIdCliente.Text);
            convertir5 = int.Parse(txtIdCliente.Text);

            int resultado = Domicilio.Agregar(pDomicilio);

            if (resultado > 0)
            {
                MessageBox.Show("Domicilio agregado !", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo guardar el domicilio", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
