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
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();

            label2.Text = "1- Escribe el nombre de la tarea en el primer cuadrode texto";
            label3.Text = "2- Escribe un valor menor a 10 en el segundo cuadro de texto";
            label4.Text = "3- Selecciona un valor en el en los radiobuttons de la parte derecha";
            label5.Text = "4- Presiona enter";
        }
    }
}
