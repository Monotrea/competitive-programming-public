#include <cstdio>
#include <iostream>

using namespace std;

int main()
{
    int a, b;
    cin >> a >> b;
    if (b % a == 0)
    {
        printf("%d\n", a + b);
    }
    else
    {
        printf("%d\n", b - a);
    }
    return 0;
}