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
        string varUSER_LOGIN = Login.user;
        int varID_CAJA = 1;

        public PantVentas(string prmUSER_LOGIN, int prmID_CAJA)
        {
            InitializeComponent();
            varID_CAJA = prmID_CAJA;
            varUSER_LOGIN = prmUSER_LOGIN;
        }

        //void Headers()
        //{
        //    //Encabezados del litView
        //    lvVenta.View = View.Details;
        //    lvVenta.Columns.Add("Producto", 100,
        //        HorizontalAlignment.Left);
        //    lvVenta.Columns.Add("Descripcion", 250,
        //        HorizontalAlignment.Left);
        //    lvVenta.Columns.Add("Cant", 75,
        //        HorizontalAlignment.Right);
        //    lvVenta.Columns.Add("Prec", 75,
        //        HorizontalAlignment.Right);
        //    lvVenta.Columns.Add("Iva", 75,
        //        HorizontalAlignment.Right);
        //    lvVenta.Columns.Add("Total", 100,
        //        HorizontalAlignment.Right);
        //}

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

        private void btnVenta_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
            //                string.IsNullOrWhiteSpace(txtDireccion.Text))

            //    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //else

            //{
                Ventas pVentas = new Ventas();

            int convertir1;
            pVentas.Folio = convertir1 = Convert.ToInt32(txtFolio.Text);
            convertir1 = int.Parse(txtFolio.Text);

            int convertir2;
            pVentas.IdUser = convertir2 = Convert.ToInt32(txtIdUser.Text);
            convertir2 = int.Parse(txtIdUser.Text);

            decimal convertir3;
            pVentas.Total= convertir3 = Convert.ToDecimal(txtTotal.Text);
            convertir3 = decimal.Parse(txtTotal.Text);

            int convertir4;
            pVentas.IdCaja = convertir4 = Convert.ToInt32(txtIdCaja.Text);
            convertir4 = int.Parse(txtIdCaja.Text);

            int convertir5;
            pVentas.IdCliente = convertir5 = Convert.ToInt32(txtIdCliente.Text);
            convertir5 = int.Parse(txtIdCliente.Text);

            pVentas.Serie = txtSerie.Text.Trim();
            //pVentas.Apellido = txtApellido.Text.Trim();
            pVentas.Fecha = dtFecha.Value.Year + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Day;
            //pVentas.Direccion = txtDireccion.Text.Trim();

                int resultado = Ventas.Agregar(pVentas);
                if (resultado > 0)
                {
                    MessageBox.Show("Venta Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la venta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            //}
        }

//        private void PantVentas_Load(object sender, EventArgs e)
//        {
//            Headers();
//            ReadData(varUSER_LOGIN, varID_CAJA);
//            this.txtCantidadDetalle}.KeyPress +=
//                new System.Windows.Forms.
//                KeyPressEventHandler(txtCantidadDetalle_KeyPress);
//            this.txtCantidadDetalle.KeyDown +=
//                new System.Windows.Forms.
//                KeyEventHandler(this.txtCantidadDetalle_KeyDown);
//            this.txt.KeyPress +=
//                new System.Windows.Forms.
//                KeyPressEventHandler(this.txtID_PRODUCTO_KeyPress);
//            this.txt.KeyDown +=
//                new System.Windows.Forms.
//                KeyEventHandler(this.txtID_PRODUCTO_KeyDown);
//private void txtCantidadDetalle_TextChanged(object sender, EventArgs e)
//        {

//        }
    }
    }

