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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 product = new Form3();
            product.ShowDialog();
        }

        private void agregarUnidadMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pUnidadMedida produc_UM = new pUnidadMedida();
            produc_UM.ShowDialog();
        }

        private void agregarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantDepartamento pantDPT = new PantDepartamento();
            pantDPT.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PantCliente pantClient = new PantCliente();
            pantClient.ShowDialog();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantVentas pantVent = new PantVentas();
            pantVent.ShowDialog();
        }
    }
}
