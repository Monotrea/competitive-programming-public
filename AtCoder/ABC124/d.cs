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
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int K = int.Parse(s[1]);
            string S = Console.ReadLine();
            int[] resblacks = new int[100001];
            int[] black = new int[100001];
            int[] white = new int[100001];
            int blackcount = 0;
            int whitecount = 0;
            int startidx = 0;
            int finishidx = 0;
            char bef = S[0];
            if (S[0] == '0')
            {
                black[blackcount] = 0;
                resblacks[blackcount] = 0;
                blackcount++;
            }
            for (int i = 0; i < N; i++)
            {
                if (S[i] == bef)
                {
                    finishidx = i;
                }
                else
                {
                    if (bef == '0')
                    {
                        white[whitecount] = finishidx - startidx + 1;
                        whitecount++;
                    }
                    else
                    {
                        black[blackcount] = finishidx - startidx + 1;
                        resblacks[blackcount] = finishidx - startidx + 1;
                        blackcount++;
                    }
                    startidx = i;
                    finishidx = i;
                    bef = S[i];
                }
            }
            if (bef == '0')
            {
                white[whitecount] = finishidx - startidx + 1;
                whitecount++;
                black[blackcount] = 0;
                resblacks[blackcount] = 0;
                blackcount++;
            }
            else
            {
                black[blackcount] = finishidx - startidx + 1;
                resblacks[blackcount] = finishidx - startidx + 1;
                blackcount++;
            }
            int res = black[0];
            for (int i = 0; i < Math.Min(whitecount, K); i++) res += black[i + 1] + white[i];
            int resbef = res;
            int firsti = 0;
            for (int i = K; i < blackcount - 1; i++)
            {
                int restemp = resbef - black[firsti] - white[firsti] + white[i] + black[i + 1];
                firsti++;
                resbef = restemp;
                res = Math.Max(res, restemp);
            }
            Console.WriteLine(res);
        }
    }
}