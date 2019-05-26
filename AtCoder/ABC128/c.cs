using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC128
{
    class Program
    {
        static int Search(int[] ss, int num, int M, List<int[]> s, int[] p)
        {
            if (num == ss.Length)
            {
                int res = 0;
                bool flag1 = true;
                for (int i = 0; i < M; i++)
                {
                    int cnt1 = 0;
                    for (int j = 0; j < s[i].Length; j++)
                    {
                        cnt1 += ss[s[i][j] - 1];
                    }
                    if (cnt1 % 2 != p[i]) flag1 = false;
                }
                if (flag1) res++;
                return res;
            }
            int[] ss1 = new int[ss.Length];
            int[] ss2 = new int[ss.Length];
            Array.Copy(ss, ss1, ss.Length);
            Array.Copy(ss, ss2, ss.Length);
            ss1[num] = 0;
            ss2[num] = 1;
            return Search(ss1, num + 1, M, s, p) + Search(ss2, num + 1, M, s, p);
        }
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int N = int.Parse(S[0]);
            int M = int.Parse(S[1]);

            int[] k = new int[M];
            List<int[]> s = new List<int[]>();

            for (int i = 0; i < M; i++)
            {
                S = Console.ReadLine().Split(' ');
                k[i] = int.Parse(S[0]);
                int[] ss = new int[k[i]];
                for (int j = 0; j < k[i]; j++)
                {
                    ss[j] = int.Parse(S[j + 1]);
                }
                s.Add(ss);
            }
            int[] p = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int res = 0;
            res = Search(new int[N], 0, M, s, p);
            
            Console.WriteLine(res);
        }
    }
}