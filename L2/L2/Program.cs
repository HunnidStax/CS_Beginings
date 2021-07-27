using System;

namespace L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите:\n1 - для вывода 1, 2, 3 и 5 задания\n2 - для вывода 4 задания\n3 - для вывода 6 задания\n");
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
                    
                    //3
                    if (Month % 2 == 0)
                    {
                        Console.WriteLine($"Число {Month} четное.");
                    }
                    else
                    {
                        Console.WriteLine($"Число {Month} нечетное.");
                    }
                    break;

                case 2:

                    //4
                    int nomercheka = 4;
                    string product1 = "Молоко";
                    double price1 = 51.90;
                    string product2 = "Хлеб";
                    double price2 = 33.50;
                    DateTime date1 = new DateTime(2015, 7, 20);

                    Console.WriteLine($"******************************\n                              \n.......Касоовый чек № {nomercheka}.......\nПродукт...................Цена\n                              \n{product1}..................{price1}\n{product2}....................{price2}\n                              \nДата покупки: {date1.ToShortDateString()}......\n                              \n******************************");

                    break;

                case 3:
                    //6

                    //дни работы офисов
                    int office1 = 0b1010101;
                    int office2 = 0b0011110;

                    //день недедли
                    int mon = 0b1000000;
                    int tue = 0b0100000;
                    int wen = 0b0010000;
                    int thu = 0b0001000;
                    int fri = 0b0000100;
                    int sat = 0b0000010;
                    int sun = 0b0000001;

                    int cen = mon & office1;
                    int cen2 = mon & office2;
                    int cen3 = tue & office1;
                    int cen4 = tue & office2;
                    int cen5 = wen & office1;
                    int cen6 = wen & office2;
                    int cen7 = thu & office1;
                    int cen8 = thu & office2;
                    int cen9 = fri & office1;
                    int cen10 = fri & office2;
                    int cen11 = sat & office1;
                    int cen12 = sat & office2;
                    int cen13 = sun & office1;
                    int cen14 = sun & office2;

                    Console.WriteLine("В какие дни работает первый офис");
                    Console.WriteLine($"Понедельник {cen == mon}");
                    Console.WriteLine($"Вторник {cen3 == tue}");
                    Console.WriteLine($"Среда {cen5 == wen}");
                    Console.WriteLine($"Четверг {cen7 == thu}");
                    Console.WriteLine($"Пятница {cen9 == fri}");
                    Console.WriteLine($"Суббота {cen11 == sat}");
                    Console.WriteLine($"Воскресенье {cen13 == sun}");

                    Console.WriteLine("В какие дни работает второй офис");
                    Console.WriteLine($"Понедельник {cen2 == mon}");
                    Console.WriteLine($"Вторник {cen4 == tue}");
                    Console.WriteLine($"Среда {cen6 == wen}");
                    Console.WriteLine($"Четверг {cen8 == thu}");
                    Console.WriteLine($"Пятница {cen10 == fri}");
                    Console.WriteLine($"Суббота {cen12 == sat}");
                    Console.WriteLine($"Воскресенье {cen14 == sun}");

                    break;
            }
        }
    }
}
