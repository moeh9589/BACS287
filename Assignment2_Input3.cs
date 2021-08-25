using System;

namespace Assignment2_Input3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("The next 8 numbers are: ");

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(x + 1);
                x += 1;
            }
            Console.ReadKey();
        }
    }
}
