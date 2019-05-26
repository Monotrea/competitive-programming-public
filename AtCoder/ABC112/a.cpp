#include <iostream>
#include <vector>

using namespace std;

int main() {
    int N;
    cin >> N;
    if (N == 1) {
        cout << "Hello World\n";
        return 0;
    }
    int A, B;
    cin >> A >> B;
    cout << A + B << "\n";
    return 0;
}