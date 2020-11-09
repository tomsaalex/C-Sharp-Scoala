using System;
using System.Runtime.CompilerServices;

namespace Fisa_6_Pozitii_972
{
    class Program
    {
        public static bool IsVowel(char c)
        {
            string vowels = "aeiou";
            if (vowels.Contains(c))
                return true;
            return false;
        }

        public static bool IsConsonant(char c)
        {
            if (Char.IsLetter(c) && !IsVowel(c))
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            char[] characters = s.ToCharArray();

            int i;
            int count = 0;
            for(i = 0; i < characters.Length; i++)
            {
                if (i > 0 && IsConsonant(characters[i - 1]) && i < (characters.Length - 1) && IsConsonant(characters[i + 1]) && IsVowel(characters[i]))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
