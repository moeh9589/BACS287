using System;

namespace Assignment6_ELSE_IF_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Status (F) for full time or (P) for part time: ");
            String status = Console.ReadLine();
            Console.WriteLine("Enter GPA");
            float gpa = float.Parse(Console.ReadLine());

            if (gpa >= 3.5 && status.Equals("F"))
            {
                Console.WriteLine("Student qualifies for the Dean's List.");
            }
            else
            {
                Console.WriteLine("Student doesn't qualify for the Dean's List.");
            }
            Console.ReadKey();
        }
    }
}
