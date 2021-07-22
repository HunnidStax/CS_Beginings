using System;

namespace L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите:\n1 - для вывода 1, 2 и 5 задания\n2 - для вывода 3 задания\n3 - для вывода 4 задания\n4 - для вывода 6 задания");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    //1
                    Console.WriteLine("Введите  максимальную и минимальную температуру за день");

                    Console.Write("Минимальная:");
                    int Low = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Максимальная:");
                    int High = Convert.ToInt32(Console.ReadLine());

                    Aver = (Low + High) / 2;
                    Console.WriteLine($"Средняя температура за день: {Aver}");

                    //2
                    Console.WriteLine("Какой сейчас месяц?");
                    string Month = Console.ReadLine();

                    if (Month == "Декабрь" || Month == "Январь" || Month == "Февраль" && Aver > 0)
                    {
                        Console.WriteLine(Month);
                        Console.WriteLine("Дождливая зима.");
                    }
                    else
                    {
                        Console.WriteLine(Month);
                    }

                    break;

                case 2:

                    //3
                    Console.WriteLine("Введите число:");
                    int digit = Convert.ToInt32(Console.ReadLine());

                    if (digit % 2 == 0)
                    {
                        Console.WriteLine($"Число {digit} четное.");
                    }
                    else
                    {
                        Console.WriteLine($"Число {digit} нечетное.");
                    }

                    break;

                case 3:

                    //4
                    int nomercheka = 4;
                    string product1 = "Молоко";
                    double price1 = 51.90;
                    string product2 = "Хлеб";
                    double price2 = 33.50;

                    Console.WriteLine($"******************************\n                              \n.......Касоовый чек № {nomercheka}.......\nПродукт...................Цена\n                              \n{product1}..................{price1}\n{product2}....................{price2}\n                              \n******************************");

                    break;
            }
        }
    }
}
