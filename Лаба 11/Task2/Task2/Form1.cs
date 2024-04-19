namespace Task2
{
    public partial class Form1 : Form
    {
        string[] marsh = ["1", "3", "6", "16", "17", "32", "140", "12", "54", "56"];
        string[] nach = ["Томск", "Новосибирск", "Кемерово", "Тайга", "Асино", "Вашингтон", "Юрга", "Алтай"];
        string[] kon = ["Москва", "Питер", "Челябинск", "Калининград", "Иваново", "Нижний Новгород"];
        string[] wr = new string[10];
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Введите номер маршрута";
            button1.Text = "Вывести данные маршрута";
            Random n = new Random();
            string row;
            for (int i = 0; i < 10; i++)
            {
                row = $"{nach[n.Next(nach.Length)]} - {kon[n.Next(kon.Length)]} - {marsh[i]}";
                textBox1.Text += row + Environment.NewLine;
                wr[i] = row;
            }
            string filename = "B:\\TUSUR\\ОПР\\Лаба 11\\1.txt";
            using (StreamWriter sw = new StreamWriter(filename))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(wr[i]);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int c = 0;
            string n = textBox3.Text;
            int ind = 0;
            for (int i = 0; i < marsh.Length; i++)
            {
                if (marsh[i] == n)
                {
                    c++;
                    ind = i;
                }
            }
            if (c == 0)
            {
                MessageBox.Show("Данного маршрута нет");
            }
            else 
            {
                MessageBox.Show($"{wr[ind]}");
            }
        }
    }
}
