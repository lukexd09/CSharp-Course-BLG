using System;


namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double lRowSits = Math.Floor(l / 1.2);
            double wRowSits = Math.Floor((w-1) / 0.7);
            double workplaces = (lRowSits * wRowSits) - 3;
            Console.WriteLine(workplaces);
        }
    }
}
