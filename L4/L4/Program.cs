using System;

namespace L4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("//1");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"Введите инициалы {i + 1} человека:");
                Console.WriteLine(GetFullName());
            }
            //2
            Console.WriteLine("//2");
            Console.WriteLine(GetSumm());
            //3
            Console.WriteLine("//3");
            Console.WriteLine("Введите номер месяца: ");
            Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
            //4
            Console.WriteLine("//4");
            Console.WriteLine("Введите число:");
            Console.WriteLine(Fibonachi(Convert.ToInt32(Console.ReadLine())));
        }
        static string GetFullName()
        {
            string firstName;
            string lastName;
            string patronymic;
            Console.WriteLine($"Введите имя");
            firstName = Console.ReadLine();
            Console.WriteLine($"Введите фамилию");
            lastName = Console.ReadLine();
            Console.WriteLine($"Введите отчество");
            patronymic = Console.ReadLine();
            string names = firstName + " " + lastName + " " + patronymic;


            return names;
        }

        static int GetSumm()
        {
            Console.WriteLine("Введите строку чисел через пробел: ");
            string numbers = Console.ReadLine();
            char[] nums = numbers.ToCharArray();
            int sum = 0;
            string p;
            for (int i = 0; i < nums.Length; i++)
            {
                p = Convert.ToString(nums[i]);
                if (p != " ")
                {
                    sum += Convert.ToInt32(p);
                }
            }
            return sum;
        }

        enum season { nan, Winter, Spring, Summer, Autumn }
        static season OfMonth(int n)
        {
            if (n <= 0 || n > 12)
                throw new Exception("Ошибка: введите число от 1 до 12");
            switch ((n % 12) / 3)
            {
                case 0:
                    return season.Winter;
                case 1:
                    return season.Spring;
                case 2:
                    return season.Summer;
                default:
                    return season.Autumn;
            }
        }
        static string Season(season s)
        {
            switch (s)
            {
                case season.Winter:
                    return "Зима";
                case season.Spring:
                    return "Весна";
                case season.Summer:
                    return "Лето";
                case season.Autumn:
                    return "Осень";
                default:
                    return "";
            }
        }
        static int Fibonachi(int x, int p1=0, int p2=1)
        {
            if (x <= 1) return p1;
            int p;
            for (int i = 2; i < x; i++)
            {
                p = p1;
                p1 = p2;
                p2 = p2 + p;
            }
            return p2;
        }
    }
}
