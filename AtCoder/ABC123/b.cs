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
            int[] q = p.OrderBy(x => x % 10).ToArray();
            int res = 0;
            int resi = -1;
            for (int i = 0; i < 5; i++)
            {
                if (q[i] % 10 == 0)
                {
                    res += q[i];
                }
                else
                {
                    if (resi == -1)
                    {
                        resi = i;
                    }
                    else
                    {
                        res += q[i] - (q[i] % 10) + 10;
                    }
                }
            }
            res += (resi == -1)? 0: q[resi];
            Console.WriteLine(res);
        }
    }
}