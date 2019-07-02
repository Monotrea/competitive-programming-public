using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static long[] fac, finv, inv;

    static void init(long mod)
    {
        fac = new long[5001];
        finv = new long[5001];
        inv = new long[5001];
        fac[0] = 1;
        fac[1] = 1;
        finv[0] = 1;
        finv[1] = 1;
        inv[1] = 1;
        for (int i = 2; i < 5001; i++)
        {
            fac[i] = fac[i - 1] * i % mod;
            inv[i] = modinv(i, mod);
            finv[i] = finv[i - 1] * inv[i] % mod;
        }
    }

    static long modpow(long a, long n, long mod)
    {
        long res = 1;
        while (n > 0)
        {
            if ((n & 1) != 0) res = res * a % mod;
            a = a * a % mod;
            n >>= 1;
        }
        return res;
    }

    static long modinv(long a, long mod)
    {
        return modpow(a, mod - 2, mod);
    }

    static long modcomb(int a, int b, long mod)
    {
        if (a < b) return 0;
        if (a < 0 || b < 0) return 0;
        return fac[a] * (finv[b] * finv[a - b] % mod) % mod;
    }

    public static void Main(string[] args)
    {
        long mod = 1000000007;
        string[] S = Console.ReadLine().Split(' ');
        int N = int.Parse(S[0]);
        int K = int.Parse(S[1]);
        init(mod);
        for (int i = 1; i <= K; i++)
        {
            long a1 = modcomb(K - 1, i - 1, mod);
            long a2 = modcomb(N - K + 1, i, mod);
            long res = (a1 * a2) % mod;
            Console.WriteLine(res);
        }
    }
}