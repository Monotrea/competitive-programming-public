using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC129
{
    class Program
    {
        public static void Main()
        {
            int[] P = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(P);
            Console.WriteLine(P[0] + P[1]);
        }
    }
}