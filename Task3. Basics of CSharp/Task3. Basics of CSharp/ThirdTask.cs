using System;
using System.Linq;

namespace Task3.Basics_of_CSharp
{
    class ThirdTask
    {
        public static ThirdTask Instance => LazyInstance.Value;
        private static readonly Lazy<ThirdTask> LazyInstance =
            new Lazy<ThirdTask>(()=> new ThirdTask());

        private int NumberOfRows;
        
        private void CalculateGapsAndStars(ref int CountOfGaps, ref int numberOfStars)
        {
            if (CountOfGaps > 0)
            {
                CountOfGaps--;
            }
            numberOfStars += 2;
        }

        public void ViewStars()
        {
            Console.WriteLine("This task write number of rows with * that you entered\n");
            Console.WriteLine("Enter the integer number");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out NumberOfRows))
                {
                    Console.WriteLine("You entered not a number or not a integer");
                    continue;
                }
                if (NumberOfRows <= 0)
                {
                    Console.WriteLine("Enter the numbers, which greater the zero");
                    continue;
                }

                int numberOfStars = 1;
                int countOfGaps = NumberOfRows - 1;

                for (int i = 1; i < NumberOfRows + 1; i++)
                {
                    Console.Write(String.Concat(Enumerable.Repeat(" ", countOfGaps)));
                    Console.WriteLine(String.Concat(Enumerable.Repeat("*", numberOfStars)));

                    CalculateGapsAndStars(ref countOfGaps, ref numberOfStars);
                }
                Console.WriteLine("\nTask is completed\n");
                Console.WriteLine("Press enter\n\n");
                Console.ReadKey();
                break;
            }
        }
    }
}