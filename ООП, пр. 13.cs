using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Lab_13
{

    public partial class Form1 : Form
    {
        private readonly Pen mainPen_ = new Pen(Color.Blue, 4);
        private Bitmap bmp_;
        private Point currentPoint_;
        private Graphics g;
        private Point previousPoint_;
        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Описываем объект класса OpenFileDialog
            var dialog = new OpenFileDialog
            {
                // Задаем расширения файлов
                Filter = "Image files (*.BMP, *.JPG, \" + \"*.GIF, *.PNG)|*.bmp;*.jpg;*.gif;*.png"
            };         

            // Вызываем диалог и проверяем выбран ли файл
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            // Загружаем изображение из выбранного файла
            var image = Image.FromFile(dialog.FileName);
            this.pictureBox1.Width = image.Width;
            this.pictureBox1.Height = image.Height;
            // Создаем и загружаем изображение в формате bmp84
            this.bmp_ = new Bitmap(image);
            // Записываем изображение в pictureBox1
            this.pictureBox1.Image = this.bmp_;
            // Подготавливаем объект Graphics для рисования
            this.g = Graphics.FromImage(this.pictureBox1.Image);
            this.g.SmoothingMode = SmoothingMode.AntiAlias;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Записываем в предыдущую точку текущие координаты
            this.previousPoint_ = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Проверяем нажата ли левая кнопка мыши
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            // Запоминаем текущее положение курсора мыши
            this.currentPoint_ = new Point(e.X, e.Y);
            // Соеденяем линией предыдущую точку с текущей

            this.g.DrawLine(this.mainPen_, this.previousPoint_, this.currentPoint_);
            // Текущее положение курсора - в previousPoint_
            this.previousPoint_ = this.currentPoint_;
            // Принудительно вызываем перерисовку
            this.pictureBox1.Invalidate();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            // Описываем и порождаем объект savedialog
            var savedialog = new SaveFileDialog
            {
                Title = "Сохранить картинку как...",
                OverwritePrompt = true,
                CheckPathExists = true,
                Filter =
                    "Bitmap File(*.bmp)|*.bmp|" +
                    "GIF File(*.gif)|*.gif|" +
                    "JPEG File(*.jpg)|*.jpg|" +
                    "PNG File(*.png)|*.png"
            };
            // Показываем диалог и проверяем задано ли имя файла
            if (savedialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var format = ImageFormat.Jpeg;
            switch (Path.GetExtension(savedialog.FileName))
            {
                case "bmp":
                    format = ImageFormat.Bmp;
                    break;
                case "jpg":
                    format = ImageFormat.Jpeg;
                    break;
                case "gif":
                    format = ImageFormat.Gif;
                    break;
                case "tif":
                    format = ImageFormat.Tiff;
                    break;
                case "png":
                    format = ImageFormat.Png;
                    break;
                default:
                    break;
            }
            this.bmp_.Save(savedialog.FileName, format);
        }

        private void bChangePixels_Click(object sender, EventArgs e)
        {
            // Циклы для перебора всех пикселей на изображении
            for (var x = 1; x < this.bmp_.Width; x++)
            {
                for (var y = 1; y < this.bmp_.Height; y++)
                {
                    var c = this.bmp_.GetPixel(x, y);
                    if (c.B >= 200 && (c.R + c.G) <= 200)
                    {
                        this.bmp_.SetPixel(x, y, Color.Red);
                    }
                }
                this.Refresh();
            }
        }

       
    }
}
