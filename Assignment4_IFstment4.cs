using System;

namespace Assignment4_If_Statement_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your total hours worked this week.");
            float hours = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your hourly wage.");
            float wage = float.Parse(Console.ReadLine());

            double total = 0;
            if (hours > 40)
            {
                total = (40.0 * wage) + (1.5 * wage * (hours - 40));
            }
            else
            {
                total = wage * hours;
            }
            Console.WriteLine("Your earnings for this week is " + total + " (not including taxes)");

            Console.ReadKey();
        }
    }
}
