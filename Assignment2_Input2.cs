using System;

namespace Assignment2_Input2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            String nums = Console.ReadLine();
            Console.WriteLine(nums);

            String[] listofnums = nums.Split(' ');
            float x = float.Parse(listofnums[0]);
            float y = float.Parse(listofnums[1]);

            Console.WriteLine("Addition: " + (x + y));
            Console.WriteLine("Subtraction: " + (x - y));
            Console.WriteLine("Division: " + (x / y));
            Console.WriteLine("Multiplication: " + (x * y));
            Console.WriteLine("Power - X to the Y: " + (Math.Pow(x, y)));

            Console.ReadKey();
        }
    }
}
