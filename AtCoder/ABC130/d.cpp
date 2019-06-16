#include <iostream>

using namespace std;

int main()
{
    long N, K;
    cin >> N >> K;
    long a[N];
    for (int i = 0; i < N; i++) cin >> a[i];
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++) dp[i][j] = 0;
    }
    dp[0][0] = a[0];
    for (int i = 1; i < N; i++) dp[0][i] = dp[0][i - 1] + a[i];
    for (int i = 1; i < N; i++)
    {
         for (int j = 1; j < N; j++) dp[i][j] = dp[i - 1][j] - a[i - 1];
    }
    long cnt = 0;
    for (int i = 0; i < N; i++)
    {
         for(int j = i; j < N; j++)
         {
             if (dp[i][j] >= K)
             {
                 cnt += N - (long)j;
                 break;
             }
         }
    }
    cout << cnt << "\n";
    return 0;
}