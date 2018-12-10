using System;

namespace Task3.Basics_of_CSharp
{
    public class NinthTask
    {
        private int SizeOfArray = 20;
        private Random random;
        private int SumPositive = 0;
        public void SumPositiveElements()
        {
            Console.WriteLine("This task get the sum of positive values of array");
            random = new Random();
            int[] Array = new int[SizeOfArray];
            { };
            for (int i = 0; i < SizeOfArray; i++)
            {
                Array[i] = random.Next(-100, 100);
            }

            Console.WriteLine("Origin array");
            foreach (var element in Array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            // ki. не обязательно ставить {} для однострочных циклов и условий - это мешает читаемости. И здесь лучше использовать foreach.
            for (int i = 0; i < SizeOfArray; i++)
            {
                if (Array[i] > 0)
                {
                    SumPositive += Array[i];
                }
            }

            Console.WriteLine($"Sum of positive elements equal {SumPositive}\n");
            Console.WriteLine("Press enter\n\n");
            Console.ReadKey();
        }
    }
}