using System;

namespace Assignment6_Else_If_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Your number is divisible by 2. The next three numbers divisible by 2 are " + (x + 2) + (" ") + (x + 4) + (" and ") + (x + 6));
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("Your number is divisible by 3. The next three numbers divisible by 3 are " + (x + 3) + (" ") + (x + 6) + (" and ") + (x + 9));
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("Your number is divisible by 5. The next three numbers divisible by 5 are " + (x + 5) + (" ") + (x + 10) + (" and ") + (x + 15));
            }
            else if (x % 7 == 0)
            {
                Console.WriteLine("Your number is divisible by 7. The next three numbers divisible by 7 are " + (x + 7) + (" ") + (x + 14) + (" and ") + (x + 21));
            }
            else if (x % 8 == 0)
            {
                Console.WriteLine("Your number is divisible by 8. The next three numbers divisible by 8 are " + (x + 8) + (" ") + (x + 16) + (" and ") + (x + 24));
            }
            else if (x % 13 == 0)
            {
                Console.WriteLine("Your number is divisible by 13. The next three numbers divisible by 13 are " + (x + 13) + (" ") + (x + 26) + (" and ") + (x + 39));
            }
            else
            {
                Console.WriteLine("Your number cannot be divided by 2, 3, 5, 7, 8, or 13.");
            }
            Console.ReadKey();
        }
    }
}
