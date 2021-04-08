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
        
        De Kelvin a Celsius: CELSIUS = KELVIN – 273.15
        De Kelvin a Farenheit: FARENHEIT = ((KELVIN – 273.15) * 9/5 ) + 32
        De Celsius a Kelvin: KELVIN = CELSIUS + 273.15
         De Farenheit a Celsius: CELSIUS = (FARENHEIT – 32) * (5/9)   
         De Farenheit a Kelvin: KELVIN = (FARENHEIT – 32) *(5 / 9) + 273.15
         De Celsius a Farenheit: FARENHEIT = (CELSIUS) * 9 / 5 + 32
        Fuente: https://www.ejemplos.co/ejemplos-de-conversion-de-temperatura/#ixzz6qS0DB7Y
         */

        private void Temperatura_Load(object sender, EventArgs e)
        {

        }
    }
}
