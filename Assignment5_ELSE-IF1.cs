using System;

namespace Assignment5_If_Else1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's divisible by 2,3,4,5,6,7, or 8");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Your number is divisible by 2");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Your number is divisible by 3");
            }
            else if (num % 4 == 0)
            {
                Console.WriteLine("Your number is divisible by 2 and 4");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Your number is divisible by 5");
            }
            else if (num % 6 == 0)
            {
                Console.WriteLine("Your number is divisible by 2, 3, and 6");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("Your number is divisible by 7");
            }
            else if (num % 8 == 0)
            {
                Console.WriteLine("Your number is divisible by 2, 4, and 8");
            }
            else
            {
                Console.WriteLine("Your number is not divisible by 2-8");
            }

            Console.ReadKey();
        }
    }
}
