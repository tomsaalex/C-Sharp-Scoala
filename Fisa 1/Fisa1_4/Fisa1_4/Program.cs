using System;
using System.Runtime.InteropServices;

namespace Fisa1_4
{
    class Program
    {
        static bool Prim(int a)
        {
            if (a < 2)
                return false;
            if (a % 2 == 0 && a != 2)
                return false;
            for (int d = 3; d * d <= a; d += 2)
                if (a % d == 0)
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
        
           if(Prim(a))
            {
                Console.WriteLine("Numărul este prim.");
            }
            else
            {
                Console.WriteLine("Numărul nu este prim.");
            }
        }
    }
}
