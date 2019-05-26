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
            string S = Console.ReadLine();
            char bef = S[0];
            int res = 0;
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] == bef)
                {
                    res++;
                    if (bef == '0')
                    {
                        bef = '1';
                    }
                    else
                    {
                        bef = '0';
                    }
                }
                else
                {
                    bef = S[i];
                }
            }
            Console.WriteLine(res);
        }
    }
}