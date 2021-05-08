using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        Graphics g;
        Cola cabeza;
        Comida comida;
        int cuadro = 10;
        int xdir = 0, ydir = 0;
        int puntaje = 0;
        Boolean ejex = true, ejey = true;
        public Form1()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
            cabeza = new Cola(10, 10);
            comida = new Comida();
        }
        public void findeJuego()
        {
            xdir = 0;
            ydir = 0;
            puntaje = 0;
            puntos.Text = "0";
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            comida = new Comida();
            MessageBox.Show("Perdiste");
        }
        public void choqueCuerpo()
        {
            Cola temp;
            try
            {
                temp = cabeza.verSiguiente().verSiguiente();
            }
            catch (Exception err)
            {
                temp = null;
            }
            while (temp != null)
            {
                if (cabeza.Interseccion(temp))
                {
                    findeJuego();
                }
                else
                {
                    temp = temp.verSiguiente();
                }
            }
        }

        public void choquePared()
        {
            if (cabeza.getX() < 0 || cabeza.getX() > 760 || cabeza.getY() < 0 || cabeza.getY() > 360)
            {
                findeJuego();
            }
        }

        public void dibujar()
        {
            g.Clear(Color.White);
            cabeza.dibujar(g);
            comida.dibujar(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ejex)
            {
                if (e.KeyCode == Keys.Up)
                {
                    ydir = -cuadro;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    ydir = cuadro;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                }
            }
            if (ejey)
            {
                if (e.KeyCode == Keys.Right)
                {
                    ydir = 0;
                    xdir = cuadro;
                    ejex = true;
                    ejey = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    ydir = 0;
                    xdir = -cuadro;
                    ejex = true;
                    ejey = false;
                }
            }
        }

        public void movimiento()
        {
            cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() + ydir);
        }

        private void bucle_Tick(object sender, EventArgs e)
        {
            dibujar();
            movimiento();
            choqueCuerpo();
            choquePared();

            if (cabeza.Interseccion(comida))
            {
                comida.Colocar();
                cabeza.meter();
                puntaje++;
                puntos.Text = puntaje.ToString();

                label_puntaje_maximo.Text = puntos.Text;
            }
        }
    }
}