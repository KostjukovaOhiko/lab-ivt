using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();

            //фон
            g.Clear(Color.LightSkyBlue);
            g.FillRectangle(Brushes.MediumSeaGreen, 0, 375, 800, 150);

            //стебель цветка
            g.FillRectangle(Brushes.GreenYellow, 390, 270, 20, 160);

            //верхушка цветка
            g.FillEllipse(Brushes.Red, 345, 195, 110, 60);                     
            g.FillEllipse(Brushes.Red, 300, 170, 50, 50);
            g.FillEllipse(Brushes.Red, 345, 145, 50, 50);
            g.FillEllipse(Brushes.Red, 397, 145, 50, 50);
            g.FillEllipse(Brushes.Red, 445, 170, 50, 50);
            g.FillEllipse(Brushes.Red, 448, 225, 50, 50);
            g.FillEllipse(Brushes.Red, 303, 227, 50, 50);
            g.FillEllipse(Brushes.Red, 350, 255, 50, 50);
            g.FillEllipse(Brushes.Red, 400, 255, 50, 50);

            //лист цветка 1            
            Point point0 = new Point(300, 275);
            Point point1 = new Point(340, 370);
            Point point2 = new Point(390, 385);
            Point point3 = new Point(390, 340);            
            Point[] points =
            {
               point0, point1, point2, point3
            };
            SolidBrush pen = new SolidBrush(Color.GreenYellow);
            g.FillPolygon(pen, points);

            //лист цветка 2
            Point point4 = new Point(490, 300);
            Point point5 = new Point(460, 390);
            Point point6 = new Point(410, 405);
            Point point7 = new Point(410, 360);            
            Point[] points1 =
            {
                point4, point5, point6, point7
            };
            SolidBrush pen1 = new SolidBrush(Color.GreenYellow);
            g.FillPolygon(pen1, points1);

            //солнце
            g.FillEllipse(Brushes.Gold, 0, 0, 100, 100);
            g.DrawLine(Pens.Gold, 88, 16, 114, 0);
            g.DrawLine(Pens.Gold, 96, 32, 178, 0);
            g.DrawLine(Pens.Gold, 100, 52, 160, 52);
            g.DrawLine(Pens.Gold, 90, 70, 180, 100);
            g.DrawLine(Pens.Gold, 84, 84, 124, 122);
            g.DrawLine(Pens.Gold, 66, 94, 115, 160);
            g.DrawLine(Pens.Gold, 28, 94, 0, 160);
            g.DrawLine(Pens.Gold, 50, 90, 50, 160);
            g.DrawLine(Pens.Gold, 10, 80, 0, 92);
            g.DrawLine(Pens.Gold, 14, 14, 0,0);

            //облако 1
            g.FillEllipse(Brushes.FloralWhite, 240, 50, 90, 60);
            g.FillEllipse(Brushes.FloralWhite, 280, 50, 90, 60);
            g.FillEllipse(Brushes.FloralWhite, 260, 30, 90, 60);

            //облако 2
            g.FillEllipse(Brushes.FloralWhite, 640, 50, 90, 60);
            g.FillEllipse(Brushes.FloralWhite, 680, 50, 90, 60);
            g.FillEllipse(Brushes.FloralWhite, 660, 30, 90, 60);

            //гриб 1
            g.FillEllipse(Brushes.MintCream, 580, 410, 40, 80);

            Rectangle rect = new Rectangle(550, 400, 100, 50);
            g.FillPie(Brushes.Brown, new Rectangle(550, 410, 100, 70), 180, 180);

            //гриб 2
            g.FillEllipse(Brushes.MintCream, 30, 390, 40, 80);

            Rectangle rect1 = new Rectangle(0, 380, 100, 50);
            g.FillPie(Brushes.Brown, new Rectangle(0, 380, 100, 70), 180, 180);

        }
    }
}
