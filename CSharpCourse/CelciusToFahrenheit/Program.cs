using System;


namespace CelciusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            float degree=float.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((degree*(9f/5f)+32),2));
        }
    }
}
