using System;


namespace SumOfSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            string strSeconds;
            double result = x1 + x2 + x3;
            double minutes = Math.Floor(result / 60);
            double seconds = (result % 60);

            if (seconds < 10)
            {
                strSeconds = string.Concat('0', seconds);
            }
            else
            {
                strSeconds = string.Concat(seconds);
            }

            Console.WriteLine("Time {0}:{1}",minutes,strSeconds);
        }
    }
}
