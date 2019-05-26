#include <iostream>
#include <algorithm>
#include <vector>
#include <string>

using namespace std;

int main() {
    string N;
    cin >> N;
    char f = N[0];
    char res[N.size()];
    bool ok = true;
    for (int i = 0; i < N.size(); i++) {
        res[i] = f;
        if (N[i] <= f) {
            continue;
        }
        ok = false;
    }
    if (!ok) {
        for (int i = 0; i < N.size(); i++) {
            res[i]++;
        }
    }
    string resstr(res, N.size());
    cout << resstr << "\n";
    return 0;
}