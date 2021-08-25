using System;

namespace While_Loop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive numbers (-1 to quit): ");
            // I ask for positive numbers because if I ask for negative numbers, then -1 quits the program instead of being a value
            float num = 0;
            float largest = 0;
            int counter = 1;

            while (num != -1)
            {
                Console.WriteLine("Enter number " + counter + ": ");
                num = float.Parse(Console.ReadLine());
                if (num > largest)
                {
                    largest = num;
                }
                counter++;
            }
            Console.WriteLine("The largest number is: " + largest);
            Console.ReadKey();
        }
    }
}
