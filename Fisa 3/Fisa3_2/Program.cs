using System;

namespace Fisa3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, max = int.MinValue;
            for(int i = 1; i <= 4; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a > max)
                    max = a;
            }

            Console.WriteLine(max);
        }
    }
}
