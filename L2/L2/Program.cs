using System;

namespace L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите  максимальную и минимальную температуру за день");

            Console.Write("Минимальная:");
            int Low = Convert.ToInt32(Console.ReadLine());

            Console.Write("Максимальная:");
            int High = Convert.ToInt32(Console.ReadLine());

            int Aver = (Low+High)/2;
            Console.WriteLine($"Средняя температура за день: {Aver}");

            Console.WriteLine("Какой сейчас месяц?");
            string Month = Console.ReadLine();

            if (Month == "Декабрь" || Month == "Январь" || Month == "Февраль" && Aver>0)
            {
                Console.WriteLine(Month);
                Console.WriteLine("Дождливая зима.");
            }
            else
            {
                Console.WriteLine(Month);
            }

        }
    }
}
