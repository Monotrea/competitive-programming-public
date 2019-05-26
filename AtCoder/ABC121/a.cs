using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int H = int.Parse(S[0]);
            int W = int.Parse(S[1]);
            string[] S2 = Console.ReadLine().Split(' ');
            int h = int.Parse(S2[0]);
            int w = int.Parse(S2[1]);
            Console.WriteLine("{0}", (H - h) * (W - w));
        }
    }
}