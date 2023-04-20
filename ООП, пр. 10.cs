using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считываем с формы требуемые значения 
            double Xmin = double.Parse(textBoxXmin.Text);
            double Xmax = double.Parse(textBoxXmax.Text);
            double Step = double.Parse(textBoxStep.Text);
           
            // Количество точек графика
            double p = (Xmax - Xmin) / Step;
            int count = (int)Math.Ceiling(p) + 1;
            // Массив значений Х - общий для обоих графиков
            double[] x = new double[count];
            // Два массива Y - по одному для каждого графика
            double[] y1 = new double[count];
            double[] y2 = new double[count];

            // Расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                double a = 0.1;
                // Вычисляем значение Х
                x[i] = Xmin + Step * i;
                //Вычисляем значение функций в точке X
                y1[i] = x[i] + Math.Sqrt(Math.Abs(Math.Pow(x[i], 3) + a - a*Math.Exp(x[i])));
                y2[i] = Math.Cos(x[i]);
            }

            // Настраиваем оси графика
            chart.ChartAreas[0].AxisX.Minimum = Xmin;
            chart.ChartAreas[0].AxisX.Maximum = Xmax;
            // Определяем шаг сетки
            chart.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            // Добавляем вычисленные значения в графики
            chart.Series[0].Points.DataBindXY(x, y1);
            chart.Series[1].Points.DataBindXY(x, y2);
        }
    }
}
