using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC110
{
    class Program
    {
        static long mod = 1000000007;
        static Dictionary<long, int> Factorize(long M)
        {
            Dictionary<long, int> res = new Dictionary<long, int>();
            long i = 2;
            while (M != 1)   
            {
                while (M % i == 0)
                {
                    if (!res.ContainsKey(i))
                    {
                        res[i] = 1;
                    }
                    else
                    {
                        res[i]++;
                    }
                    M /= i;
                }
                i++;
            }
            return res;
        }

        static long Modpow(long a, long n)
        {
            long res = 1;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    res = (res * a) % mod;
                }
                a = (a * a) % mod;
                n = n >> 1;
            }
            return res;
        }

        static long Modinv(long a)
        {
            return Modpow(a, mod - 2);
        }

        static long Combination(long a, long b)
        {
            long top = 1, bottom = 1;
            for (long i = 1; i <= b; i++)
            {
                top *= a - i + 1;
                bottom *= i;
                top = top % mod;
                bottom = bottom % mod;
            }
            return (top * Modinv(bottom)) % mod;
        }

        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            long M = long.Parse(s[1]);
            Dictionary<long, int> d = Factorize(M);
            long res = 1;
            foreach (long a in d.Keys)
            {
                res *= Combination(d[a] + N - 1, d[a]);
                res = res % mod;
            }
            Console.WriteLine(res);
        }
    }
}