using System;

namespace Assignment3_IfStment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            String nums = Console.ReadLine();
            
            String[] listofnums = nums.Split(' ');
            float x, y;
            x = float.Parse(listofnums[0]);
            y = float.Parse(listofnums[1]);

            if (y <= 0)
            {
                Console.WriteLine("Error, cannot divide by 0");
            }
            else
            {
                Console.WriteLine(x / y);
            }
        }
    }
}
