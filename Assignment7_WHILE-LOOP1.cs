using System;

namespace Assignment7_WhileLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in grades. Enter -1 to quit");
            float grade = float.Parse(Console.ReadLine());
            float counter = 0;
            float sum = grade;
            while (grade != -1)
            {
                Console.WriteLine("Enter grade " + (counter + 2) + " (or -1 to quit): ");
                grade = float.Parse(Console.ReadLine());
                sum += grade;
                counter += 1;
            }
            sum += 1;
            float avg = sum / counter;

            Console.WriteLine("The average is: " + avg);
            Console.ReadKey();
        }
    }
}
