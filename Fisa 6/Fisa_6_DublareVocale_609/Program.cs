using System;

namespace Fisa_6_DublareVocale_609
{
    class Program
    {
        static bool isVowel(char c)
        {
            string vowels = "aeiou";
            if (!vowels.Contains(c))
                return false;

            return true;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] characters = s.ToCharArray();

            int actualSize = s.Length;
            Array.Resize(ref characters, 201);

            for(int i = 0; i < actualSize; i++)
            {
                if(isVowel(characters[i]))
                {
                    for (int j = actualSize; j >= i + 1; j--)
                    {
                        characters[j] = characters[j - 1];
                    }  
                    characters[i + 1] = characters[i];

                    i++;
                    actualSize++;
                }
            }

            s = string.Join("", characters);
            Console.WriteLine(s);
        }
    }
}
