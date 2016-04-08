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
    public partial class PantVentas : Form
    {
        public PantVentas()
        {
            InitializeComponent();
        }

        private void btnGuardarDetalleV_Click(object sender, EventArgs e)
        {
            DetalleVentas pDetalleVentas = new DetalleVentas();

            int convertir1;
            pDetalleVentas.IdProducto = convertir1 = Convert.ToInt32(txtIdProductoDetalle.Text);
            convertir1 = int.Parse(txtIdProductoDetalle.Text);        

            int convertir2;
            pDetalleVentas.IdVenta = convertir2 = Convert.ToInt32(txtIdVentaDetalle.Text);
            convertir2 = int.Parse(txtIdVentaDetalle.Text);

            decimal convertir3;
            pDetalleVentas.Cantidad = convertir3 = Convert.ToDecimal(txtCantidadDetalle.Text);
            convertir3 = decimal.Parse(txtCantidadDetalle.Text);

            decimal convertir4;
            pDetalleVentas.PrecioUni = convertir4 = Convert.ToDecimal(txtPrecioUdetalle.Text);
            convertir4 = decimal.Parse(txtPrecioUdetalle.Text);

            int convertir5;
            pDetalleVentas.IVA = convertir5 = Convert.ToInt32(txtIVAdetalle.Text);
            convertir5 = int.Parse(txtIVAdetalle.Text);

            int resultado = DetalleVentas.Agregar(pDetalleVentas);

            if (resultado > 0)
            {
                MessageBox.Show("Guardado !", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("No se pudo guardar ", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
