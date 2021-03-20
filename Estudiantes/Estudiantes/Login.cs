using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boton_entrar_Click(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "root" && textBox_contrasena.Text == "root")
            {
                Form1 clases = new Form1();
                Login login = new Login();

                login.Close();
                clases.Show();
            }
            else
            {
                MessageBox.Show("Error al introducir usuario");
            }
        }
    }
}
