using System;
using System.Windows.Forms;

namespace Convertidor_de_unidades
{
    public partial class Velocidad : Form
    {
        public Velocidad()
        {
            InitializeComponent();
        }

        

        private void textBox_Velocidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            int vel = int.Parse(textBox_Velocidad.Text);

            if (vel != null)
            {
                if (radioButton_kmh_a_ms.Checked.Equals(true))
                {
                    var formula = vel * 5 / 18;
                    label_Resultado.Text = Convert.ToString(formula);
                }
                else if (radioButton_ms_a_kmh.Checked.Equals(true))
                {
                    label_Resultado.Text = Convert.ToString(vel * 18 / 5);
                }
                
            }
        }
    }
}
