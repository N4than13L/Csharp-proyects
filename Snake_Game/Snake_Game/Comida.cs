using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Comida : objeto
    {
        public Comida()
        {
            this.x = generar(78);
            this.y = generar(39);
        }

        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), this.x, this.y, this.ancho, this.ancho);
        }

        public void Colocar()
        {
            this.x = generar(78);
            this.y = generar(39);

        }


        public int generar(int n)
        {
            Random ramdom = new Random();
            int num = ramdom.Next(0, n) * 10;
            return num;
        }
    }
}
