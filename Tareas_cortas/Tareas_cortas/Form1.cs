using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareas_cortas
{
    public partial class Form1 : Form
    {
        string valores = "";
        int enumeracion = 0;

        public Form1()
        {
            InitializeComponent();
        }
        // cuadrante 1 datos.
        public void Cuadrante_1_datos()
        {
            if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "1")
            {
                valores = textBox_nombre_tarea.Text;
                checkBoxCuadrante1_1.Text = Convert.ToString(enumeracion = 1) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "2")
            {
                valores = textBox_nombre_tarea.Text;
                checkBoxCuadrante1_2.Text = Convert.ToString(enumeracion = 2) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "3")
            {
                valores = textBox_nombre_tarea.Text;
                checkBoxCuadrante1_3.Text = Convert.ToString(enumeracion = 3) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "4")
            {
                valores = textBox_nombre_tarea.Text;
                checkBoxCuadrante1_4.Text = Convert.ToString(enumeracion = 4) + "-" + " " + valores;

            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "5")
            {
                valores = textBox_nombre_tarea.Text;
                checkBoxCuadrante1_5.Text = Convert.ToString(enumeracion = 5) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "6")
            {
                valores = textBox_nombre_tarea.Text;
                checkBoxCuadrante1_6.Text = Convert.ToString(enumeracion = 6) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "7")
            {
                valores = textBox_nombre_tarea.Text;
                checkBoxCuadrante1_7.Text = Convert.ToString(enumeracion = 7) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "8")
            {
                valores = textBox_nombre_tarea.Text;
                checkBoxCuadrante1_8.Text = Convert.ToString(enumeracion = 8) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "9")
            {
                valores = textBox_nombre_tarea.Text;
                checkBoxCuadrante1_9.Text = Convert.ToString(enumeracion = 9) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "10")
            {
                valores = textBox_nombre_tarea.Text;
                checkBoxCuadrante1_10.Text = Convert.ToString(enumeracion = 10) + "-" + " " + valores;
            }
        }

        // cuadrante 2 datos.
        public void Cuadrante_2_datos()
        {
            if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_2_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "1")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_2_1.Text = Convert.ToString(enumeracion = 1) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_2_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "2")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_2_2.Text = Convert.ToString(enumeracion = 2) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_2_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "3")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_2_3.Text = Convert.ToString(enumeracion = 3) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_2_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "4")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_2_4.Text = Convert.ToString(enumeracion = 4) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_2_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "5")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_2_5.Text = Convert.ToString(enumeracion = 5) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_2_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "6")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_2_6.Text = Convert.ToString(enumeracion = 6) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_2_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "7")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_2_7.Text = Convert.ToString(enumeracion = 7) + "-" + " " + valores;

            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_2_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "8")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_2_8.Text = Convert.ToString(enumeracion = 8) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_2_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "9")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_2_9.Text = Convert.ToString(enumeracion = 9) + "-" + " " + valores;

            }else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_2_1.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "10")
             {
                 valores = textBox_nombre_tarea.Text;
                 checkBox_Cuadrante_2_10.Text = Convert.ToString(enumeracion = 10) + "-" + " " + valores;
             }
        }

        // cuadrante 3 datos.
        public void Cuadrante_3_datos()
        {
            if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_3.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "1")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_3_1.Text = Convert.ToString(enumeracion = 1) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_3.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "2")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_3_2.Text = Convert.ToString(enumeracion = 2) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_3.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "3")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_3_3.Text = Convert.ToString(enumeracion = 3) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_3.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "4")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_3_4.Text = Convert.ToString(enumeracion = 4) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_3.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "5")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_3_5.Text = Convert.ToString(enumeracion = 5) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_3.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "6")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_3_6.Text = Convert.ToString(enumeracion = 6) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_3.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "7")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_3_7.Text = Convert.ToString(enumeracion = 7) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_3.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "8")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_3_8.Text = Convert.ToString(enumeracion = 8) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_3.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "9")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_3_9.Text = Convert.ToString(enumeracion = 9) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_3.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "10")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_3_10.Text = Convert.ToString(enumeracion = 10) + "-" + " " + valores;
            }
        }

        // cuadrante 4 datos
        public void Cuadrante_4_datos()
        {
            if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_4.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "1")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_4_1.Text = Convert.ToString(enumeracion = 1) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_4.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "2")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_4_2.Text = Convert.ToString(enumeracion = 2) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_4.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "3")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_4_3.Text = Convert.ToString(enumeracion = 3) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_4.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "4")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_4_4.Text = Convert.ToString(enumeracion = 4) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_4.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "5")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_4_5.Text = Convert.ToString(enumeracion = 5) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_4.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "6")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_4_6.Text = Convert.ToString(enumeracion = 6) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_4.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "7")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_4_7.Text = Convert.ToString(enumeracion = 7) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_4.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "8")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_4_8.Text = Convert.ToString(enumeracion = 8) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_4.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "9")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_4_9.Text = Convert.ToString(enumeracion = 9) + "-" + " " + valores;
            }
            else if (textBox_nombre_tarea.Text != null && radioButton_Cuadrante_4.Checked.Equals(true)
                && textBox_tipo_tarea.Text == "10")
            {
                valores = textBox_nombre_tarea.Text;
                checkBox_Cuadrante_4_10.Text = Convert.ToString(enumeracion = 10) + "-" + " " + valores;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Cuadrante_1_datos();
            Cuadrante_2_datos();
            Cuadrante_3_datos();
            Cuadrante_4_datos();

            int validacion = int.Parse(textBox_tipo_tarea.Text);
            if (validacion > 10)
            {
                MessageBox.Show("El numero maximo es 10 por cada cuadrante");
            }
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            Ayuda help = new Ayuda();
            help.Show();
        }
    }
}
