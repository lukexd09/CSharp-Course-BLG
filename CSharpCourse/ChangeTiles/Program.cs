using System;


namespace ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double nLenght = double.Parse(Console.ReadLine());
            double wTileLenght = double.Parse(Console.ReadLine());
            double lTileLenght = double.Parse(Console.ReadLine());
            double nBenchLenght = double.Parse(Console.ReadLine());
            double wBenchLenght = double.Parse(Console.ReadLine());
            double area = Math.Pow(nLenght, 2) - (nBenchLenght * wBenchLenght);
            Console.WriteLine(area/(wTileLenght*lTileLenght));
            Console.WriteLine((area / (wTileLenght * lTileLenght))*0.2);

        }
    }
}
