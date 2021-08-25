using System;

namespace Assignment5_If_Else2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade:");
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("You have an A");
            }
            else if (grade >=80 && grade < 90)
            {
                Console.WriteLine("You have a B");
            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("You have a C");
            }
            else if (grade >= 60 && grade < 70)
            {
                Console.WriteLine("You have a D");
            }
            else
            {
                Console.WriteLine("You are failing.");
            }

            Console.ReadKey();
        }
    }
}
