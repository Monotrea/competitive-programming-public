#include <iostream>
#include <algorithm>
#include <vector>
#include <string>

using namespace std;

int main() {
    int n;
    cin >> n;
    int v[n];
    vector<int> p(100001, 0);
    vector<int> q(100001, 0);
    for (int i = 0; i < n; i++) cin >> v[i];
    for (int i = 0; i < n; i += 2) {
        p[v[i]]++;
    }
    for (int i = 1; i < n; i += 2) {
        q[v[i]]++;
    }
    int leastp = 0;
    int leastp2 = 0;
    int leastq = 0;
    int leastq2 = 0;
    int minsp = 0;
    int minsp2 = 0;
    int minsq = 0;
    int minsq2 = 0;
    for (int i = 1; i < 100001; i++) {
        if (minsp <= p[i]) {
            minsp2 = minsp;
            leastp2 = leastp;
            minsp = p[i];
            leastp = i;
        }
        if (minsq <= q[i]) {
            minsq2 = minsq;
            leastq2 = leastq;
            minsq = q[i];
            leastq = i;
        }
    }
    long res = n;
    if (leastp == leastq) {
        res -= max((long)minsp + (long)minsq2, (long)minsp2 + (long)minsq);
    } else {
        res -= (long)minsp + (long)minsq;
    }
    cout << res << "\n";
    return 0;
}