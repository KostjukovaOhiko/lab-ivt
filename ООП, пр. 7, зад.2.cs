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
            string fileName = TxtFileName.Text; //путь к файлу
            if (File.Exists(fileName))
            {
                File.Delete(fileName); //если файл уже существует - удаляем его
            }

            using (FileStream fs = File.Create(fileName, 1024)) //класс для работы с файлами
            //класс для работы с данными файла в двоичном виде
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                for (var i = 0; i < Lst.Items.Count; i++) //пока не конец списка
                {
                    bw.Write(Lst.Items[i].ToString()); //записываем в файл каждый пункт
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
                //метод PeekChar() возвращает следующий прочитанный символ
                //если символов нет -возвращается - 1
                while (br.PeekChar() != -1)
                {
                    //добавляем в список очередную прочитанную строку
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