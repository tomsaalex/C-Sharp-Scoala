using System;

namespace Fisa_6_Vocale_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] characters = s.ToCharArray();
            string vowels = "aeiou";

            for(int i = 0; i < characters.Length; i++)
                if (char.IsLower(characters[i]) && vowels.Contains(characters[i]))
                    characters[i] = char.ToUpper(characters[i]);

            s = string.Join("", characters);
            Console.WriteLine(s);
        }
    }
}
