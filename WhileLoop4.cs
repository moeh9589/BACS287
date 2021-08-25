using System;
using System.Collections.Generic;
using System.Linq;


namespace While_Loop_3
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
            List<float> nums = new List<float>();
            
            while (num != -1)
            {
                Console.WriteLine("Enter number " + counter + ": ");
                num = float.Parse(Console.ReadLine());
                nums.Add(num);
                counter++;
            }
            float[] numList = nums.ToArray();
            Console.WriteLine("The smallest number is: " + numList.Min());
            Console.ReadKey();
        }
    }
}
