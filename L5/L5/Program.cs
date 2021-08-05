using System;
using System.Collections.Generic;
using System.IO;

namespace L5
{ 
class Program
    {
        static void Main(string[] args)
        {

            //1
            Console.WriteLine("//1");
            Console.WriteLine("Введите строку дя записи в файл: ");
            Console.WriteLine(WriteString(Console.ReadLine()));
            Console.WriteLine("------------------------------------------------------");

            //2
            Console.WriteLine("//2");
            Console.WriteLine(StartUp());
            Console.WriteLine("------------------------------------------------------");

            //3
            Console.WriteLine("//3");
            Console.WriteLine(BytesFile());
            Console.WriteLine("------------------------------------------------------");

            //4
            Console.WriteLine("//4");
            Console.WriteLine();
            Employee[] empCorp = new Employee[5];
            empCorp[0] = new Employee("Ivanov Ivan", "Engineer", "ivivan@mailbox.com", "892312312", 50000, 30);
            empCorp[1] = new Employee("Imya Familiya", "Creator", "familiya@mailbox.com", "892312314", 50000, 50);
            empCorp[2] = new Employee("Sidorov Sidr", "Teamlid", "sidorov@mailbox.com", "892312315", 10000, 43);
            empCorp[3] = new Employee("Dwa Tri", "Mid", "Dwa@mailbox.com", "892312316", 25000, 18);
            empCorp[4] = new Employee("Tri Dwa", "Pensil", "Tri@mailbox.com", "892312317", 40003000, 21);
            for (int i = 0; i < empCorp.Length; i++) {
                if (empCorp[i].getAge() > 40) {
                    Console.WriteLine(empCorp[i].GetInfo());
                }
            }
        }
         static string WriteString(string line)
          {
              string filename = "text.txt";
              File.AppendAllText(filename, line);
              string ret = "Строка заисана в файл text.txt";

              return ret;
          }

         static string StartUp()
          {
              string filename = "startup.txt";
              File.WriteAllText(filename, DateTime.Now.ToString("F"));
              string ret = "Время записано в файл startup.txt";

              return ret;
          }

        static string BytesFile()
        {
            Console.WriteLine("Введите с клавиатуры произвольный набор чисел 0...255");
            string fail = "Введите корректные значения";
            string filename = "bytes.bin";
            string str = Console.ReadLine();
            string[] str_arr = new string[str.Length];
            str_arr = str.Split(' ');
            byte[] arr = new byte[str.Length];
            for (int i = 0; i < str_arr.Length; i++)
            {
                string str_new = Convert.ToString(str_arr[i]);
                int j = Convert.ToInt32(str_new);
                if (j >= 0 && j <= 255)
                {
                    arr[i] = Convert.ToByte(j);
                }
                else
                {
                    return fail;
                }
            }
            File.WriteAllBytes(filename, arr);
            string ret = "Данный записаны в файл bytes.bin";

            return ret;
        }

    }
}

