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
    public partial class pUnidadMedida : Form
    {
        public pUnidadMedida()
        {
            InitializeComponent();
        }



       


        private void btnAgregarIDUM_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtdescProducto.Text) ||
            //                string.IsNullOrWhiteSpace(txtpuCompra.Text) || string.IsNullOrWhiteSpace(txtpuVenta.Text) ||
            //                string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtiva.Text) ||
            //                string.IsNullOrWhiteSpace(txtidDepartamento.Text) || string.IsNullOrWhiteSpace(txtpuMayoreo.Text) ||
            //                string.IsNullOrWhiteSpace(txtpsMayoreo.Text))

            //    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            

          

                //pProducto.IdProducto = _reader.GetString(0);
                //pProducto.Desc = _reader.GetString(1);
                //pProducto.PrecioUC = _reader.GetInt32(0);
                //pProducto.PrecioUV = _reader.GetInt32(0);
                //pProducto.Cantidad = _reader.GetInt32(0);
                //pProducto.IVA = _reader.GetInt32(0);
                //pProducto.IdDepartamento = _reader.GetString(4);
                //pProducto.PrecioUM = _reader.GetInt32(0);
                //pProducto.PrecioSM = _reader.GetInt32(0);

                UnidadMedida pUnidadMedida = new UnidadMedida();

                int convertir1;
            pUnidadMedida.IdUnidadMedida = convertir1 = Convert.ToInt32(txtIdUM.Text);
                convertir1 = int.Parse(txtIdUM.Text);

            pUnidadMedida.DescUM = txtDescUM.Text.Trim();

                int resultado = UnidadMedida.Agregar(pUnidadMedida);

                if (resultado > 0)
                {
                    MessageBox.Show("Unidad agregada !", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la unidad", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
        }
    }
}
