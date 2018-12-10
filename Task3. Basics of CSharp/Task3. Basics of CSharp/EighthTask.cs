using System;

namespace Task3.Basics_of_CSharp
{
    class EighthTask
    {
        private static readonly Lazy<EighthTask> LazyInstance = 
            new Lazy<EighthTask>(()=> new EighthTask());

        public static EighthTask Instance => LazyInstance.Value;

        private int Dimension;
        private int[,,] InitArray(int[,,] array)
        {
            Random random = new Random();
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    for (int k = 0; k < Dimension; k++)
                    {
                        array[i,j,k] = random.Next(-100, 100);
                    }
                }
            }

            return array;
        }

        private void ConsoleWriteArray(int[,,] array)
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    for (int k = 0; k < Dimension; k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();

            }
        }

        public void InvertPositiveValues()
        {
            Console.WriteLine("This task change positive values on zero. Table - first dimension, table and columns second and third");
            Random random = new Random();
            Dimension = random.Next(2, 25);
            int[,,] array = new int[Dimension,Dimension,Dimension];
            array = InitArray(array);
            Console.WriteLine("Origin array\n\n");
            ConsoleWriteArray(array);

            Console.WriteLine();
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    for (int k = 0; k < Dimension; k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }

            Console.WriteLine("Array after invert positive to zero\n");
            ConsoleWriteArray(array);
            Console.WriteLine("Press enter\n\n");
            Console.ReadKey();

        }
    }
}