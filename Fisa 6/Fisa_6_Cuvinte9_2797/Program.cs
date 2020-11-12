using System;

namespace Fisa_6_Cuvinte9_2797
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] words = s.Split(" ");

            int maxDigit = 0;
            int maxNum = -1;
            int num;
            foreach(string word in words)
            { 
                if(int.TryParse(word, out num))
                {
                    int numCopy = num;
                    while (num > 9)
                        num /= 10;
                    if(num > maxDigit)
                    {
                        maxDigit = num;
                        maxNum = numCopy;
                    }
                }
            }

            if (maxNum > -1)
                Console.WriteLine(maxNum);
            else
                Console.WriteLine("nu exista");
        }
    }
}
