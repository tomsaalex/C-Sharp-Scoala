using System;

namespace Fisa1_3
{
    class Program
    {

        static int CMMDC(int a, int b)
        {
            int r;
            while(b > 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(CMMDC(a, b));
            Console.WriteLine(a * b / CMMDC(a, b));
        }
    }
}
