using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoTBD
{
    public partial class formAccesoMySQL : Form
    {
        private MySqlConnection conexionBD;

       

        public formAccesoMySQL()
        {
            InitializeComponent();
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (conexionBD != null)
                conexionBD.Close();

            string connStr =
                String.Format("server={0};port={1};user id={2}; password={3}; " + 
                "database=mysql; pooling=false;" +
                "Allow Zero Datetime=False;Convert Zero Datetime=True",
                txtServidor.Text,txtPuerto.Text, txtUsuario.Text, txtContrasena.Text);
            try
            {
                conexionBD = new MySqlConnection(connStr);
                conexionBD.Open();

               Control PantallaControl = new Control();
                PantallaControl.ShowDialog();
            }
            
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor de MySQL: " + 
                    ex.Message, "Error al conectar", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

       

        
    }
}
