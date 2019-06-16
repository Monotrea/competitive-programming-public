#include <iostream>

#define NMAX 2000001
#define AMAX 10000

using namespace std;

void counting_sort(unsigned short* A, unsigned short* B, int n, int k)
{
    int C[k + 1];
    for (int i = 0; i <= k; i++) C[i] = 0;
    for (int i = 0; i < n; i++) C[A[i]]++;
    for (int i = 1; i <= k; i++) C[i] += C[i - 1];
    for (int i = n - 1; i >= 0; i--)
    {
        B[C[A[i]] - 1] = A[i];
        C[A[i]]--;
    }
}

int main()
{
    int n;
    cin >> n;
    unsigned short A[n];
    unsigned short B[n];
    for (int i = 0; i < n; i++) cin >> A[i];
    counting_sort(A, B, n, NMAX);
    for (int i = 0; i < n - 1; i++) cout << B[i] << " ";
    cout << B[n - 1] << "\n";
    return 0;
}