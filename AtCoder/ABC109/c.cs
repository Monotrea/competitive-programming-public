using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC109
{
    class Program
    {
        static long GCD(long a, long b)
        {
            return (a < b)? GCD(b, a):
                   (a % b == 0)? b:
                                 GCD(b, a % b);
        }
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            long X = long.Parse(s[1]);
            s = Console.ReadLine().Split(' ');
            long res = Math.Abs(long.Parse(s[0]) - X);
            for (int i = 1; i < N; i++)
            {
                long temp = Math.Abs(long.Parse(s[i]) - X);
                res = GCD(res, temp);
            }
            Console.WriteLine(res);
        }
    }
}