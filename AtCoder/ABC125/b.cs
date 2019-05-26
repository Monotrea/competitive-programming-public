using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC125
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] V = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] C = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int res = 0;
            for (int i = 0; i < N; i++)
            {
                if (V[i] - C[i] > 0)
                {
                    res += V[i] - C[i];
                }
            }
            Console.WriteLine(res);
        }
    }
}