using System;

namespace Fisa_6_Cuvinte1_973
{
    class Program
    {
        static bool OnlyVowels(string s)
        {
            string vowels = "aeiou";
            foreach(char c in s)
            {
                if (!vowels.Contains(c))
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string[] words = s.Split(" ");
            foreach(string word in words)
            {
                if (OnlyVowels(word))
                    Console.WriteLine(word);
            }
        }
    }
}
