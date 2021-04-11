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
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        /*
        Fuente: https://www.ejemplos.co/ejemplos-de-conversion-de-temperatura/#ixzz6qS0DB7Y
        En este enlace se encuentran las formulas oficiales para hacer este programa.  
         */
        private void textBox_Temperatura_KeyPress(object sender, KeyPressEventArgs e)
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
            double temp = double.Parse(textBox_Temperatura.Text);

            if(temp != null)
            {
                if (radioButton_Kel_a_Cel.Checked == true)
                {
                    //De Kelvin a Celsius: CELSIUS = KELVIN – 273.15
                    label_resultado.Text = Convert.ToString(temp - 273.15);
                }
                else if (radioButton_Kel_a_Far.Checked == true)
                {
                    //De Kelvin a Farenheit: FARENHEIT = ((KELVIN – 273.15) * 9/5 ) + 32
                    label_resultado.Text = Convert.ToString(((temp - 273.15) * 9/5) + 32);
                }
                else if (radioButton_Cel_a_Kel.Checked == true)
                {
                    //De Celsius a Kelvin: KELVIN = CELSIUS + 273.15
                    label_resultado.Text = Convert.ToString(temp + 273.15);
                }
                else if (radioButton_Far_a_Cel.Checked.Equals(true))
                {
                    //De Farenheit a Celsius: CELSIUS = (FARENHEIT – 32) * (5/9) 
                    label_resultado.Text = Convert.ToString((temp - 32) * 5 / 9);
                }
                else if (radioButton_Far_a_Kel.Checked.Equals(true))
                {
                    //De Farenheit a Kelvin: KELVIN = (FARENHEIT – 32) *(5 / 9) + 273.15
                    label_resultado.Text = Convert.ToString((temp - 32) * 5 / 9 + 273.15);
                }
                else if (radioButton_Cel_a_Far.Checked.Equals(true))
                {
                    //De Celsius a Farenheit: FARENHEIT = (CELSIUS) * 9 / 5 + 32
                    label_resultado.Text = Convert.ToString((temp) * 9 / 5 + 32);
                }
            }
        }

    }
}
