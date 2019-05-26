using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AtCoderABC123
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] p = new int[5];
            p[0] = int.Parse(Console.ReadLine());
            p[1] = int.Parse(Console.ReadLine());
            p[2] = int.Parse(Console.ReadLine());
            p[3] = int.Parse(Console.ReadLine());
            p[4] = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            bool ff = false;
            for (int i = 0 ; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (p[j] - p[i] > k) ff = true;
                }
            }
            Console.WriteLine((ff)? ":(":"Yay!");
        }
    }
}