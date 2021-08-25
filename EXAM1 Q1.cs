using System;
using System.Collections.Generic;
using System.Linq;

namespace EXAM1_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive numbers (-1 to quit): ");
            // I ask for positive numbers because if I ask for negative numbers, then -1 quits the program instead of being a value
            float num = 0;
            //float smallest;
            int counter = 1;
            float avg = 0;
            float sum;
            List<float> nums = new List<float>();
            List<float> numsdiv = new List<float>();

            while (num != -1)
            {
                Console.WriteLine("Enter number " + counter + ": ");
                num = float.Parse(Console.ReadLine());
                nums.Add(num);
                counter++;
                sum += num;
                if (num % 7 == 0)
                {
                    numsdiv.Add(num);
                }
            }
            float[] numList = nums.Take(nums.Count() - 1).ToArray();
            float[] newnumsdiv = numsdiv.ToArray();
            Console.WriteLine("The smallest number is: " + numList.Min());
            Console.WriteLine("The largest number is: " + numList.Max());
            sum++;
            //Console.WriteLine(counter);
            avg = sum / (counter - 2);
            Console.WriteLine("The average is: " + avg);
            
            Console.WriteLine("Numbers divisible by 7:");
            Console.WriteLine(string.Join("\n", newnumsdiv));
            Console.ReadKey();
        }
    }
}
