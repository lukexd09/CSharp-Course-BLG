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
            double minutes = 0;
            double seconds = 0;
            string strSeconds;

            minutes = Math.Floor(x1 / 60) + Math.Floor(x2 / 60) + Math.Floor(x3 / 60);
            seconds = (x1 % 60) + (x2 % 60) + (x3 % 60);

            if (seconds >= 60)
            {
                minutes = minutes + Math.Floor(seconds / 60);
                seconds = seconds % 60;
            }
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
