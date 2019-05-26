#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {
    long N, M;
    cin >> N >> M;
    long D = 0;
    for (long i = (M / N); i >= 1; i--) {
        if (M % i == 0) {
            D = i;
            break;
        }
    }
    cout << D << "\n";
    return 0;
}