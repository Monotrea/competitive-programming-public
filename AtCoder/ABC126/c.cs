using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC126
{
    class Program
    {
        static double GetProbability(int n, int k)
        {
            double i = 1.0;
            while (true)
            {
                if (n >= k)
                    break;
                n *= 2;
                i *= 0.5;
            }
            return i;
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int K = int.Parse(s[1]);
            double res = 0.0;
            double p = 1.0 / N;
            for (int i = 1; i <= N; i++)
                res += GetProbability(i, K);
            res *= p;
            Console.WriteLine(String.Format("{0:f10}", res));
        }
    }
}