using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AtCoder124
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            int K = int.Parse(Console.ReadLine());
            char s = S[K-1];
            char[] res = new char[N];
            for (int i = 0; i < N; i++)
            {
                res[i] = (S[i] != s)? '*': S[i];
            }
            string resS = new string(res);
            Console.WriteLine(resS);
        }
    }
}