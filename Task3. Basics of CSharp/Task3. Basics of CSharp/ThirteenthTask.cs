using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Task3.Basics_of_CSharp
{
    class ThirteenthTask
    {
        private static readonly Lazy<ThirteenthTask> LazyInstance =
            new Lazy<ThirteenthTask>(() => new ThirteenthTask());

        public static ThirteenthTask Instance => LazyInstance.Value;

        public void CalculateTimeExecution()
        {
            Console.WriteLine("This task shoe you differents in speed between class String and StringBuilder ");
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder sb = new StringBuilder();
            int iteration = 100000;
            stopwatch.Start();
            
            for (int i = 0; i < iteration; i++)
            {
                String.Concat(Enumerable.Repeat("*", i));
            }
            stopwatch.Stop();
            long timeString = stopwatch.ElapsedMilliseconds;
            stopwatch.Restart();
         
            for (int i = 0; i < iteration; i++)
            {
                sb.Append("*");
            }
            stopwatch.Stop();
            long timeStringBuilder = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Time execution in {iteration} iteration. String: {timeString}, StringBuilder: {timeStringBuilder}");
            Console.WriteLine("Press enter to exit to main menu");
            Console.ReadKey();
        }
    }
}