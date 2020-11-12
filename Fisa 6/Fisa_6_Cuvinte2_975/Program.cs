using System;

namespace Fisa_6_Cuvinte2_975
{
    class Program
    {
        static bool palindrom(string s)
        {
            for (int i = 0; i <= s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                    return false;
                    
            }
                return true;
        }

        static void Main(string[] args)
        {
            string bestPalindrom = "";
            string s = Console.ReadLine();

            string[] words = s.Split(new char[]  {' ', ',', '.'});

            foreach(string word in words)
            { 
                if (word.Length > 0 && palindrom(word) && (String.Compare(word, bestPalindrom) < 0 || bestPalindrom.Length == 0))
                    bestPalindrom = word;
            }

            if (bestPalindrom.Length > 0)
                Console.WriteLine(bestPalindrom);
            else
                Console.WriteLine("IMPOSIBIL");
        }
    }
}
