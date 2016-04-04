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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Producto ProductoActual { get; set; }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdescProducto.Text) ||
                            string.IsNullOrWhiteSpace(txtpuCompra.Text) || string.IsNullOrWhiteSpace(txtpuVenta.Text) ||
                            string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtiva.Text) ||
                            string.IsNullOrWhiteSpace(txtidDepartamento.Text) || string.IsNullOrWhiteSpace(txtpuMayoreo.Text) ||
                            string.IsNullOrWhiteSpace(txtpsMayoreo.Text))

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

                int convertir1;
                pProducto.IdProducto = convertir1 = Convert.ToInt32(txtIdProducto.Text);
                convertir1 = int.Parse(txtIdProducto.Text);

                pProducto.Desc = txtdescProducto.Text.Trim();

                int convertir2;
                pProducto.IdUnidadMed = convertir2 = Convert.ToInt32(txtIdUnidadMed.Text);
                convertir2 = int.Parse(txtIdUnidadMed.Text);

                decimal convertir3;
                pProducto.Cantidad = convertir3 = Convert.ToDecimal(txtCantidad.Text);
                convertir3 = decimal.Parse(txtCantidad.Text);

                decimal convertir4;
                pProducto.PrecioUC = convertir4 = Convert.ToDecimal(txtpuCompra.Text);
                convertir4 = decimal.Parse(txtpuCompra.Text);

                decimal convertir5;
                pProducto.PrecioUV = convertir5 = Convert.ToDecimal(txtpuVenta.Text);
                convertir5 = decimal.Parse(txtpuVenta.Text);

                int convertir6;
                pProducto.IdDepartamento = convertir6 = Convert.ToInt32(txtidDepartamento.Text);
                convertir6 = int.Parse(txtidDepartamento.Text);

                decimal convertir7;
                pProducto.CantidadMin = convertir7 = Convert.ToDecimal(txtCantidadMin.Text);
                convertir7 = decimal.Parse(txtCantidadMin.Text);

                int convertir8;
                pProducto.IVA = convertir8 = Convert.ToInt32(txtiva.Text);
                convertir8 = int.Parse(txtiva.Text);

                decimal convertir9;
                pProducto.PrecioUM = convertir9 = Convert.ToDecimal(txtpuMayoreo.Text);
                convertir9 = decimal.Parse(txtpuMayoreo.Text);

                decimal convertir10;
                pProducto.PrecioSM = convertir10 = Convert.ToDecimal(txtpsMayoreo.Text);
                convertir10 = decimal.Parse(txtpsMayoreo.Text);
                //int convertir3;
                //pProducto.PrecioUV = convertir3 = Convert.ToInt32(txtpuVenta.Text);
                //convertir3 = int.Parse(txtpuVenta.Text);

                //int convertir4;
                //pProducto.Cantidad = convertir4 = Convert.ToInt32(txtCantidad.Text);
                //convertir4 = int.Parse(txtCantidad.Text);

                //int convertir5;
                //pProducto.IVA = convertir5 = Convert.ToInt32(txtiva.Text);
                //convertir5 = int.Parse(txtiva.Text);

                //int convertir6;
                //pProducto.PrecioUM = convertir6 = Convert.ToInt32(txtpuMayoreo.Text);
                //convertir6 = int.Parse(txtpuMayoreo.Text);

                //int convertir7;
                //pProducto.PrecioSM = convertir7 = Convert.ToInt32(txtpsMayoreo.Text);
                //convertir7 = int.Parse(txtpsMayoreo.Text);

                //int convertir8;
                //pProducto.IdDepartamento = convertir7 = Convert.ToInt32(txtidDepartamento.Text);
                //convertir8 = int.Parse(txtidDepartamento.Text);


                //pProducto.IdDepartamento = txtidDepartamento.Text.Trim();



                //pProducto.IdProducto = txtidProducto.TextLength;

                ////pProducto.PrecioUC = txtpuCompra.TextLength;
                ////pProducto.PrecioUV = txtpuVenta.TextLength;
                //pProducto.Cantidad = txtCantidad.TextLength;
                //pProducto.IVA = txtiva.TextLength;

                //pProducto.PrecioUM = txtpuMayoreo.TextLength;
                //pProducto.PrecioSM = txtpsMayoreo.TextLength;


                int resultado = ProductoN.Agregar(pProducto);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto agregado !", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        void Limpiar()
        {



            txtIdProducto.Clear();
            txtdescProducto.Clear();
            txtidDepartamento.Clear();
            txtpuCompra.Clear();
            txtpuVenta.Clear();
            txtCantidad.Clear();
            txtiva.Clear();
            txtpuMayoreo.Clear();
            txtpsMayoreo.Clear();



        }

        void Habilitar()
        {
            txtIdProducto.Enabled = true;
            txtdescProducto.Enabled = true;
            txtidDepartamento.Enabled = true;
            txtpuCompra.Enabled = true;
            txtpuVenta.Enabled = true;
            txtCantidad.Enabled = true;
            txtiva.Enabled = true;
            txtpuMayoreo.Enabled = true;
            txtpsMayoreo.Enabled = true;

            btnGuardar.Enabled = true;
            //btnCancelar.Enabled = true;

        }


        void Deshabilitar()
        {
            txtIdProducto.Enabled = false;
            txtdescProducto.Enabled = false;
            txtidDepartamento.Enabled = false;
            txtpuCompra.Enabled = false;
            txtpuVenta.Enabled = false;
            txtCantidad.Enabled = false;
            txtiva.Enabled = false;
            txtpuMayoreo.Enabled = false;
            txtpsMayoreo.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;


            btnNuevo.Enabled = true;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtIdProducto.Text) || string.IsNullOrWhiteSpace(txtdescProducto.Text) ||
                             string.IsNullOrWhiteSpace(txtpuCompra.Text) || string.IsNullOrWhiteSpace(txtpuVenta.Text) ||
                             string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtiva.Text) ||
                             string.IsNullOrWhiteSpace(txtidDepartamento.Text) || string.IsNullOrWhiteSpace(txtpuMayoreo.Text) ||
                             string.IsNullOrWhiteSpace(txtpsMayoreo.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else

            {

                Producto pProducto = new Producto();

                int convertir1;
                pProducto.IdProducto = convertir1 = Convert.ToInt32(txtIdProducto.Text);
                convertir1 = int.Parse(txtIdProducto.Text);

                pProducto.Desc = txtdescProducto.Text.Trim();

                int convertir2;
                pProducto.IdUnidadMed = convertir2 = Convert.ToInt32(txtIdUnidadMed.Text);
                convertir2 = int.Parse(txtIdUnidadMed.Text);

                decimal convertir3;
                pProducto.Cantidad = convertir3 = Convert.ToDecimal(txtCantidad.Text);
                convertir3 = decimal.Parse(txtCantidad.Text);

                decimal convertir4;
                pProducto.PrecioUC = convertir4 = Convert.ToDecimal(txtpuCompra.Text);
                convertir4 = decimal.Parse(txtpuCompra.Text);

                decimal convertir5;
                pProducto.PrecioUV = convertir5 = Convert.ToDecimal(txtpuVenta.Text);
                convertir5 = decimal.Parse(txtpuVenta.Text);

                int convertir6;
                pProducto.IdDepartamento = convertir6 = Convert.ToInt32(txtidDepartamento.Text);
                convertir6 = int.Parse(txtidDepartamento.Text);

                decimal convertir7;
                pProducto.CantidadMin = convertir7 = Convert.ToDecimal(txtCantidadMin.Text);
                convertir7 = decimal.Parse(txtCantidadMin.Text);

                int convertir8;
                pProducto.IVA = convertir8 = Convert.ToInt32(txtiva.Text);
                convertir8 = int.Parse(txtiva.Text);

                decimal convertir9;
                pProducto.PrecioUM = convertir9 = Convert.ToDecimal(txtpuMayoreo.Text);
                convertir9 = decimal.Parse(txtpuMayoreo.Text);

                decimal convertir10;
                pProducto.PrecioSM = convertir10 = Convert.ToDecimal(txtpsMayoreo.Text);
                convertir10 = decimal.Parse(txtpsMayoreo.Text);

                if (ProductoN.Actualizar(pProducto) > 0)
                {
                    MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ProductoN.Eliminar(ProductoActual.IdProducto) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                }
                else

                {
                    MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto buscar = new BuscarProducto();

            buscar.ShowDialog();

            //Producto pProducto = new Producto();

            //int convertir7;
            //pProducto.PrecioSM = convertir7 = Convert.ToInt32(txtpsMayoreo.Text);
            //convertir7 = int.Parse(txtpsMayoreo.Text);

            if (buscar.ProductoSelecionado != null)
            {
                ProductoActual = buscar.ProductoSelecionado;

                //int convertir2;
                //pProducto.PrecioUC = convertir2 = Convert.ToInt32(txtpuCompra.Text);
                //convertir2 = int.Parse(txtpuCompra.Text);

                //int convertir3;
                //pProducto.PrecioUV = convertir3 = Convert.ToInt32(txtpuVenta.Text);
                //convertir3 = int.Parse(txtpuVenta.Text);

                //int convertir4;
                //pProducto.Cantidad = convertir4 = Convert.ToInt32(txtCantidad.Text);
                //convertir4 = int.Parse(txtCantidad.Text);

                //int convertir5;
                //pProducto.IVA = convertir5 = Convert.ToInt32(txtiva.Text);
                //convertir5 = int.Parse(txtiva.Text);

                //int convertir6;
                //pProducto.PrecioUM = convertir6 = Convert.ToInt32(txtpuMayoreo.Text);
                //convertir6 = int.Parse(txtpuMayoreo.Text);

                //int convertir7;
                //pProducto.PrecioSM = convertir7 = Convert.ToInt32(txtpsMayoreo.Text);
                //convertir7 = int.Parse(txtpsMayoreo.Text);

                //pProducto.Desc = txtdescProducto.Text.Trim();
                //pProducto.IdDepartamento = txtidDepartamento.Text.Trim();



                buscar.ProductoSelecionado.IdProducto = Convert.ToInt32(txtIdProducto.Text);
                buscar.ProductoSelecionado.Desc= txtdescProducto.Text ;
                buscar.ProductoSelecionado.IdUnidadMed = Convert.ToInt32(txtIdUnidadMed.Text);
                buscar.ProductoSelecionado.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                buscar.ProductoSelecionado.PrecioUC = Convert.ToDecimal(txtpuCompra.Text);
                buscar.ProductoSelecionado.PrecioUV = Convert.ToDecimal(txtpuVenta.Text);
                buscar.ProductoSelecionado.IdDepartamento = Convert.ToInt32(txtidDepartamento.Text);
                buscar.ProductoSelecionado.CantidadMin= Convert.ToDecimal(txtCantidadMin.Text);
                buscar.ProductoSelecionado.IVA = Convert.ToInt32(txtiva.Text);
                buscar.ProductoSelecionado.PrecioUM = Convert.ToDecimal(txtpuMayoreo.Text);
                buscar.ProductoSelecionado.PrecioSM = Convert.ToDecimal(txtpsMayoreo.Text);


                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                Habilitar();
                btnGuardar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
