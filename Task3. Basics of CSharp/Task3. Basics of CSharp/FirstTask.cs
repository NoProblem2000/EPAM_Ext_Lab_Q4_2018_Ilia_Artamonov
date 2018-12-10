using System;
using static System.Console;

namespace Task3.Basics_of_CSharp
{
    public class FirstTask
    {
        #region Properties, fields 

        
        public static FirstTask Instance => LazyInstance.Value;

        private static readonly Lazy<FirstTask> LazyInstance =
            new Lazy<FirstTask>(() => new FirstTask());

        private int SideA = 1;
        private int SideB = 1;

        #endregion Prorepties, fields

        public void CalculateSquare()
        {
            WriteLine("This task find the square of rectangle");
            WriteLine("Enter the side A");
            WriteLine("Enter the side B");
            while (true)
            {

                if (!int.TryParse(ReadLine(), out SideA) || !int.TryParse(ReadLine(), out SideB))
                {
                    WriteLine("You entered not a number or not a integer");
                    continue;
                }

                if (SideA <= 0 || SideB <= 0)
                {
                    WriteLine("Enter the numbers, which greater the zero");
                    continue;
                }
                WriteLine($"Square of rectangle equalize = {SideA * SideB}\n");
                WriteLine("Press enter\n\n");
                ReadKey();
                break;

            }

        }
    }
}