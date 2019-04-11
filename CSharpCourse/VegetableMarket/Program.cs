using System;


namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegeWeight = double.Parse(Console.ReadLine());
            double fruitWeight = double.Parse(Console.ReadLine());
            Console.WriteLine(((vegePrice * vegeWeight) + (fruitPrice * fruitWeight)) / 1.94);
        }
    }
}
