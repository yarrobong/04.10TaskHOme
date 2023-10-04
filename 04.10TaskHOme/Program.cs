using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsSmiley(string input)
    {
        // Паттерн смайлика
        string pattern = @"^[;:]+-*[()\[\]]+$";

        // Создаем регулярное выражение и проверяем строку
        return Regex.IsMatch(input, pattern);
    }

    static void Main()
    {
        Console.Write("Введите смайлик: ");
        string input = Console.ReadLine();
        if (IsSmiley(input))
        {
            Console.WriteLine("Это смайлик!");
        }
        else
        {
            Console.WriteLine("Это не смайлик.");
        }
    }
}
