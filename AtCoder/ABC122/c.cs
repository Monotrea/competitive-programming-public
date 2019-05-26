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
            string[] s1 = Console.ReadLine().Split(' ');
            long N = long.Parse(s1[0]);
            int Q = int.Parse(s1[1]);
            string S = Console.ReadLine();
            int[] ll = new int[Q];
            int[] rr = new int[Q];
            int[] ress = new int[Q];
            for (int i = 0; i < Q; i++)
            {
                string[] s2 = Console.ReadLine().Split(' ');
                ll[i] = int.Parse(s2[0]);
                rr[i] = int.Parse(s2[1]);
            }
            int[] dpres = new int[N];
            dpres[0] = 0;
            bool flag1 = false;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'A')
                {
                    flag1 = true;
                    dpres[i] = (i > 0)? dpres[i - 1] : 0;
                    continue;
                }
                if (S[i] == 'C' && flag1 == true)
                {
                    flag1 = false;
                    dpres[i] = dpres[i - 1] + 1;
                    continue;
                }
                flag1 = false;
                dpres[i] = (i > 0)? dpres[i - 1]: 0;
            }
            for (int i = 0; i < Q; i++)
            {
                int temp = 0;
                if (S[ll[i] - 1] == 'C')
                {
                    if (ll[i] > 1)
                    {
                        if (S[ll[i] - 2] == 'A')
                        {
                            temp = dpres[rr[i] - 1] - dpres[ll[i] - 2] - 1;
                        }
                        else
                        {
                            temp = dpres[rr[i] - 1] - dpres[ll[i] - 2];
                        }
                    }
                    else
                    {
                        temp = dpres[rr[i] - 1];
                    }
                }
                else
                {
                    if (ll[i] > 1)
                    {
                        temp = dpres[rr[i] - 1] - dpres[ll[i] - 2];
                    }
                    else
                    {
                        temp = dpres[rr[i] - 1];
                    }
                }
                ress[i] = temp;
            }
            for (int i = 0; i < Q; i++)
            {
                Console.WriteLine(ress[i]);
            }
        }
    }
}