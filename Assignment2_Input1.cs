using System;

namespace Assignment2_Input1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers:");
            String nums = Console.ReadLine();
            Console.WriteLine(nums);

            String[] listofnums = nums.Split(' ');

            float avg = 0;
            float sum = 0;
            for (int i = 0; i < 5; i++)
            {
                float num = float.Parse(listofnums[i]);
                sum += num;
                
            }
            avg = sum / 5;
            Console.WriteLine("Your average is: " + avg);

            Console.ReadKey();




        }
    }
}
