using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int valid(string n)
            {
                double ch;
                if (double.TryParse(n, out ch) == true)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            InitializeComponent();
            label1.Text = "Введите высоту";
            label1.Size = new Size { Width = 200, Height = 30 };
            button1.Text = "Узнать время";
            button1.Click += (o,e) => Click();
            void Click()
            {
                double h;
                double res = 0;
                if (valid(textBox1.Text) == 1)
                {
                    h = Convert.ToDouble(textBox1.Text);
                    res = Math.Sqrt(2 * h / 9.8);
                    MessageBox.Show($"Получившееся время = {res}");
                }
                else
                {
                    MessageBox.Show("Вы введи неверные данные, введите число");
                }
            }
        }
    }
}
