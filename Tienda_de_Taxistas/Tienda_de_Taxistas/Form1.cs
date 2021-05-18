using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_Taxistas
{
    public partial class Form1 : Form
    {
        private int conteo;
        public Form1()
        {
            InitializeComponent();
            conteo = 0;
        }

        private void button_primertaxista_Click(object sender, EventArgs e)
        {
            label_taxi1.Text = "Taxista en camino";
            button_primertaxista.ForeColor = Color.Red;
            Reloj.Enabled = true;

        }

        private void button_segundotaxista_Click(object sender, EventArgs e)
        {
            label_taxi2.Text = "Taxista en camino";
            button_segundotaxista.ForeColor = Color.Red;
        }

        private void button_tercertaxista_Click(object sender, EventArgs e)
        {
            label_taxi3.Text = "Taxista en camino";
            button_tercertaxista.ForeColor = Color.Red;
        }

        private void button_cuartotaxista_Click(object sender, EventArgs e)
        {
            label_taxi4.Text = "Taxista en camino";
            button_cuartotaxista.ForeColor = Color.Red;
        }

        private void button_quintotaxista_Click(object sender, EventArgs e)
        {
            label_taxi5.Text = "Taxista en camino";
            button_quintotaxista.ForeColor = Color.Red;
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            conteo++;
            label_tiempo1.Text = conteo.ToString();
        }
    }       
}
