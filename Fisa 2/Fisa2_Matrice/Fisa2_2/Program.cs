using System;
using System.Globalization;
using System.Runtime.ExceptionServices;

namespace Fisa2_2  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu dimensiunile matricei: ");

            int n, m;
            string s = Console.ReadLine();
            string[] el = s.Split(" ");

            n = int.Parse(el[0]);
            m = int.Parse(el[1]);

            Console.WriteLine("Introdu matricea, cate o linie pe rand:");

            int[,] matrice = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string linie = Console.ReadLine();
                string[] elemente = linie.Split(" ");

                for(int j = 0; j < m; j++)
                {
                    matrice[i, j] = int.Parse(elemente[j]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrice[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int produsDiagPrinc = 1;
            int produsDiagSec = 1;
            for (int i = 0; i < n; i++)
            {
                produsDiagPrinc *= matrice[i, i];
                produsDiagSec *= matrice[i, n - i - 1];
            }
            Console.WriteLine($"Produsul de pe diagonala principala este: {produsDiagPrinc}");
            Console.WriteLine($"Produsul de pe diagonala secundara este: {produsDiagSec}");

            int[] indiciSumePare = new int[101];
            int index = 0;
            for(int i = 0; i < n; i++)
            { 
                int sum = 0;
                for(int j = 0; j < m; j++)
                {
                    sum += matrice[i, j];
                }
                if (sum % 2 == 0)
                {
                    indiciSumePare[index++] = i;
                }
            }


            Console.Write("\nLiniile care au suma elementelor pare au indicii:");
            for (int i = 0; i < index; i++)
                Console.Write($"{indiciSumePare[i]} ");

            Console.WriteLine();
            Console.WriteLine();

            int Min = int.MaxValue, Max = int.MinValue;
            int[,] matriceNoua = new int[n, m];

            for(int i = 0; i < n; i++)
                for(int j = 0; j < m; j++)
                {
                    if (matrice[i, j] < Min)
                        Min = matrice[i, j];
                    if (matrice[i, j] > Max)
                        Max = matrice[i, j];
                }

            for (int i = 0; i < n; i++)
            {
                bool contine = false;
                for (int j = 0; j < m; j++)
                {
                    if (matrice[i, j] == Max)
                    {
                        contine = true;
                        break;
                    }
                }
                if (contine)
                    for (int j = 0; j < m; j++)
                        matriceNoua[i, j] = Min;
                else
                    for (int j = 0; j < m; j++)
                    {
                        matriceNoua[i, j] = matrice[i, j];
                    }
            }

            Console.WriteLine("Matricea noua este:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{matriceNoua[i, j]} ");
                Console.WriteLine();
            }
        }   
    }
}
