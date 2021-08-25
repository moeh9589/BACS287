using System;

namespace Arrays_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers.");
            float num;
            float[] numlist = new float[10];
            float[] newlist = new float[10];
            float[] firsthalf = new float[5];
            float[] secondhalf = new float[5];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                num = float.Parse(Console.ReadLine());
                numlist[i] = num;
            }
            Console.WriteLine();
            Console.WriteLine("Original Array:");
            Console.Write("[");
            for (int i = 0; i < numlist.Length; i++)
            {
                if (i < numlist.Length - 1)
                {
                    Console.Write(numlist[i] + ", ");
                }
                else
                {
                    Console.Write(numlist[i]);
                }
            }
            Console.Write("]");
            for (int i = numlist.Length / 2 - 1; i >= 0; i--)
            {
                firsthalf[i] = numlist[i];
                newlist[i + 5] = firsthalf[i];
            }

            for (int i = numlist.Length / 2 - 1; i >= 0; i--)
            {
                secondhalf[i] = numlist[i + 5];
                newlist[i] = secondhalf[i];
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("New Array: ");
            Console.Write("[");
            for (int i = 0; i < newlist.Length; i++)
            {
                if (i < newlist.Length - 1)
                {
                    Console.Write(newlist[i] + ", ");
                }
                else
                {
                    Console.Write(newlist[i]);
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
