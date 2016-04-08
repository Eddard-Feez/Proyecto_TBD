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
    public partial class PantDepartamento : Form
    {
        public PantDepartamento()
        {
            InitializeComponent();
        }

        private void btnAgregarDPT_Click(object sender, EventArgs e)
        {
            Departamento pDepartamento = new Departamento();

            int convertir1;
            pDepartamento.IdDepartamento = convertir1 = Convert.ToInt32(txtIdDPT.Text);
            convertir1 = int.Parse(txtIdDPT.Text);

            pDepartamento.DescDPT = txtDescDPT.Text.Trim();





            int resultado = Departamento.Agregar(pDepartamento);

            if (resultado > 0)
            {
                MessageBox.Show("Departamento agregado !", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo guardar el departamento", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
