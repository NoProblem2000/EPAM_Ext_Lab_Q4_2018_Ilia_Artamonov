using System;

namespace Task3.Basics_of_CSharp
{
    class FifthTask
    {
        public static FifthTask Instance => LazyInstance.Value;
        private static readonly Lazy<FifthTask> LazyInstance = 
            new Lazy<FifthTask>(()=> new FifthTask());

        private const int MaxValue = 1000;
        private readonly int[] ArrayOfMultiple = new[] { 3,5};
        private int Sum = 0;
        private bool NumberIsAdd = false;

        private void Multiple(int multiple, int number)
        {
            if ((number % multiple) == 0)
            {
                Sum += number;
                NumberIsAdd = true;
            }
        }
        public void SumOfNaturalNumbers()
        {
            Console.WriteLine("This task show you the sum of all numbers is less than 1000, a multiple of 3, or 5\n");
            for (int i = 0; i < MaxValue; i++)
            {
                foreach (var element in ArrayOfMultiple)
                {
                    Multiple(element, i);
                    if (NumberIsAdd)
                    {
                        NumberIsAdd = false;
                        break;
                    }
                }
            }
            Console.WriteLine($"Sum = {Sum}");
            Console.WriteLine("Press enter\n\n");
            Console.ReadKey();
        }

    }
}