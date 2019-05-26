using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AtCoder
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            bool flag = false;
            long res = 0;
            List<int> lwhite = new List<int>();
            List<int> lblack = new List<int>();
            if (S[0] == '.') lblack.Add(0);
            char bef = S[0];
            int temp = 0;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == bef)
                {
                    temp++;
                }
                else
                {
                    if (bef == '.')
                    {
                        lwhite.Add(temp);
                    }
                    else
                    {
                        lblack.Add(temp);
                    }
                    temp = 1;
                    bef = S[i];
                }
            }
            if (bef == '.')
            {
                lwhite.Add(temp);
            }
            else
            {
                lblack.Add(temp);
                lwhite.Add(0);
            }
            long bnum = 0, wnum = 0;
            bnum += lblack[0];
            for (int i = 1; i < lwhite.Count; i++)
            {
                wnum += lwhite[i];
            }
            long restemp = bnum + wnum;
            long minres = restemp;
            for (int i = 1; i < lwhite.Count; i++)
            {
                restemp = restemp - lwhite[i] + lblack[i];
                minres = (minres > restemp)? restemp: minres;
            }
            for (int i = 0; i < N; i++)
            {
                if (S[i] == '#') flag = true;
                if (flag && S[i] == '.') res++;
            }
            flag = false;
            long res2 = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                if (S[i] == '.') flag = true;
                if (flag && S[i] == '#') res2++;
            }
            long ress = (res < res2)? res: res2;
            Console.WriteLine((minres < ress)? minres: ress);
        }
    }
}