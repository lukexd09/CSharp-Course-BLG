using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <=a; i++)
            {
                if (i == 1 || i == a)
                {
                    Console.WriteLine(new String('*', a));
                }
                else
                {
                    Console.WriteLine("*"+ new String(' ', a-2)+"*");
                }
            }
        }
    }
}
