using System;
using System.Collections.Generic;

namespace Output3
{
    class OUTPUT3Program
    {
        static void Main(string[] args)
        {
            List<int> numlist = new List<int>();
            Random rnd = new Random();
            int num = 0;
            for (int i = 0; i <= 10; i++)
            {
                num = rnd.Next(100);
                numlist.Add(num);
            }

            double sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum += numlist[i];
            }
            Console.WriteLine("10 number values:");
            Console.WriteLine();

            for (int i = 0; i <= 8; i++)
            {
                Console.Write(numlist[i]);
                Console.Write(", ");
            }
            Console.Write(numlist[9]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Total Sum:");
            Console.WriteLine(sum);

            double avg = 0;
            avg = sum / 10;

            Console.WriteLine();

            Console.WriteLine("Final Average:");
            Console.WriteLine(avg);
        }
    }
}
