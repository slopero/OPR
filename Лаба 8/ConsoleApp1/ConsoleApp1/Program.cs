/*int Valid(string n)
{
    int ch;
    if (int.TryParse(n, out ch) == true)
    {
        return 1;
    }
    else 
    {
        return 0;
    }
}
string choice;
string h1, h2, m1, m2, s1, s2;
Console.WriteLine("Введите момент времени");
Console.WriteLine("Введите часы");
h1 = Console.ReadLine();
Console.WriteLine("Введите минуты");
m1 = Console.ReadLine();
Console.WriteLine("Введите секунды");
s1 = Console.ReadLine();
while (Valid(h1) + Valid(m1) + Valid(s1) != 3)
{
    Console.WriteLine("Вы ввели неверно, заново");
    Console.WriteLine("Введите часы");
    h1 = Console.ReadLine();
    Console.WriteLine("Введите минуты");
    m1 = Console.ReadLine();
    Console.WriteLine("Введите секунды");
    s1 = Console.ReadLine();
}
Time time1 = new Time(Convert.ToInt32(h1), Convert.ToInt32(m1), Convert.ToInt32(s1));
int res1 = time1.Result();
Console.WriteLine("Выберите действие");
Console.WriteLine("1.Вычисление разницы между двумя моментами времени \n2.Сложение времени с секундами");
Console.WriteLine("3.Вычитание из времени секунд \n4.Сравнение времени \n5.Перевод в секунды");
Console.WriteLine("6.Перевод в минуты");
choice = Console.ReadLine();
while (Valid(choice) != 1)
{
    Console.WriteLine("Вы ввели неверное значение");
    choice = Console.ReadLine();
}

switch (Convert.ToInt32(choice))
{
    case 1:
        Console.WriteLine("Введите момент времени");
        Console.WriteLine("Введите часы");
        h2 = Console.ReadLine();
        Console.WriteLine("Введите минуты");
        m2 = Console.ReadLine();
        Console.WriteLine("Введите секунды");
        s2 = Console.ReadLine();
        while (Valid(h2) + Valid(m2) + Valid(s2) != 3)
        {
            Console.WriteLine("Вы ввели неверно, заново");
            Console.WriteLine("Введите часы");
            h2 = Console.ReadLine();
            Console.WriteLine("Введите минуты");
            m2 = Console.ReadLine();
            Console.WriteLine("Введите секунды");
            s2 = Console.ReadLine();
        }
        Time time2 = new Time(Convert.ToInt32(h2), Convert.ToInt32(m2), Convert.ToInt32(s2));
        int res2 = time2.Result();
        Console.WriteLine($"Разница между моментами времени {Math.Abs(res1 - res2)}");
        break;
    case 2:
        Console.WriteLine("Введите секунды");
        string sec_plus = Console.ReadLine();
        while (Valid(sec_plus) != 1)
        {
            Console.WriteLine("Вы ввели неверно, введите заново");
            sec_plus = Console.ReadLine();
        }
        Console.WriteLine($"Получившееся время = {Math.Abs(res1 + Convert.ToInt32(sec_plus))}");
        break;
    case 3:
        Console.WriteLine("Введите секунды");
        string sec_minus = Console.ReadLine();
        while (Valid(sec_minus) != 1)
        {
            Console.WriteLine("Вы ввели неверно, введите заново");
            sec_minus = Console.ReadLine();
        }
        Console.WriteLine($"Получившееся время = {Math.Abs(res1 - Convert.ToInt32(sec_minus))}");
        break;
    case 4:
        string h3, m3, s3;
        Console.WriteLine("Введите момент времени");
        Console.WriteLine("Введите часы");
        h3 = Console.ReadLine();
        Console.WriteLine("Введите минуты");
        m3 = Console.ReadLine();
        Console.WriteLine("Введите секунды");
        s3 = Console.ReadLine();
        while (Valid(h3) + Valid(m3) + Valid(s3) != 3)
        {
            Console.WriteLine("Вы ввели неверно, заново");
            Console.WriteLine("Введите часы");
            h3 = Console.ReadLine();
            Console.WriteLine("Введите минуты");
            m3 = Console.ReadLine();
            Console.WriteLine("Введите секунды");
            s3 = Console.ReadLine();
        }
        Time time3 = new Time(Convert.ToInt32(h3), Convert.ToInt32(m3), Convert.ToInt32(s3));
        int res3 = time3.Result();
        if (res1 > res3)
        {
            Console.WriteLine("Первый момент времени больше, чем второй");
        }
        else
        {
            Console.WriteLine("Первый момент времени меньше, чем второй");
        }
        break;
    case 5:
        Console.WriteLine($"Время в секундах = {res1}");
        break;
    case 6:
        int min = time1.ToMin();
        Console.WriteLine($"Время в минутах = {min}");
        break;
}

class Time
{
    int hour;
    int minute; 
    int second;
    public Time(int hour, int minute, int second)
    {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }
    public int Result()
    {
        return 3600 * hour + 60 * minute + second;
    }
    public int ToMin()
    {
        return 60*hour + minute + Convert.ToInt32(second/60);
    }
}
*/


// Задание 2


using System;

class Binary2
{
    
    public static double Input()
    {
        int Valid(string n)
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
        Console.WriteLine("Введите двоичное число (с дробной частью): ");
        string binaryStr = Console.ReadLine();
        while (Valid(binaryStr) != 1)
        {
            Console.WriteLine("Вы ввели неверное значения, введите заново");
            binaryStr = Console.ReadLine();
        }
        double binaryNum = ConvertToDecimal(binaryStr);
        return binaryNum;
    }
    public static void Output(double number)
    {
        Console.WriteLine($"Двоичное число: {number}");
    }

    public static double Subtract(double num1, double num2)
    {
        double result = num1 - num2;
        return result;
    }

    public static double Divide(double dividend, double divisor)
    {
        if (divisor == 0)
        {
            Console.WriteLine("Деление на ноль невозможно.");
            return 0;
        }
        double result = dividend / divisor;
        return result;
    }
    private static double ConvertToDecimal(string binaryStr)
    {
        string[] parts = binaryStr.Split(',');
        string integerPart = parts[0];
        string fractionalPart = "0";

        if (parts.Length > 1)
        {
            fractionalPart = parts[1];
        }

        double integer = Convert.ToInt32(integerPart, 2);
        double fractional = 0;

        for (int i = 0; i < fractionalPart.Length; i++)
        {
            if (fractionalPart[i] == '1')
            {
                fractional += 1.0 / Math.Pow(2, i + 1);
            }
        }
        return integer + fractional;
    }

    static void Main(string[] args)
    {
        double n1, n2;
        Console.WriteLine("Введите 1-ое число");
        n1 = Input();
        Console.WriteLine("Введите 2-ое число");
        n2 = Input();
        Console.WriteLine("1-ое число");
        Output(n1);
        Console.WriteLine("2-ое число");
        Output(n2);
        double diff = Subtract(n1, n2);
        Console.WriteLine($"Разность = {diff}");
        double del = Divide(n1, n2);
        Console.WriteLine($"Деление = {del}");
    }
}

