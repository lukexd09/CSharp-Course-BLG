using System;


namespace RadiansToDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            float radians = float.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((180f/Math.PI)*radians, 0));
        }
    }
}
