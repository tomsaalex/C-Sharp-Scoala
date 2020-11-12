using System;

namespace Fisa_6_Acronim_2828
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = "";
            for(int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]) && (i == 0 || s[i - 1] == ' '))
                    result += s[i];
            }

            Console.WriteLine(result);
        }
    }
}
