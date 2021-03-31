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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        
        De Kelvin a Celsius: CELSIUS = KELVIN – 273.15
        De Kelvin a Farenheit: FARENHEIT = ((KELVIN – 273.15) * 9/5 ) + 32


Fuente: https://www.ejemplos.co/ejemplos-de-conversion-de-temperatura/#ixzz6qS0DB7YX
         */

        private void boton_Calcular_Click(object sender, EventArgs e)
        {
            double Temp = double.Parse(txt_valores.Text);
            if (Temp != null)
            {
                if (Celcius_Kelvin.Checked == true)
                {
                    //De Celsius a Kelvin: KELVIN = CELSIUS + 273.15
                    Resultado.Text = Convert.ToString(Temp + 273.15 + "°K");
                }
                else if (farenheit_celcius.Checked == true)
                {
                    //De Farenheit a Celsius: CELSIUS = (FARENHEIT – 32) * (5/9) 

                    double uno = (double)Convert.ToDecimal(Temp - 32 * 5 / 9);
                    Resultado.Text = Convert.ToString(uno + "°F");

                }
                else if (farenheit_a_kelvin.Checked == true)
                {
                   //De Farenheit a Kelvin: KELVIN = (FARENHEIT – 32) *(5 / 9) + 273.15


                }
            }
            
           

            //De Celsius a Farenheit: FARENHEIT = (CELSIUS) * 9 / 5 + 32


        }

        private void txt_valores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

       
    }
}
