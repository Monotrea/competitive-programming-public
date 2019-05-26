using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC126
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int K = int.Parse(s[1]);
            string S = Console.ReadLine();
            char[] c = S.ToCharArray();
            char[] clow = S.ToLower().ToCharArray();
            c[K - 1] = clow[K - 1];
            Console.WriteLine(c);
        }
    }
}