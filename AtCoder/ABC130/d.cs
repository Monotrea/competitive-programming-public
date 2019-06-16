using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        long N = long.Parse(s[0]);
        long K = long.Parse(s[1]);
        long[] a = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
        long n = a[0];
        long cnt = 0;
        long res = 0;
        for (int i = 0; i < N; i++)
        {
            bool flag = false;
            if (i > 0) n -= a[i - 1];
            while (cnt < N)
            {
                if (cnt < i)
                {
                    cnt = i;
                    n = a[i];
                }
                if (flag) n += a[cnt];
                if (n >= K)
                {
                    res += N - cnt;
                    break;
                }
                cnt++;
                flag = true;
                if (cnt == N)
                {
                    cnt--;
                    break;
                }
            }
        }
        Console.WriteLine(res);
    }
}