using System;

namespace For_Loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            float counter = 0;
            float gpaSUM = 0;
            float grade = 0;
            float sum = grade;

            Console.WriteLine("Enter student status (f) for full time or (p) for part time: ");
            String status = Console.ReadLine();

            //Console.WriteLine("Enter in grades. Enter -1 to quit");


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter grade " + (counter + 1));
                grade = float.Parse(Console.ReadLine());
                if (grade >= 90)
                {
                    gpaSUM += 4;
                }
                else if (grade >= 80 && grade < 90)
                {
                    gpaSUM += 3;
                }
                else if (grade >= 70 && grade < 80)
                {
                    gpaSUM += 2;
                }
                else if (grade >= 60 && grade < 70)
                {
                    gpaSUM += 1;
                }
                else
                {
                    gpaSUM += 0;
                }
                sum += grade;
                counter += 1;
            }
            //sum += 1;
            float avg = sum / counter;
            float GPA = gpaSUM / 10;

            Console.WriteLine("The GPA is: " + GPA);
            Console.WriteLine("The student status is: " + status);

            if (status.Equals("f") && GPA >= 3.5)
            {
                Console.WriteLine("The student qualifies for the Dean's list.");
            }
            else
            {
                Console.WriteLine("The student doesn't qualify for the Dean's list.");
            }
            Console.ReadKey();

        }
    }
}
