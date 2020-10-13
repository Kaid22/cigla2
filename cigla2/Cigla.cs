using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cigla2
{
    class Cigla
    {
        Point o;
        int a, b;
        public void Postavi(int sirina, int visina, Point Gornjileviugao)
        {
            if (sirina >= 0 && visina >= 0)
            {
                a = sirina;
                b = visina;
                o = Gornjileviugao;
            }
            else
            {
                throw new Exception("Negativne vrednosti");
            }
        }
        public void Postavi(int sirina, int visina, int x,int y)
        {
            if (sirina >= 0 && visina >= 0)
            {
                a = sirina;
                b = visina;
                o = new Point(x,y);
            }
            else
            {
                throw new Exception("Negativne vrednosti");
            }
        }
        public void Crtaj(Graphics g)
        {
            Pen olovka = new Pen(Color.Red, 3);
            Brush cetka = new SolidBrush(Color.PeachPuff);
            g.DrawRectangle(olovka, o.X-a/2, o.Y-b/2, a, b);
            g.FillRectangle(cetka, o.X-a/2, o.Y-b/2, a, b);

        }
    }
}
