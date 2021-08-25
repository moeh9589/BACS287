using System;
using System.Collections.Generic;
using System.Linq;


namespace For_Loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers:");
            float num = 0;
            float numsum = 0;
            int counter = 1;
            int countofdivisibleby = 0;
            List<float> nums = new List<float>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number " + counter + ": ");
                num = float.Parse(Console.ReadLine());
                nums.Add(num);
                numsum += num;
                counter++;
                if (num % 13 == 0)
                {
                    countofdivisibleby += 1;
                }
            }
            float[] numList = nums.ToArray();
            float avg = numsum / 10;
            Console.WriteLine("The smallest number is: " + numList.Min());
            Console.WriteLine("The largest number is: " + numList.Max());
            Console.WriteLine("The average of the numbers is: " + avg);
            Console.WriteLine("There are " + countofdivisibleby + " numbers divisible by 13.");
            Console.ReadKey();
        }
    }
}
