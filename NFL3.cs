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
            List<String> uniqueWords = new List<String>();

            Console.WriteLine("Enter words (-1 to quit): ");

            while (word != "-1")
            {
                if (word != "-1")
                {
                    word = Console.ReadLine();
                    words.Add(word);
                }
            }

            words.Remove("-1");
            int count = 0;

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = i; j < words.Count; j++)
                {
                    if (!uniqueWords.Contains(words[j]))
                    {
                        uniqueWords.Add(words[j]);
                    }
                }
            }
            for (int i = 0; i < uniqueWords.Count; i++)
            {
                count = 0;
                for (int j = 0; j < words.Count; j++)
                {
                    if (words[j] == uniqueWords[i])
                    {
                        count += 1;
                    }
                }
                Console.WriteLine(uniqueWords[i] + " occurred " + count + " times.");
            }
        }
    }
}
