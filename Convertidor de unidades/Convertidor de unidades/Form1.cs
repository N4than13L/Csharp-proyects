using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor_de_unidades
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void button_densidad_Click(object sender, EventArgs e)
        {
            Densidad den = new Densidad();
            den.Show();
        }

        private void button_temperatura_Click(object sender, EventArgs e)
        {
            Temperatura temp = new Temperatura();
            temp.Show();
        }

        private void button_velocidad_Click(object sender, EventArgs e)
        {
            Velocidad vel = new Velocidad();
            vel.Show();
        }

        private void button_programación_Click(object sender, EventArgs e)
        {
            Programacion prog = new Programacion();
            prog.Show();
        }

        private void button_distancia_Click(object sender, EventArgs e)
        {
            Distancia dis = new Distancia();
            dis.Show();
        }
    }

}

