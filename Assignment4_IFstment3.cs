using System;

namespace Assignment4_If_Statement_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            float usernum = float.Parse(Console.ReadLine());

            if (usernum > 0)
            {
                Console.WriteLine("Your number is positive.");
            }
            else if (usernum < 0)
            {
                Console.WriteLine("Your number is negative.");
            }
            else
            {
                Console.WriteLine("Your number is neither positive nor negative.");
            }
            Console.ReadKey();
        }
    }
}
