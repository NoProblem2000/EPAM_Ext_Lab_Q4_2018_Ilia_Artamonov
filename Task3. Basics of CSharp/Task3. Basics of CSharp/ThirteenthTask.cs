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
            // опять хардкод. ЧТо за константа по названию не ясно.
            int N = 100000000;
            stopwatch.Start();
            // код закоменнтирован , как увидеть сравнение?
            //for (int i = 0; i < N; i++)
            //{
            // ki. почему не     string.Concat()? 
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
            // здесь этому явно не место.
            stopwatch.Stop();
            long timeStringBuilder = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Time execution in {N} iteration. String: {timeString}, StringBuilder: {timeStringBuilder}");
            Console.WriteLine("Press enter to exit to main menu");
            Console.ReadKey();
        }
    }
}