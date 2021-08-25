using System;
using System.Collections.Generic;


namespace EXAM_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Practice");
            Console.WriteLine("2) Analytics");
            Console.WriteLine("3) Quit");
            Console.WriteLine();
            Console.WriteLine("Pick an option.");

            int num = 0;
            double usernum = 0;
            String choice = "";
            double corrrectguessees = 0;
            double totalguesses = 0;
            double pct = 0;
            double sum = 0;
            double avg = 0;

            List<double> numbers = new List<double>();

            while (num != 3)
            {
                num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("You chose to practice!");
                    Console.WriteLine("Enter a number:");
                    usernum = double.Parse(Console.ReadLine());
                    numbers.Add(usernum);
                    Console.WriteLine("Your number is: " + usernum);
                    Console.WriteLine("Is " + usernum + " divisible by 3? (enter 'yes' or 'no')");
                    choice = Console.ReadLine();

                    if (usernum % 3 == 0 && choice == "yes")
                    {
                        corrrectguessees += 1;
                        totalguesses += 1;
                    }

                    else if (usernum % 3 != 0 && choice == "no")
                    {
                        corrrectguessees += 1;
                        totalguesses += 1;
                    }

                    else
                    {
                        totalguesses += 1;
                    }

                    Console.WriteLine("Is " + usernum + " divisible by 5? (enter 'yes' or 'no')");
                    choice = Console.ReadLine();

                    if (usernum % 5 == 0 && choice == "yes")
                    {
                        corrrectguessees += 1;
                        totalguesses += 1;
                    }

                    else if (usernum % 5 != 0 && choice == "no")
                    {
                        corrrectguessees += 1;
                        totalguesses += 1;
                    }

                    else
                    {
                        totalguesses += 1;
                    }

                    Console.WriteLine();              
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1) Practice");
                    Console.WriteLine("2) Analytics");
                    Console.WriteLine("3) Quit");
                    Console.WriteLine();
                    Console.WriteLine("Pick an option.");
                }
                else if (num == 2)
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Cannot provide analytics based on no input, please enter 1 to begin.");
                        Console.WriteLine();
                        Console.WriteLine("Menu:");
                        Console.WriteLine("1) Practice");
                        Console.WriteLine("2) Analytics");
                        Console.WriteLine("3) Quit");
                        Console.WriteLine();
                        Console.WriteLine("Pick an option.");
                    }

                    else
                    {
                        pct = corrrectguessees / totalguesses;
                        pct = pct * 100;
                        Console.WriteLine();
                        Console.WriteLine("Welcome to your analytics!");
                        Console.WriteLine();
                        Console.WriteLine("You entered " + corrrectguessees + " correct guesses out of " + totalguesses + " total guesses.");
                        Console.WriteLine("Your score is " + String.Format("{0:0.00}", pct) + "%!");

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }

                        avg = sum / numbers.Count;
                              

                        Console.WriteLine("The average of all of your numbers is: " + String.Format("{0:0.00}", avg) + ".");

                        Console.WriteLine();
                        Console.WriteLine("Menu:");
                        Console.WriteLine("1) Practice");
                        Console.WriteLine("2) Analytics");
                        Console.WriteLine("3) Quit");
                        Console.WriteLine();
                        Console.WriteLine("Pick an option.");
                    }

                }
            }

        }
    }
}
