using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AtCoderABC122
{
    class Program
    {
        public static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int res = 0;
            int temp = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'A' || S[i] == 'T' || S[i] == 'G' || S[i] == 'C')
                {
                    temp++;
                }
                else
                {
                    res = (res < temp) ? temp: res;
                    temp = 0;
                }
            }
            res = (res < temp) ? temp: res;
            Console.WriteLine(res);
        }
    }
}