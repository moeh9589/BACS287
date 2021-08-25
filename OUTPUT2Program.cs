using System;

namespace Output_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine(x);
                x = x - 1;
            }
        }
    }
}
