namespace Секундомер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TmrSecundomer_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(TxtSeconds.Text);
            int tmp2 = Int32.Parse(TxtMinutes.Text);
            tmp += 1;
            TxtSeconds.Text = tmp.ToString();

            if (tmp == 60)
            {
                tmp2 += 1;
                TxtMinutes.Text = tmp2.ToString();
                TxtSeconds.Text = 0.ToString();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            
            TmrSecundomer.Enabled = !TmrSecundomer.Enabled;

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TmrSecundomer.Stop();
            TxtMinutes.Text = "0";
            TxtSeconds.Text = "0";
        }
    }
}