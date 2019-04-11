using System;


namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of the first parameter");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose a unit");
            Console.WriteLine("1. Milimeters");
            Console.WriteLine("2. Centimeters");
            Console.WriteLine("3. Meters");
            Console.WriteLine("4. Kilometers");
            Console.WriteLine("5. Miles");
            Console.WriteLine("6. Inches");
            Console.WriteLine("7. Feets");
            Console.WriteLine("8. Yards");
            int choose1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a unit to convert");
            Console.WriteLine("1. Milimeters");
            Console.WriteLine("2. Centimeters");
            Console.WriteLine("3. Meters");
            Console.WriteLine("4. Kilometers");
            Console.WriteLine("5. Miles");
            Console.WriteLine("6. Inches");
            Console.WriteLine("7. Feets");
            Console.WriteLine("8. Yards");
            int choose2 = int.Parse(Console.ReadLine());
            double converter1 = 0, converter2 = 0;
            string symbol1 ="a", symbol2="b";
            switch (choose1)
            {
                case 1:
                    converter1 = 1000;
                    symbol1 = "mm";
                    break;
                case 2:
                    converter1 = 100;
                    symbol1 = "cm";
                    break;
                case 3:
                    converter1 = 1;
                    symbol1 = "m";
                    break;
                case 4:
                    converter1 = 0.001;
                    symbol1 = "km";
                    break;
                case 5:
                    converter1 = 0.000621371192;
                    symbol1 = "mi";
                    break;
                case 6:
                    converter1 = 39.3700787;
                    symbol1 = "in";
                    break;
                case 7:
                    converter1 = 3.2808399;
                    symbol1 = "ft";
                    break;
                case 8:
                    converter1 = 1.0936133;
                    symbol1 = "yd";
                    break;

            }

            switch (choose2)
            {
                case 1:
                    converter2 = 1000;
                    symbol2 = "mm";
                    break;
                case 2:
                    converter2 = 100;
                    symbol2 = "cm";
                    break;
                case 3:
                    converter2 = 1;
                    symbol2 = "m";
                    break;
                case 4:
                    converter2 = 0.001;
                    symbol2 = "km";
                    break;
                case 5:
                    converter2 = 0.000621371192;
                    symbol2 = "mi";
                    break;
                case 6:
                    converter2 = 39.3700787;
                    symbol2 = "in";
                    break;
                case 7:
                    converter2 = 3.2808399;
                    symbol2 = "ft";
                    break;
                case 8:
                    converter2 = 1.0936133;
                    symbol2 = "yd";
                    break;

            }
            double x2 = (x1 / converter1) * converter2;
            Console.WriteLine("{0} {1} = {2} {3}",x1,symbol1,x2,symbol2);
        }
    }
}
