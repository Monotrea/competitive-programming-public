
// http://kumikomiya.com/competitive-programming-with-c-sharp/

// 最大公約数
static long Gcd(long a, long b)
{
    return (a < b) ? Gcd(b, a)
         : (b > 0) ? Gcd(b, a % b)
                   : a;
}

// 最小公倍数
static long Lcm(long a, long b)
{
    return a / Gcd(a, b) * b;
}

// 繰り返し二乗法
class Modulo
{
    private const int M = 1000000007;
    private readonly int[] m_facs;
    public int Mul(int a, int b)
    {
        return (int)(Math.BigMul(a, b) % M);
    }
    public Modulo(int n)
    {
        m_facs = new int[n + 1];
        m_facs[0] = 1;
        for (int i = 1; i <= n; i++)
        {
            m_facs[i] = Mul(m_facs[i - 1], i);
        }
    }
    public int Fac(int n)
    {
        return m_facs[n];
    }
    public int Pow(int a, int m)
    {
        switch (m)
        {
        case 0:
            return 1;
        case 1:
            return a;
        default:
            int p1 = Pow(a, m / 2);
            int p2 = Mul(p1, p1);
            return ((m % 2 == 0)) ? p2 : Mul(p2, a);
        }
    }
    public int Div(int a, int b)
    {
        return Mul(a, Pow(b, M - 2));
    }
    public int Ncr(int n, int r)
    {
        if (n < r) { return 0; }
        if (n == r) { return 1; }
        int res = Fac(n);
        res = Div(res, Fac(r));
        res = Div(res, Fac(n - r));
        return res;
    }
}