using System;

namespace L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            DateTime date1 = DateTime.Now;
            Console.Write($"Привет, {name}, сегодня {date1.ToShortDateString()}");
        }
    }
}
