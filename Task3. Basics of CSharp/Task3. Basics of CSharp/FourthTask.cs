using System;
using System.Linq;

namespace Task3.Basics_of_CSharp
{
    public class FourthTask
    {
        public static FourthTask Instance => LazyInstance.Value;
        private static readonly Lazy<FourthTask> LazyInstance = 
            new Lazy<FourthTask>(()=> new FourthTask());

        private int NumberOfPyramids;
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
            Console.WriteLine("This task write pyramids of rows with * that you entered\n");
            Console.WriteLine("Enter the integer number");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out NumberOfPyramids))
                {
                    Console.WriteLine("You entered not a number or not a integer");
                    continue;
                }
                if (NumberOfPyramids <= 0)
                {
                    Console.WriteLine("Enter the numbers, which greater the zero");
                    continue;
                }

                int numberOfStars = 1;
                int numberOfRows = NumberOfPyramids + 1;
                int countOfGaps = NumberOfPyramids;
                for (int i = 1; i < NumberOfPyramids + 1; i++)
                {
                    numberOfRows = i+1;
                    for (int j = 0; j < numberOfRows; j++)
                    {
                        if ((numberOfRows == 2) && (j == 0))
                        {
                            Console.Write(String.Concat(Enumerable.Repeat(" ", countOfGaps)));
                            Console.WriteLine(String.Concat(Enumerable.Repeat("*", numberOfStars)));
                        }
                            Console.Write(String.Concat(Enumerable.Repeat(" ", countOfGaps)));
                            Console.WriteLine(String.Concat(Enumerable.Repeat("*", numberOfStars)));

                           CalculateGapsAndStars(ref countOfGaps, ref numberOfStars);
                    }

                    numberOfStars = 1;
                    countOfGaps = NumberOfPyramids;
                }
                Console.WriteLine("\nTask is completed\n");
                Console.WriteLine("Press enter\n\n");
                Console.ReadKey();
                break;
            }
        }
    }
}