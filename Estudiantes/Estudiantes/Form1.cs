using Logica;
using Logica.Libreria;
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
    public partial class Form1 : Form
    {
        private L_Estudiantes estudiantes;
        private Librerias librerias;

        public Form1()
        {
            InitializeComponent();
            librerias = new Librerias();

            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBox_Matricula);
            listTextBox.Add(textBox_Nombre);
            listTextBox.Add(textBox_Apellido);
            listTextBox.Add(textBox_Email);

            var listLabel = new List<Label>();
            listLabel.Add(label_matricula);
            listLabel.Add(label_nombre);
            listLabel.Add(label_Apellido);
            listLabel.Add(label_Email);
            listLabel.Add(label_pagina);

            Object[] objetos = { 
                PictureBox_imagen,
                Properties.Resources.user_3331257_1280,
                dataGridView1,
                numericUpDown1,

            };

            estudiantes = new L_Estudiantes(listTextBox, listLabel, objetos);
        }

        private void PictureBox_imagen_Click(object sender, EventArgs e)
        {
            librerias.upload_Image.Cargar_Imagen(PictureBox_imagen);
        }

        private void textBox_Matricula_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Matricula.Text.Equals(""))
            {
                label_matricula.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                label_matricula.ForeColor = Color.Green;
                label_matricula.Text = "Matricula";
            }
        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text.Equals(""))
            {
                label_nombre.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                label_nombre.ForeColor = Color.Green;
                label_nombre.Text = "Nombre";
            }
        }

        private void textBox_Apellido_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Apellido.Text.Equals(""))
            {
                label_Apellido.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                label_Apellido.ForeColor = Color.Green;
                label_Apellido.Text = "Apellido";
            }
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Email.Text.Equals(""))
            {
                label_Email.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                label_Email.ForeColor = Color.Green;
                label_Email.Text = "E-mail";
            }

        }

        private void textBox_Matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            librerias.textBoxEvent.numeric_key_press(e);
        }

        private void textBox_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            librerias.textBoxEvent.text_Box_Event(e);
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            estudiantes.Registrar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            estudiantes.Search_Estudiante(textBox1.Text);
        }       

        private void boton_primero_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("primero");
        }

        private void boton_anterior_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("anterior");
        }

        private void boton_siguiente_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("siguiente");

        }

        private void boton_ultimo_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("ultimo");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            estudiantes.Registro_por_Pagina();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows.Count != 0)
                estudiantes.GetEstudiates();
            
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
                estudiantes.GetEstudiates();

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            estudiantes.Restablecer();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            estudiantes.eliminar();
        }

        private void boton_de_menu_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == true)
            {
                groupBox2.Visible = false;
                groupBox3.Width = 995;
                groupBox3.Location = new Point(100, 127);
                //361; 127
            }
            else
            {
                groupBox2.Visible = true;
                groupBox3.Width = 775;
                groupBox3.Location = new Point(360, 127);
            }
        }

    }
}
