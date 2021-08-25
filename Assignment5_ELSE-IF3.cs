using System;
using System.Collections.Generic;

namespace Assignment5_If_Else3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the names for the three participants:");

            String name1 = Console.ReadLine();
            String name2 = Console.ReadLine();
            String name3 = Console.ReadLine();
            String name4 = Console.ReadLine();

            List<String> Names = new List<String>();
            Names.Add(name1);
            Names.Add(name2);
            Names.Add(name3);
            Names.Add(name4);

            List<double> Times = new List<double>();

            for (int i = 0; i < 4; i ++)
            {
                Console.WriteLine("Enter the run time for " + Names[i]);
                Times.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Race Results");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Names[i] + ": " + Times[i]);
            }

            double minTime = 0;
            String minName = "";
            if (Times[0] < Times[1] && Times[0] < Times[2] && Times[0] < Times[3])
            {
                minTime = Times[0];
                minName = Names[0];
            }
            else if (Times[1] < Times[0] && Times[1] < Times[2] && Times[1] < Times[3])
            {
                minTime = Times[1];
                minName = Names[1];
            }
            else if (Times[2] < Times[0] && Times[2] < Times[1] && Times[2] < Times[3])
            {
                minTime = Times[2];
                minName = Names[2];
            }
            else if (Times[3] < Times[0] && Times[3] < Times[1] && Times[3] < Times[2])
            {
                minTime = Times[3];
                minName = Names[3];
            }
            Console.WriteLine("The winner is " + minName + " with a time of: " + minTime);
            Console.ReadKey();
        }
    }
}
