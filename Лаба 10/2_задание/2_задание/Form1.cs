namespace _2_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Выберите время года";
            string[] items = ["Зима", "Весна", "Лето", "Осень"];
            comboBox1.Items.AddRange(items);
            button1.Text = "Вывести месяца";
            button1.Click += (o, e) => Months(Convert.ToString(comboBox1.SelectedItem));

            void Months(string t)
            {
                switch (t)
                {
                    case "Зима":
                        MessageBox.Show("Список месяцев: \nДекабрь \nЯнварь \nФевраль");
                        break;
                    case "Весна":
                        MessageBox.Show("Список месяцев: \nМарт \nАпрель \nМай");
                        break;
                    case "Лето":
                        MessageBox.Show("Список месяцев: \nИюнь \nИюль \nАвгуст");
                        break;
                    case "Осень":
                        MessageBox.Show("Список месяцев: \nСентябрь \nОктябрь \nНоябрь");
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
