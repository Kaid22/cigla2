using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cigla2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 80, b = 40;
        int x, y;
        bool down = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (down)
            {
                Graphics g = CreateGraphics();
                Cigla c = new Cigla();
                c.Postavi(a, b, x, y);
                c.Crtaj(g);
                y -= b;
            }
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = ClientRectangle.Height - b / 2;
            down = true;
        }
    }
}
