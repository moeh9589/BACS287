using System;

namespace Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers ranging from 0 to 100");
            double[] nums = new double[10];
            double x;
            double median = -1;
            int count = 0;
            double y;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number " + (i + 1));
                x = double.Parse(Console.ReadLine());
                while (x < 0 || x > 100)
                {
                    Console.WriteLine("Try again:");
                    x = double.Parse(Console.ReadLine());
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
                count += 1;
            }
            if (count % 2 == 0)
            {
                median = (nums[count / 2 - 1] + nums[count/2]) / 2;
            }
            
            else
            {
                y = nums[count / 2 - 1];
                Math.Round(y);
                median = y;
            }

            Console.WriteLine("The median is: " + median);
        }
    }
}
