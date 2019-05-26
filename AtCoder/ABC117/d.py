a = list(range(1000))
for i in range(10, 10000):
    r = 0
    for aa in a:
        r += abs(i ^ aa)
    print(i, r)