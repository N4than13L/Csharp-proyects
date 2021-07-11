using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Accesar_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text == "Natha")
            {
                if(txt_contrasena.Text == "natha")
                {
                    ModeloUsuario usuario = new ModeloUsuario();

                    var validar_login = usuario.Loggin_usuario(txt_usuario.Text, txt_contrasena.Text);

                    if(validar_login == true)
                    {
                        Tienda tienda = new Tienda();
                        tienda.Show();
                        this.Hide();
                    }
                    else
                    {
                        MsError("nombre de usuario u contraseña incorrectos");
                        txt_usuario.Clear();
                        txt_contrasena.Focus();
                    }
                }
                else
                {
                    MsError("introdusca su contraseña");
                }
            }
            else
            {
                MsError("por favor escribe tu nombre de usuario");
            }
        }

        private void MsError(string msg)
        {
            lbl_error.Text = "" + msg;
            lbl_error.ForeColor = Color.Red;
            lbl_error.Visible = true;
        }
    }
}
