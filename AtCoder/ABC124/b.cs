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
            int[] H = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int hmax = H[0];
            int res = 0;
            for (int i = 0; i < N; i++)
            {
                if (hmax <= H[i])
                {
                    res++;
                    hmax = H[i];
                }
            }
            Console.WriteLine(res);
        }
    }
}