using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    public class hoge
    {
        public long money;
        public long limit;
    }

    class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            long N = long.Parse(s[0]);
            long M = long.Parse(s[1]);
            hoge[] A = new hoge[N];
            for (long i = 0; i < N; i++)
            {
                string[] s2 = Console.ReadLine().Split(' ');
                A[i] = new hoge();
                A[i].money = long.Parse(s2[0]);
                A[i].limit = long.Parse(s2[1]);
            }
            hoge[] OrderedA = A.OrderBy(x => x.money).ToArray();
            long res = 0;
            for(int i = 0; i < N; i++)
            {
                if (OrderedA[i].limit < M)
                {
                    M -= OrderedA[i].limit;
                    res += OrderedA[i].limit * OrderedA[i].money;
                }
                else if (OrderedA[i].limit == M)
                {
                    M = 0;
                    res += OrderedA[i].limit * OrderedA[i].money;
                    break;
                }
                else
                {
                    res += M * OrderedA[i].money;
                    M = 0;
                    break;
                }
            }
            Console.WriteLine("{0}", res);
        }
    }
}