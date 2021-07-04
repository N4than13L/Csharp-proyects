using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Login_de_usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            if(txt_Usuario.Text == "Usuario")
            {
                txt_Usuario.Text = "";
                txt_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_Usuario_Layout(object sender, LayoutEventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                txt_Usuario.Text = "Usuario";
                txt_Usuario.ForeColor = Color.DimGray;

            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
