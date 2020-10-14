using System;

namespace Fisa1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            Console.WriteLine(MathF.Max(a, b));
        }
    }
}
