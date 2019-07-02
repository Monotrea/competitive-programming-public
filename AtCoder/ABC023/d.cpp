#include <iostream>
#include <algorithm>

using namespace std;

bool check(long* h, long* s, long x, int N)
{
    long t[N];
    for (int i = 0; i < N; i++)
    {
        if (x < h[i]) return false;
        t[i] = (x - h[i]) / s[i];
    }
    sort(t, t + N);
    for (int i = 0; i < N; i++)
    {
        if (t[i] < i) return false;
    }
    return true;
}

long binary_search(long* h, long* s, long left, long right, int N)
{
    while (left < right)
    {
        long mid = (left + right) / 2;
        if (check(h, s, mid, N))
        {
            right = mid;
        }
        else
        {
            left = mid + 1;
        }
    }
    return left;
}

int main()
{
    int N;
    cin >> N;
    long h[N];
    long s[N];
    long m = 0;
    for (int i = 0; i < N; i++)
    {
        cin >> h[i] >> s[i];
        long d = h[i] + s[i] * (long)(N - 1);
        if (d >= m)
        {
            m = d;
        }
    }
    cout << binary_search(h, s, 1, m + 1, N) << "\n";
    return 0;
}