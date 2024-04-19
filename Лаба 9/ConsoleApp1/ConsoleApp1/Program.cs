using System;

abstract class Message
{
    public string Sender { get; set; }
    public string Receiver { get; set; }

    public abstract void Protocol();
}

abstract class ElectronicMessage : Message
{
    public string Subject { get; set; }
}

class Letter : ElectronicMessage
{
    public string Body { get; set; }

    // Конструктор
    public Letter(string sender, string receiver, string subject, string body)
    {
        Sender = sender;
        Receiver = receiver;
        Subject = subject;
        Body = body;
    }

    // Метод вывода протокола
    public override void Protocol()
    {
        Console.WriteLine($"Отправитель: {Sender}");
        Console.WriteLine($"Получатель: {Receiver}");
        Console.WriteLine($"Тема: {Subject}");
        Console.WriteLine($"Содержание: {Body}");
    }
}

class SMS : Message
{
    public string Text { get; set; }

    public SMS(string sender, string receiver, string text)
    {
        Sender = sender;
        Receiver = receiver;
        Text = text;
    }

    public override void Protocol()
    {
        Console.WriteLine($"Отправитель: {Sender}");
        Console.WriteLine($"Получатель: {Receiver}");
        Console.WriteLine($"Текст: {Text}");
    }
}

class Email : ElectronicMessage
{
    public string Body { get; set; }

    // Конструктор
    public Email(string sender, string receiver, string subject, string body)
    {
        Sender = sender;
        Receiver = receiver;
        Subject = subject;
        Body = body;
    }

    // Метод вывода протокола
    public override void Protocol()
    {
        Console.WriteLine($"Отправитель: {Sender}");
        Console.WriteLine($"Получатель: {Receiver}");
        Console.WriteLine($"Тема: {Subject}");
        Console.WriteLine($"Содержание: {Body}");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Введите данные сообщения:");
        Console.Write("Отправитель: ");
        string letterSender = Console.ReadLine();
        Console.Write("Получатель: ");
        string letterReceiver = Console.ReadLine();
        Console.Write("Тема: ");
        string letterSubject = Console.ReadLine();
        Console.Write("Содержание: ");
        string letterBody = Console.ReadLine();

        Console.WriteLine("\nВведите данные для SMS:");
        Console.Write("Отправитель: ");
        string smsSender = Console.ReadLine();
        Console.Write("Получатель: ");
        string smsReceiver = Console.ReadLine();
        Console.Write("Текст: ");
        string smsText = Console.ReadLine();

        Console.WriteLine("\nВведите данные для Email:");
        Console.Write("Отправитель: ");
        string emailSender = Console.ReadLine();
        Console.Write("Получатель: ");
        string emailReceiver = Console.ReadLine();
        Console.Write("Тема: ");
        string emailSubject = Console.ReadLine();
        Console.Write("Содерджание: ");
        string emailBody = Console.ReadLine();
        Console.WriteLine("");

        Message[] messages = new Message[]
        {
            new Letter(letterSender, letterReceiver, letterSubject, letterBody),
            new SMS(smsSender, smsReceiver, smsText),
            new Email(emailSender, emailReceiver, emailSubject, emailBody)
        };
        foreach (var message in messages)
        {
            message.Protocol();
            Console.WriteLine(); 
        }
    }
}