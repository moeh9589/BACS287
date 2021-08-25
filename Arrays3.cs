using System;

namespace Arrays_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            String word = Console.ReadLine();
            int l = word.Length;
            int count = 0;
            String reverse = "";
            String[] vowels = { "a", "e", "i", "o", "u"};

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < vowels.Length; j ++)
                {
                    //Console.WriteLine(word[i] + " " + vowels[j]);
                    String x = word[i].ToString().ToLower();
                    String y = vowels[j];
                    if (x.Equals(y))
                    {
                        count += 1;
                    }
                }

            }
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];

            }
            
            Console.WriteLine("Word input: " + word);
            Console.WriteLine("Vowel count: " +count);
            Console.WriteLine("Word in reverse: " + reverse);
        }
    }
}
