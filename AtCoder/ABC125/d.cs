using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC125
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).OrderBy(x => x).ToArray();
            int res = 0;
            int lastidx = -1;
            for (int i = 0; i < N; i++)
            {
                if (A[i] < 0)
                {
                    res++;
                    lastidx = i;
                }
                else
                {
                    break;
                }
            }
            long ressum = 0;
            if ((res % 2) == 0)
            {
                for (int i = 0; i < N; i++)
                {
                    if (A[i] < 0)
                    {
                        ressum -= A[i];
                    }
                    else
                    {
                        ressum += A[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    if (i == lastidx)
                    {
                        if ((i + 1 < N) && ((-A[i]) > A[i + 1]))
                        {
                            ressum -= A[i];
                            ressum -= A[i + 1];
                            i++;
                            continue;
                        }
                        else
                        {
                            ressum += A[i];
                            continue;
                        }
                    }
                    if (A[i] < 0)
                    {
                        ressum -= A[i];
                    }
                    else
                    {
                        ressum += A[i];
                    }
                }
            }
            Console.WriteLine(ressum);
        }
    }
}