#include <iostream>
#include <algorithm>
#include <vector>
#include <string>
#include <cstdlib>

using namespace std;

int main() {
    string n;
    cin >> n;
    char res[3];
    for (int i = 0; i < 3; i++)
    {
        res[i] = n[i];
        if (n[i] == '1') res[i] = '9';
        if (n[i] == '9') res[i] = '1';
    }
    string resstr(res, 3);
    cout << resstr << "\n";
    return 0;
}