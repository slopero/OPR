namespace WinFormsApp1
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            label2.Text = "Вычисление при помощи цикла";
            label3.Text = "Вычисление по формуле";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Maximum = 100;
            int n = hScrollBar1.Value;
            textBox3.Text = n.ToString();
            int sum1 = 0, sum2;
            for (int i = 1; i <= n; i++)
            {
                sum1 += (3 * i) - 2;
            }
            sum2 = n * (3 * n - 1) / 2;
            textBox1.Text = sum1.ToString();
            textBox2.Text = sum2.ToString();
        }
    }
}
