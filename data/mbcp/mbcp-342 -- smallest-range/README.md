# mbcp-342 -- Find smallest range covering all arrays

## Text

Write a function to find the smallest range that includes at-least one element from each of the given arrays.

## Code

```csharp
class Node
{
    public int Value { get; set; }
    public int ListNum { get; set; }
    public int Index { get; set; }

    public Node(int value, int listNum, int index)
    {
        Value = value;
        ListNum = listNum;
        Index = index;
    }

    public static bool operator <(Node a, Node b)
    {
        return a.Value < b.Value;
    }

    public static bool operator >(Node a, Node b)
    {
        return a.Value > b.Value;
    }
}

public (int, int) FindMinimumRange(List<List<int>> list)
{
    int high = int.MinValue;
    (int, int) p = (0, int.MaxValue);
    SortedSet<Node> pq = new SortedSet<Node>();

    for (int i = 0; i < list.Count; i++)
    {
        pq.Add(new Node(list[i][0], i, 0));
        high = Math.Max(high, list[i][0]);
    }

    while (true)
    {
        Node top = pq.Min;
        pq.Remove(top);
        int low = top.Value;
        int i = top.ListNum;
        int j = top.Index;

        if (high - low < p.Item2 - p.Item1)
        {
            p = (low, high);
        }

        if (j == list[i].Count - 1)
        {
            return p;
        }

        Node newNode = new Node(list[i][j + 1], i, j + 1);
        pq.Add(newNode);
        high = Math.Max(high, list[i][j + 1]);
    }
}
```

## Test List

```csharp
Debug.Assert(FindMinimumRange(new int[][] { new int[] { 3, 6, 8, 10, 15 }, new int[] { 1, 5, 12 }, new int[] { 4, 8, 15, 16 }, new int[] { 2, 6 } }) == (4, 6));
```

```csharp
Debug.Assert(FindMinimumRange(new int[][] { new int[] { 2, 3, 4, 8, 10, 15 }, new int[] { 1, 5, 12 }, new int[] { 7, 8, 15, 16 }, new int[] { 3, 6 } }) == (4, 7));
```

```csharp
Debug.Assert(FindMinimumRange(new List<List<int>> { new List<int> { 4, 7, 9, 11, 16 }, new List<int> { 2, 6, 13 }, new List<int> { 5, 9, 16, 17 }, new List<int> { 3, 7 } }) == (5, 7));
```
