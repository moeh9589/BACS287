using System;
using System.Collections.Generic;
using System.Linq;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu
            Console.WriteLine("Menu (Choose one of the four options (A, B, C, or D))");
            Console.WriteLine("A) Practice");
            Console.WriteLine("B) Analytics");
            Console.WriteLine("C) Log");
            Console.WriteLine("D) Quit");

            //variable initialization
            double correctAns = 0;
            double totalAns = 0;
            string choice = "";
            string choice2 = "";
            string choice3 = "";
            String word = "";
            List<string> words = new List<string>();
            List<string> singles = new List<string>();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int repeatCount = 0;
            int vowelsCount = 0;

            //loop to quit when D is pressed
            while (choice != "D")
            {
                //user input
                Console.WriteLine("Choose:");
                choice = Console.ReadLine();

                //if user enters A
                if (choice == "A")
                {
                    //user input
                    Console.WriteLine("Enter a word");
                    word = Console.ReadLine();

                    
                    word.ToLower();
                    words.Add(word);
                    char prev = word[0];
                    bool repeats = false;
                    int vowelcount = 0;

                    //checks if word contains repeating letters
                    for (int i = 1; i < word.Length; i++)
                    {
                        if (word[i] == prev)
                        {
                            repeats = true;
                            repeatCount += 1;
                        }
                        else
                        {
                            prev = word[i];
                        }
                    }

                    // checks of word has multiple vowels
                    for (int i = 0; i < word.Length; i++)
                    {
                        for (int j = 0; j < vowels.Length; j++)
                        {
                            if (word[i].Equals(vowels[j]))
                            {
                                vowelcount += 1;
                            }
                        }
                    }
                    if (vowelcount > 1)
                    {
                        vowelsCount += 1;
                    }

                    // user input
                    Console.WriteLine("Does your word have any repeating letters? (yes or no)");
                    choice2 = Console.ReadLine();

                    //checks if user is correct
                    if ((choice2 == "yes" && repeats == true) || (choice2 == "no" && repeats == false))
                    {
                        correctAns += 1;
                        totalAns += 1;
                    }
                    else
                    {
                        totalAns += 1;
                    }

                    //user input
                    Console.WriteLine("Does your word have multiple vowels? (yes or no)");
                    choice3 = Console.ReadLine();

                    // checks if user is correct
                    if ((choice3 == "yes" && vowelcount > 1) || (choice3 == "no" && vowelcount < 2))
                    {
                        correctAns += 1;
                        totalAns += 1;
                    }
                    else
                    {
                        totalAns += 1;
                    }

                    //menu
                    Console.WriteLine("Menu (Choose one of the four options (A, B, C, or D))");
                    Console.WriteLine("A) Practice");
                    Console.WriteLine("B) Analytics");
                    Console.WriteLine("C) Log");
                    Console.WriteLine("D) Quit");
                }

                // if user enters B
                else if (choice == "B")
                {
                    Console.WriteLine();
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Welcome to Analytics");

                    //prints results
                    Console.WriteLine("Accuracy: " + ((correctAns / totalAns) * 100) + "%");
                    Console.WriteLine("Number of words with repeating letters: " + repeatCount);
                    Console.WriteLine("Number of words with multiple vowels: " + vowelsCount);

                    //menu
                    Console.WriteLine("Menu (Choose one of the four options (A, B, C, or D))");
                    Console.WriteLine("A) Practice");
                    Console.WriteLine("B) Analytics");
                    Console.WriteLine("C) Log");
                    Console.WriteLine("D) Quit");
                }

                // if user enters C
                else if (choice == "C")
                {
                    Console.WriteLine();
                    Console.WriteLine("--------------");
                    Console.WriteLine("Welcome to Log");

                    //sorts words
                    words.Sort((b, a) => a.Length.CompareTo(b.Length));

                    //checks for duplicate words
                    HashSet<string> hashset = new HashSet<string>();
                    IEnumerable<string> duplicates = words.Where(e => !hashset.Add(e));

                    // prints duplicate words
                    Console.WriteLine("Repeated elements are: " + String.Join(", ", duplicates));

                    //menu
                    Console.WriteLine("Menu (Choose one of the four options (A, B, C, or D))");
                    Console.WriteLine("A) Practice");
                    Console.WriteLine("B) Analytics");
                    Console.WriteLine("C) Log");
                    Console.WriteLine("D) Quit");

                }
            }
        }
    }
}
