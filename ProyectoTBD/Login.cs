using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoTBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            
            MySqlConnection conectar2 = new MySqlConnection("server=localhost; database=productos; Uid=eddard; pwd=mysql;");
            //En donde server="nombre del servidor", user id="root" y database="Nombre de la BD a la que nos conectaremos.

            conectar2.Open(); //Abrimos la conexion creada.
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE userName='" + txtUser.Text + "'AND userPassword='" + txtPass.Text + "' ", conectar2); //Realizamos una selecion de la tabla usuarios.
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
            {
                this.Hide();
                Form3 product = new Form3();
                product.ShowDialog();
            }
            else //Si no lo es mostrara este mensaje.
                MessageBox.Show("Error - Ingrese sus datos correctamente");
            conectar2.Close(); //Cerramos la conexion.


            //Form3 product = new Form3();
            //product.ShowDialog();

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtRegistrar_Click(object sender, EventArgs e)
        {

            UsuariosP reg = new UsuariosP();
            reg.ShowDialog();
        }

        
    }
}
