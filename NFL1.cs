using System;
using System.Collections.Generic;
namespace NFL1
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = "";
            List<String> words = new List<String>();
            Console.WriteLine("Enter 10 words.");
            for (int i = 0; i < 10; i++)
            {
                word = Console.ReadLine();
                words.Add(word);
            }
            String temp = "";
            
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = i+1; j < words.Count; j++)
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
