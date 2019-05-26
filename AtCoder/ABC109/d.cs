using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC109
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int H = int.Parse(s[0]);
            int W = int.Parse(s[1]);
            int[,] a = new int[H, W];
            for (int i = 0; i < H; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < W; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }
        }
    }
}