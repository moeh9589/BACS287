using System;

namespace Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers ranging from 10 to 100");
            float[] nums = new float[10];
            float x;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number " + (i + 1));
                x = float.Parse(Console.ReadLine());
                while (x < 10 || x > 100)
                {
                    Console.WriteLine("Try again:");
                    x = float.Parse(Console.ReadLine());
                }
                nums[i] = x; ;
            }

            Array.Sort(nums);
            Console.WriteLine("");
            Console.WriteLine("After Sorting:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                Console.WriteLine(nums[i]);
            }

        }
    }
}
