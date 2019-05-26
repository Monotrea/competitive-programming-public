#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

struct Route {
    int cost;
    int tm;

    Route(int c, int t) {
        cost = c;
        tm = t;
    }

    bool operator<(const Route &param) const {
        return cost < param.cost;
    }
};

int main() {
    vector<Route> route;
    int N, T;
    cin >> N >> T;
    for (int i = 0; i < N; i++)
    {
        int c, t;
        cin >> c >> t;
        route.push_back(Route(c, t));
    }
    sort(route.begin(), route.end());
    for (int i = 0; i < N; i++) {
        if (route[i].tm <= T) {
            cout << route[i].cost << "\n";
            return 0;
        }
    }
    cout << "TLE\n";
    return 0;
}