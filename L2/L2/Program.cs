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

                    int Aver = (Low + High) / 2;
                    Console.WriteLine($"Средняя температура за день: {Aver}");

                    //2
                    Console.WriteLine("Введите номер месяца");
                    int Month = Convert.ToInt32(Console.ReadLine());

                    if (Month == 12 && Aver > 0)
                    {
                        Console.WriteLine("Декабрь.");
                        Console.WriteLine("Дождливая зима.");
                    }
                    else if (Month == 12 && Aver <= 0)
                    {
                        Console.WriteLine("Декабрь.");
                    }
                    else if (Month == 1 && Aver > 0)
                    {
                        Console.WriteLine("Январь.");
                        Console.WriteLine("Дождливая зима.");
                    }
                    else if (Month == 1 && Aver <= 0)
                    {
                        Console.WriteLine("Январь.");
                    }
                    else if (Month == 2 && Aver > 0)
                    {
                        Console.WriteLine("Февраль.");
                        Console.WriteLine("Дождливая зима.");
                    }
                    else if (Month == 2 && Aver <= 0)
                    {
                        Console.WriteLine("Февраль.");
                    }
                    else if (Month == 3)
                    {
                        Console.WriteLine("Март.");
                    }
                    else if (Month == 4)
                    {
                        Console.WriteLine("Апрель.");
                    }
                    else if (Month == 5)
                    {
                        Console.WriteLine("Май.");
                    }
                    else if (Month == 6)
                    {
                        Console.WriteLine("Июнь.");
                    }
                    else if (Month == 7)
                    {
                        Console.WriteLine("Июль.");
                    }
                    else if (Month == 8)
                    {
                        Console.WriteLine("Август.");
                    }
                    else if (Month == 9)
                    {
                        Console.WriteLine("Сентябрь.");
                    }
                    else if (Month == 10)
                    {
                        Console.WriteLine("Октябрь.");
                    }
                    else if (Month == 11)
                    {
                        Console.WriteLine("Ноябрь.");
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
                    DateTime date1 = new DateTime(2015, 7, 20);

                    Console.WriteLine($"******************************\n                              \n.......Касоовый чек № {nomercheka}.......\nПродукт...................Цена\n                              \n{product1}..................{price1}\n{product2}....................{price2}\n                              \nДата покупки: {date1.ToShortDateString()}......\n                              \n******************************");

                    break;
                

                    //6

            }
        }
    }
}
