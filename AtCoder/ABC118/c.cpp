#include <cstdio>
#include <cstdlib>
#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    int n;
    cin >> n;
    int a[n];
    for (int i = 0; i < n; i++)
    {
        cin >> a[i];
    }
    sort(a, a + n);
    int bef = a[n - 1];
    while (1)
    {
        for (int i = n - 1; i > 0; i--)
        {
            if (a[i - 1] != 0)
                a[i] = a[i] % a[i - 1];
        }
        sort(a, a + n);
        if (bef == a[n - 1])
            break;
        bef = a[n - 1];
    }
    for (int i = 0; i < n; i++)
    {
        if (a[i] != 0)
        {
            printf("%d\n", a[i]);
            break;
        }
    }
    return 0;
}