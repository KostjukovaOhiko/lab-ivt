using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace Lab7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string fileName = TxtFileName.Text; //���� � �����
            if (File.Exists(fileName))
            {
                File.Delete(fileName); //���� ���� ��� ���������� - ������� ���
            }

            using (FileStream fs = File.Create(fileName, 1024)) //����� ��� ������ � �������
            //����� ��� ������ � ������� ����� � �������� ����
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                for (var i = 0; i < Lst.Items.Count; i++) //���� �� ����� ������
                {
                    bw.Write(Lst.Items[i].ToString()); //���������� � ���� ������ �����
                }
                bw.Close();
                fs.Close();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Lst.Items.Add(Txt.Text);
            Txt.Clear();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            string fileName = TxtFileName.Text;
            LstFromfile.Items.Clear();
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                //����� PeekChar() ���������� ��������� ����������� ������
                //���� �������� ��� -������������ - 1
                while (br.PeekChar() != -1)
                {
                    //��������� � ������ ��������� ����������� ������
                    LstFromfile.Items.Add(br.ReadString());
                }
                br.Close();
                fs.Close();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}