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
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
        }


        public Producto ProductoSelecionado { get; set; }

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    dgvBuscar.DataSource = ClietesDAL.Buscar(txtNombre.Text, txtApellido.Text);
        //}

        //private void btnAceptar_Click(object sender, EventArgs e)
        //{
        //    if (dgvBuscar.SelectedRows.Count == 1)
        //    {
        //        int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
        //        ClienteSelecionado = ClietesDAL.ObtenerCliente(id);

        //        this.Close();
        //    }
        //    else
        //        MessageBox.Show("debe de seleccionar una fila");
        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //int convertir1;
            //pProducto.IdProducto = convertir1 = Convert.ToInt32(txtidProducto.Text);
            //convertir1 = int.Parse(txtidProducto.Text);

            //int enterr;
            datos.DataSource = ProductoN.Buscar ( txtdescProducto.Text);
            //enterr = int.Parse(txtidProducto.Text);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count == 1)
            {
                int idProducto = Convert.ToInt32(datos.CurrentRow.Cells[0].Value);
                ProductoSelecionado = ProductoN.ObtenerProducto(idProducto);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
