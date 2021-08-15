using System;

namespace L6
{
    class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Program()
        {

        }
        public Program(int id, string name)
        {
            Id = id;
            Name = name;
        }
        static void Main(string[] args)
        {
            TaskManager pr = new TaskManager();
            pr.RunWorkProcess();

            string[,] correctMatrix = {
                {"3", "7", "3", "1"},
                {"1", "6", "0", "4"},
                {"0", "5", "7", "2"},
                {"0", "2", "7", "8"}
                                        };
            string[,] wrongCharMatrix = {
                {"1", "9", "2", "3"},
                {"6", "1", "5", "7"},
                {"2", "Z", "7", "6"},
                {"1", "9", "4", "5"}
                                        };

            int sum = 0;

            try
            {
                sum = Array(correctMatrix);
            }
            catch (MyArraySizeExeption e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (MyArrayDataException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine(sum);

            try
            {
                sum = Array(wrongCharMatrix);
            }
            catch (MyArraySizeExeption e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (MyArrayDataException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine(sum);
        }



            public static int Array(string[,] correctMatrix)
            {
                int sum = 0;
                if (correctMatrix.GetLength(0) != 4) throw new MyArraySizeExeption();
                for (int i = 0; i < correctMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < correctMatrix.GetLength(1); j++)
                    {
                        try
                        {
                            sum += Int32.Parse(correctMatrix[i, j]);
                        }
                        catch (Exception e)
                        {
                            throw new MyArrayDataException(i, j);
                        }

                    }
                }
                return sum;
            }
    } 
}
