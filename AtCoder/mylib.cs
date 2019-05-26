public class UnionFind
{
    int[] par;
    int[] size;

    public UnionFind(int N)
    {
        par = new int[N];
        size = new int[N];
        for (int i = 0; i < N; i++)
        {
            par[i] = i;
            size[i] = 1;
        }
    }

    public int Root(int x)
    {
        if (par[x] == x) return x;
        return par[x] = Root(par[x]);
    }

    public void Unite(int x, int y)
    {
        int rootX = Root(x);
        int rootY = Root(y);
        if (rootX == rootY) return;
        par[rootX] = rootY;
        size[rootY] += size[rootX];
    }

    public bool Same(int x, int y)
    {
        int rootX = Root(x);
        int rootY = Root(y);
        return rootX == rootY;
    }

    public int Size(int x)
    {
        return size[Root(x)];
    }
}

#region Heap
public class Heap<T> where T: IComparable<T>
{
    private List<T> _heap;
    private int _size;
    public int Size => _size;

    public Heap()
    {
        _size = 0;
        _heap = new List<T>();
    }

    public List<T> ToList()
    {
        return _heap;
    }

    public void Push(T elem)
    {
        int _ref = _size;
        _heap.Add(elem);

        while (_ref != 0)
        {
            int i = (_ref - 1) / 2;
            if (_heap[_ref].CompareTo(_heap[i]) < 0) Swap(_ref, i);
            _ref = i;
        }
        _size++;
    }

    public T Pop()
    {
        T ret = _heap[0];
        int _ref = _size - 1;
        _heap[0] = _heap[_ref];
        _heap.RemoveAt(_ref);

        for (int i = 0, j; (j = 2 * i + 1) < _ref;)
        {
            if ((j != _ref - 1) && (_heap[j].CompareTo(_heap[j + 1]) > 0)) j++;
            if (_heap[i].CompareTo(_heap[j]) > 0) Swap(i, j);
            i = j;
        }
        _size--;

        return ret;
    }

    private void Swap(int m, int n)
    {
        T temp = _heap[m];
        _heap[m] = _heap[n];
        _heap[n] = temp;
    }
}
#endregion

#region PriorityQueue
public class PriorityQueue<T> where T: IComparable<T>
{
    Heap<T> _priority_queue;
    public int Size => _priority_queue.Size;

    public PriorityQueue()
    {
        _priority_queue = new Heap<T>();
    }

    public List<T> ToList() { return _priority_queue.ToList(); }

    public void Push(T elem) { _priority_queue.Push(elem); }

    public T Pop() { return _priority_queue.Pop(); }
}
#endregion