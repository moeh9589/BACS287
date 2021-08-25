using System;
using System.Collections.Generic;
using System.Linq;

namespace List_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Guess a number");
            Console.WriteLine("2) Analytics");
            Console.WriteLine("3) Exit");
            bool x = true;
            List<double> numlist = new List<double>();
            double max = 0;
            double min = 0;
            double median = 0;
            double avg = 0;
            int tries = 0;
            while (x)
            {

                num = int.Parse(Console.ReadLine());
                while (num != 1 && num != 2 && num != 3)
                {
                    Console.WriteLine("Please enter 1, 2 or 3.");
                    num = int.Parse(Console.ReadLine());
                }
                if (num == 1)
                {

                    Console.WriteLine("Guess a number between 1-100.");
                    Random random = new Random();
                    int randomNumber = random.Next(0, 100);
                    int number = randomNumber;
                    double guess = 0;
                    Console.WriteLine(randomNumber);
                    while (guess != number)
                    {
                        guess = double.Parse(Console.ReadLine());
                        numlist.Add(guess);

                        if (guess == number)
                        {
                            Console.WriteLine("CONGRATULATIONS! Press 2 to view your analytics.");
                            Console.WriteLine();
                            Console.WriteLine("Menu:");
                            Console.WriteLine("1) Guess a number");
                            Console.WriteLine("2) Analytics");
                            Console.WriteLine("3) Exit");

                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("Your number is greater than the desired number.");

                        }
                        else if (num < number)
                        {
                            Console.WriteLine("Your number is less than the desired number.");
                        }
                        tries++;
                    }
                }
                else if (num == 2)
                {
                    if (numlist.Count == 0)
                    {
                        Console.WriteLine("Cannot perform analytics without any data.");
                        Console.WriteLine("Menu:");
                        Console.WriteLine("1) Guess a number");
                        Console.WriteLine("2) Analytics");
                        Console.WriteLine("3) Exit");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Analytics");
                        numlist.Sort();
                        min = numlist[0];
                        max = numlist[numlist.Count - 1];
                        int count = numlist.Count;
                        double y = 0;
                        avg = numlist.Sum() / numlist.Count;
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
                        String s = avg.ToString("#.##");
                        Console.WriteLine("The minimum number is: " + min);
                        Console.WriteLine("The maximum number is: " + max);
                        Console.WriteLine("The median is: " + median);
                        Console.WriteLine("The average is: " + s);
                        Console.WriteLine("The number of tries took is: " + tries);
                        Console.WriteLine();
                        Console.WriteLine("Menu:");
                        Console.WriteLine("1) Guess a number");
                        Console.WriteLine("2) Analytics");
                        Console.WriteLine("3) Exit");
                        tries = 0;
                        max = 0;
                        min = 0;
                        avg = 0;
                        median = 0;
                        numlist.Clear();
                    }

                }
                else
                {
                    x = false;
                }
                   
            }
            Console.WriteLine("Exiting");
        }
    }
}
