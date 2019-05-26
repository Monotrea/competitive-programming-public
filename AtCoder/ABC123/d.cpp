#include <iostream>
#include <vector>
#include <algorithm>
#include <string>

using namespace std;

int main() {
    int X, Y, Z, K;
    cin >> X >> Y >> Z >> K;
    vector<long> A(X);
    vector<long> B(Y);
    vector<long> C(Z);
    for (int i = 0; i < X; i++) cin >> A[i];
    for (int i = 0; i < Y; i++) cin >> B[i];
    for (int i = 0; i < Z; i++) cin >> C[i];
    vector<long> D(X * Y);
    for (int i = 0; i < X; i++) {
        for (int j = 0; j < Y; j++) {
            D[i * Y + j] = A[i] + B[j];
        }
    }
    sort(D.begin(), D.end());
    int k = (K > X * Y)? X * Y: K;
    vector<long> newD(k);
    for (int i = 0; i < k; i++) newD[i] = D[X * Y - 1 - i];
    vector<long> D2(k * Z);
    for (int i = 0; i < k; i++) {
        for (int j = 0; j < Z; j++) {
            D2[i * Z + j] = newD[i] + C[j];
        }
    }
    sort(D2.begin(), D2.end());
    for (int i = k * Z - 1; i >= k * Z - K; i--) cout << D2[i] << "\n";
    return 0;
}