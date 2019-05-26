#include <iostream>
#include <vector>
#include <cstdlib>
#include <algorithm>

using namespace std;

int main() {
    vector< vector<bool> > ok(101, vector<bool>(101, true));
    vector< vector<long> > hres(101, vector<long>(101, -1));
    int N;
    int x = 0, y = 0;
    long h = 0;
    long h0 = 0;
    cin >> N;
    for (int i = 0; i < N; i++) {
        int xx, yy;
        long hh;
        cin >> xx >> yy;
        cin >> hh;
        for (int j = 0; j < 101; j++) {
            for (int k = 0; k < 101; k++) {
                if (ok[j][k]) {
                    long htemp = hh + (long)abs(xx - j) + (long)abs(yy - k);
                    if (hh == 0) {
                        if (htemp > hres[j][k]) {
                            continue;
                        } else if (htemp < hres[j][k]) {
                            ok[j][k] = false;
                            continue;
                        }
                    }
                    if (hres[j][k] == -1) hres[j][k] = htemp;
                    if (hres[j][k] != htemp) {
                        ok[j][k] = false;
                        continue;
                    }
                    x = j; y = k; h = htemp;
                }
            }
        }
    }
    cout << x << " " << y << " " << h << "\n";
    return 0;
}