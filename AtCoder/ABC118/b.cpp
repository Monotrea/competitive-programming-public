#include <cstdio>
#include <iostream>

using namespace std;

int main()
{
    int n, m;
    int data[30];
    int nowdata[30];
    for (int i = 0; i < 30; i++)
    {
        data[i] = 1;
        nowdata[i] = 0;
    }
    cin >> n >> m;
    for (int i = 0; i < n; i++)
    {
        int k;
        cin >> k;
        for (int j = 0; j < k; j++)
        {
            int a;
            cin >> a;
            nowdata[a - 1] = 1;
        }
        for (int j = 0; j < 30; j++)
        {
            if (data[j])
            {
                if (!nowdata[j])
                    data[j] = 0;
            }
            nowdata[j] = 0;
        }
    }

    int res = 0;

    for (int i = 0; i < 30; i++)
    {
        if (data[i])
            res++;
    }

    printf("%d\n", res);
    return 0;
}