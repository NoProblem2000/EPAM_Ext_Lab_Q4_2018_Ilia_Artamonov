using System;
using System.Diagnostics;
using System.Text;

namespace Task3.Basics_of_CSharp
{
    class ThirteenthTask
    {
        public void CalculateTimeExecution()
        {
            Console.WriteLine("This task shoe you differents in speed between class String and StringBuilder ");
            Stopwatch stopwatch = new Stopwatch();
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100000000;
            stopwatch.Start();
            //for (int i = 0; i < N; i++)
            //{
            //    str += "*";
            //}
            stopwatch.Stop();
            long timeString = stopwatch.ElapsedMilliseconds;
            stopwatch.Restart();
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopwatch2.Stop();
            Console.WriteLine(stopwatch2.ElapsedMilliseconds);
            stopwatch.Stop();
            long timeStringBuilder = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Time execution in {N} iteration. String: {timeString}, StringBuilder: {timeStringBuilder}");
            Console.WriteLine("Press enter to exit to main menu");
            Console.ReadKey();
        }
    }
}