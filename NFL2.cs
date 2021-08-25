using System;
using System.Collections.Generic;
namespace NFL_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = "";
            List<String> words = new List<String>();
            Console.WriteLine("Enter words (-1 to quit): ");
            while (word != "-1")
            {
                if (word != "-1")
                {
                    word = Console.ReadLine();
                    words.Add(word);
                }

            }
            String temp = "";
            words.Remove("-1");
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = i + 1; j < words.Count; j++)
                {
                    if (words[j].Length > words[i].Length)
                    {
                        temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
