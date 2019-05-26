#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

long long fact(long long n)
{
    if (n == 1) {
        return 1;
    }
    return n * fact(n - 1);
}

int main() {
    const long long m = 1000000007;
    long long N, X;
    cin >> N >> X;
    vector<long long> S(N);
    long long res = 0;
    for (long long i = 0; i < N; i++) {
        cin >> S[i];
    }
    sort(S.begin(), S.end());
    long long top = fact(N);
    for (long long i = 0; i < top; i++) {
        res += X % S[1];
    }
    res = res % m;
    cout << res << "\n";
    return 0;
}