using System;
using System.Linq;

namespace Lab2;

// Один раз опишем и каждый раз будем его использовать
public class Checked
{
    // Проверка на int
    public int ReadInt(string promt)
    {
        Console.WriteLine(promt);
        string? input = Console.ReadLine();
        int x = 0;

        while (true)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine
                    ("Ошибка ввода! Нельзя вводить пустую" +
                     " строку. Повторите ввод:");
            }
            else if (int.TryParse(input, out x))
            {
                return x;
            }
            else
            {
                Console.WriteLine("Ошибка " +
                                  "ввода! Введите целое число:");
            }

            input = Console.ReadLine();
        }
    }

    // Проверка на натуральное число
    public int NaturalReadInt(string promt)
    {
        Console.WriteLine(promt);
        string? input = Console.ReadLine();
        int x = 0;

        while (true)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine
                    ("Ошибка ввода! Нельзя вводить " +
                     "пустую строку. Повторите ввод:");
            }
            else if (int.TryParse(input, out x) && x > 0)
            {
                return x;
            }
            else
            {
                Console.WriteLine
                    ("Ошибка ввода! Введите натуральное " +
                     "число больше нуля:");
            }

            input = Console.ReadLine();
        }
    }

    // Проверка на double
    public double ReadDouble(string promt)
    {
        Console.WriteLine(promt);
        string? input = Console.ReadLine();
        double x = 0;

        while (true)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine
                    ("Ошибка ввода! Нельзя вводить " +
                     "пустую строку. Повторите ввод:");
            }
            else if (double.TryParse(input, out x))
            {
                return x;
            }
            else
            {
                Console.WriteLine
                    ("Ошибка ввода! Введите число:");
            }

            input = Console.ReadLine();
        }
    }

    // Проверка на bool
    public bool ReadBool(string promt)
    {
        Console.WriteLine(promt);
        string? input = Console.ReadLine();
        bool x = false;

        while (true)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine
                    ("Ошибка ввода! Нельзя вводить " +
                     "пустую строку. Повторите ввод:");
            }
            else if (bool.TryParse(input, out x))
            {
                return x;
            }
            else
            {
                Console.WriteLine
                    ("Ошибка ввода! Введите true или false:");
            }

            input = Console.ReadLine();
        }
    }

    // Проверка на string
    public string ReadString(string promt)
    {
        Console.WriteLine(promt);
        string? input = Console.ReadLine();

        while (true)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine
                    ("Ошибка ввода! Строка не должна " +
                     "быть пустой. Повторите ввод:");
            }

            input = Console.ReadLine();
        }
    }
    
    // Проверка на ввод имени
    public string ReadName(string promt)
    {
        while (true)
        {
            Console.WriteLine(promt);
            string name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name) &&
                !name.Any(char.IsDigit))
            {
                return name;
            }

            Console.WriteLine
                ("Ошибка! Имя не должно содержать цифры." +
                 " Попробуйте еще раз.");
        }
    }
}