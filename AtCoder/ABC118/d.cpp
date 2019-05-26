#include <cstdio>
#include <iostream>
#include <algorithm>

using namespace std;

int match[9] = {2, 5, 5, 4, 5, 6, 3, 7, 6};

class Op {
    public: bool operator()(const int& a, const int& b)
    const {
        if (match[a-1] < match[b-1])
        {
            return true;
        }
        else if (match[a-1] == match[b-1])
        {
            if (a > b)
                return true;
            else
                return false;
        }
        else
        {
            return false;
        }
    }
};

class Op2 {
    public: bool operator()(const int& a, const int& b)
    const {
        if (match[a-1] > match[b-1])
        {
            return true;
        }
        else if (match[a-1] == match[b-1])
        {
            if (a > b)
                return true;
            else
                return false;
        }
        else
        {
            return false;
        }
    }
};

int main()
{
    int n, m;
    cin >> n >> m;
    int um[m];
    int um2[m];
    for (int i = 0; i < m; i++)
    {
        cin >> um[i];
        um2[i] = um[i];
    }
    sort(um, um + m, Op());
    sort(um2, um2 + m, Op2());
    int n2 = n % match[um[0] - 1];
    int usematch[9];
    for (int i = 0; i < 9; i++)
    {
        usematch[i] = 0;
    }
    usematch[um[0] - 1] = n / match[um[0] - 1];
    while (n2 != 0)
    {
        usematch[um[0] - 1]--;
        n2 += match[um[0] - 1];
        for (int i = 0; i < m; i++)
        {
            if (n2 >= match[um2[i] - 1])
            {
                usematch[um2[i] - 1]++;
                n2 -= match[um2[i] - 1];
                break;
            }
        }
    }
    for (int i = 8; i >= 0; i--)
    {
        for (int j = 0; j < usematch[i]; j++)
        {
            printf("%d", i + 1);
        }
    }
    printf("\n");
    return 0;
}