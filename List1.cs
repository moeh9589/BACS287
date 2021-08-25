using System;
using System.Collections.Generic;


namespace List_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = -10;
            int count = 0;
            int c = 1;
            double median = 0;
            double y = 0;
            List<double> numlist = new List<double>();
            Console.WriteLine("Enter numbers ranging from 0-100 (-1 to quit): ");

            while (num != -1)
            {
                Console.Write("Number " + c + ": ");
                num = double.Parse(Console.ReadLine());
                if ((num < 0 || num > 100) && num != -1)
                {
                    Console.WriteLine("You have entered a number outside of the range... Exiting");
                    break;
                }
                else if (num == -1)
                {
                    Console.WriteLine("Exiting.");
                    break;
                }
                else
                {
                    //Console.WriteLine("Number " + c + ": ");
                    numlist.Add(num);
                    c++;
                    //num = double.Parse(Console.ReadLine());
                }
            }

            numlist.Sort();
            count = numlist.Count;

            Console.WriteLine();

            if (count % 2 == 0)
            {
                median = (numlist[count / 2 - 1] + numlist[count / 2]) / 2;
            }

            else
            {
                y = numlist[count / 2];
                Math.Round(y);
                median = y;
            }
            Console.WriteLine("Median: " + median);
        }
    }
}
