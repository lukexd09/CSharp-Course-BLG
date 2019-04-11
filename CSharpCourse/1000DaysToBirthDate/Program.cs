using System;
using System.Globalization;

namespace _1000DaysToBirthDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birth = DateTime.Parse(Console.ReadLine());
            birth = birth.AddDays(1000);
            Console.WriteLine(birth.ToShortDateString());


        }
    }
}
