using System;

namespace L3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int flag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (flag)
            {

                case 1:

                    //1

                    int[,] mat1 = { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };

                    int rows = mat1.GetUpperBound(0) + 1;
                    int col = mat1.Length / rows;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            if (i == j)
                            {
                                Console.Write($"{mat1[i, j]} \t");
                            }
                            else
                            {
                                Console.Write(" \t");
                            }
                        }
                        Console.WriteLine();
                    }

                    break;

                case 2:

                    //2

                    string[,] mas = new string[5, 2] { { "Dad", "+78967778989/dad@gmail.com" }, { "Mom", "+7896668787/mom@gmail.com" }, { "Grandpa", "+78789007070/ded@gmail.com" }, { "Uncle", "+78634567865/uncle@gmail.com" }, { "Grandma", "+78678906554/bigmom@gmail.com" } };

                    for (int i = 0; i < mas.GetLength(0); i++)
                    {
                        for (int j = 0; j < mas.GetLength(1); j++)
                        {
                            Console.Write($"{mas[i, j]}\t");
                        }
                        Console.WriteLine();
                    }

                    break;
                case 3:

                    //3

                    Console.WriteLine("Введите слово:");
                    string word = Console.ReadLine();

                    char[] arr = word.ToCharArray();
                    string rev = String.Empty;

                    for (int i = arr.Length - 1; i > -1; i--)
                    {
                        rev += arr[i];
                    }

                    Console.WriteLine(rev);

                    break;

                case 4:

                    //4

                    Console.WriteLine("Морской бой: ");

                    string[,] battlefield = new string[10, 10] {{"X", "O","X", "O", "X", "O", "O", "X","O", "O" },
                                                               {"O", "O","X", "O", "X", "O", "O", "X","O", "O" },
                                                               {"O", "O","O", "O", "X", "O", "O", "X","O", "O" },
                                                               {"O", "O","O", "O", "O", "O", "O", "X","O", "O" },
                                                               {"X", "O","O", "O", "O", "O", "O", "O","O", "O" },
                                                               {"X", "O","X", "O", "O", "O", "O", "O","O", "O" },
                                                               {"X", "O","O", "X", "X", "X", "O", "O","O", "O" },
                                                               {"O", "O","O", "O", "O", "O", "O", "X","O", "O" },
                                                               {"O", "X","X", "O", "O", "O", "O", "O","O", "O" },
                                                               {"O", "O","O", "O", "X", "O", "O", "O","X", "X" }};

                    int R = battlefield.GetUpperBound(0) + 1;
                    int C = battlefield.Length / R;

                    for (int i = 0; i < R; i++)
                    {
                        for (int j = 0; j < C; j++)
                        {

                            Console.Write($"{battlefield[i, j]} \t");

                        }
                        Console.WriteLine();
                    }

                    break;
            }
        }
    }
}
