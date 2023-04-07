namespace Lab7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File1.Filter = "(*.jpg)|*.jpg";
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // ������� ���������� fname ���������� ���a
            string fname;
            // ��������� ���������
            File1.ShowDialog();
            // ���������� ���������� ��� �������� ����� ���������� �����
            fname = File1.FileName;
            // ��������� ���� � ������� PictureBox
            Pct.Image = Image.FromFile(fname);
            textBox1.Text = System.IO.Path.GetFileNameWithoutExtension($"{fname}");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            string fname_safe;
            fname_safe = File1.SafeFileName;
            save1.FileName = fname_safe;
            save1.ShowDialog();
            Pct.Image.Save(save1.FileName);
        }
    }
}