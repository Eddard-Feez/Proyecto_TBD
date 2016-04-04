using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace ProyectoTBD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //public Producto ProductoActual { get; set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textIdProducto.Text) || string.IsNullOrWhiteSpace(textDesc.Text) ||
                            string.IsNullOrWhiteSpace(textPrecioUC.Text) || string.IsNullOrWhiteSpace(textPrecioUV.Text) ||
                            string.IsNullOrWhiteSpace(textCantidad.Text) || string.IsNullOrWhiteSpace(textIVA.Text) ||
                            string.IsNullOrWhiteSpace(textIdDepartamento.Text) || string.IsNullOrWhiteSpace(textPrecioUM.Text) ||
                            string.IsNullOrWhiteSpace(textPrecioSM.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else

            {

                //pProducto.IdProducto = _reader.GetString(0);
                //pProducto.Desc = _reader.GetString(1);
                //pProducto.PrecioUC = _reader.GetInt32(0);
                //pProducto.PrecioUV = _reader.GetInt32(0);
                //pProducto.Cantidad = _reader.GetInt32(0);
                //pProducto.IVA = _reader.GetInt32(0);
                //pProducto.IdDepartamento = _reader.GetString(4);
                //pProducto.PrecioUM = _reader.GetInt32(0);
                //pProducto.PrecioSM = _reader.GetInt32(0);

                Producto pProducto = new Producto();
                pProducto.IdProducto = textIdProducto.Text.Trim();
                pProducto.Desc = textDesc.Text.Trim();
                pProducto.PrecioUC = textPrecioUC.TextLength;
                pProducto.PrecioUV = textPrecioUV.TextLength;
                pProducto.Cantidad = textCantidad.TextLength;
                pProducto.IVA = textIVA.TextLength;
                pProducto.IdDepartamento = textDesc.Text.Trim();
                pProducto.PrecioUM = textPrecioUC.TextLength;
                pProducto.PrecioSM = textPrecioUC.TextLength;


                int resultado = ProductoN.Agregar(pProducto);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    BuscarProducto buscar = new BuscarProducto();

        //    buscar.ShowDialog();

        //    if (buscar.ClienteSelecionado != null)
        //    {
        //        ProductoActual = buscar.ProductoSelecionado;
        //        txtIdProducto.Text = buscar.ProductoSelecionado.Nombre;
        //        txtApellido.Text = buscar.ProductoSelecionado.Apellido;
        //        txtDireccion.Text = buscar.ProductoSelecionado.Direccion;


        //        btnActualizar.Enabled = true;
        //        btnEliminar.Enabled = true;
        //        Habilitar();
        //        btnGuardar.Enabled = false;
        //    }
        //}

        //private void btnActualizar_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
        //                    string.IsNullOrWhiteSpace(txtDireccion.Text))

        //        MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    else

        //    {

        //        Producto pCliente = new Producto();
        //        pProducto.Nombre = txtNombre.Text.Trim();
        //        pProducto.Apellido = txtApellido.Text.Trim();
        //        pProducto.Fecha_Nac = dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;
        //        pProducto.Direccion = txtDireccion.Text.Trim();
        //        pProducto.Id = ProductoActual.Id;

        //        if (ProductoN.Actualizar(pCliente) > 0)
        //        {
        //            MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            Limpiar();
        //            Deshabilitar();

        //        }
        //        else
        //        {
        //            MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //        }
        //    }
        //}





        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        if (ProductoN.Eliminar(ProductoActual.Id) > 0)
        //        {
        //            MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            Limpiar();
        //            Deshabilitar();
        //        }
        //        else

        //        {
        //            MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //    }
        //    else
        //        MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //}

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
        }


        void Limpiar()
        {

           

            textIdProducto.Clear();
            textDesc.Clear();
            textPrecioUC.Clear();
            textPrecioUV.Clear();
            textIdProducto.Clear();
            textIdProducto.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            dtpFechaNacimiento.ResetText();

        }

        void Habilitar()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

        }


        void Deshabilitar()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;


            btnNuevo.Enabled = true;

        }
    }
}
