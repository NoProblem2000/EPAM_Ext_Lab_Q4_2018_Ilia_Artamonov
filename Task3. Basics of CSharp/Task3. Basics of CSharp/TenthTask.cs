using System;

namespace Task3.Basics_of_CSharp
{
    class TenthTask
    {
        private static readonly Lazy<TenthTask> LazyInstance =
            new Lazy<TenthTask>(() => new TenthTask());

        public static TenthTask Instance => LazyInstance.Value;

        private int Rows;
        private int Columns;
        private int SumElements = 0;
        private void WriteArray(int[,] array)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(array[i, j] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void SumOdevityElements()
        {
            Console.WriteLine("This task find sum of elements which place on odevity places. Odevity elements marked blue color");
            Random random = new Random();
            Rows = random.Next(2, 10);
            Columns = random.Next(2, 10);
            int[,] Array = new int[Rows,Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Array[i, j] = random.Next(0, 100);
                }
            }
            Console.WriteLine("Origin array");
            WriteArray(Array);

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        SumElements += Array[i, j];
                    }
                }
            }

            Console.WriteLine($"the sum of elements which on odevity place equal {SumElements}\n\n");
            Console.WriteLine("Press enter\n\n");
            Console.ReadKey();

        }
    }
}