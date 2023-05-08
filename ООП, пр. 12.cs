using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12
{
    public partial class Form1 : Form
    {

        Graphics gr;
        Pen p;

        Random rand;

        public Form1()
        {
            InitializeComponent();
        }

        void DrawStar(double x, double y)
        {
            int n = 5;
            double R = 25, r = 50;
            double alpha = 0;

            PointF[] points = new PointF[2 * n + 1];
            double a = alpha, da = Math.PI / n, l;
            for (int k = 0; k < 2 * n + 1; k++)
            {
                l = k % 2 == 0 ? r : R;
                points[k] = new PointF((float)(x + l * Math.Cos(a)), (float)(y + l * Math.Sin(a)));
                a += da;
            }
            gr.DrawLines(Pens.White, points);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();

            p = new Pen(Color.Gold);
            rand = new Random();

            int x, y;

            for (int i = 0; i < 15; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawStar(x, y);
            }

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gr.Clear(Color.MidnightBlue);
            int x, y;
            x = rand.Next(60, pictureBox1.Width - 40);
            y = rand.Next(60, pictureBox1.Height - 40);
            DrawStar(x, y);
        }
    }
}
