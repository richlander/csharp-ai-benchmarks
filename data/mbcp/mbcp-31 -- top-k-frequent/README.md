# mbcp-31 -- Find top k most frequent integers using heaps

## Text

Write a function to find the top k integers that occur most frequently from given lists of sorted and distinct integers using heap queue algorithm.

## Code

```csharp
public List<int> Func(int[][] nums, int k)
{
    var d = new Dictionary<int, int>();
    foreach (var row in nums)
    {
        foreach (var i in row)
        {
            if (d.ContainsKey(i))
                d[i]++;
            else
                d[i] = 1;
        }
    }
    
    var temp = new List<(int, int)>();
    foreach (var kvp in d)
    {
        int key = kvp.Key;
        int v = kvp.Value;
        if (temp.Count < k)
        {
            temp.Add((v, key));
            if (temp.Count == k)
                temp.Sort((a, b) => a.Item1.CompareTo(b.Item1));
        }
        else
        {
            if (v > temp[0].Item1)
            {
                temp.RemoveAt(0);
                temp.Add((v, key));
                temp.Sort((a, b) => a.Item1.CompareTo(b.Item1));
            }
        }
    }

    var result = new List<int>();
    while (temp.Count > 0)
    {
        var (v, key) = temp[0];
        temp.RemoveAt(0);
        result.Add(key);
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(Func(new List<List<int>>{ new List<int>{1, 2, 6}, new List<int>{1, 3, 4, 5, 7, 8}, new List<int>{1, 3, 5, 6, 8, 9}, new List<int>{2, 5, 7, 11}, new List<int>{1, 4, 7, 8, 12} }, 3).SequenceEqual(new List<int>{5, 7, 1}));
```

```csharp
Debug.Assert(Func(new List<List<int>> { new List<int> { 1, 2, 6 }, new List<int> { 1, 3, 4, 5, 7, 8 }, new List<int> { 1, 3, 5, 6, 8, 9 }, new List<int> { 2, 5, 7, 11 }, new List<int> { 1, 4, 7, 8, 12 } }, 1).SequenceEqual(new List<int> { 1 }));
```

```csharp
Debug.Assert(Func(new List<List<int>> { new List<int> { 1, 2, 6 }, new List<int> { 1, 3, 4, 5, 7, 8 }, new List<int> { 1, 3, 5, 6, 8, 9 }, new List<int> { 2, 5, 7, 11 }, new List<int> { 1, 4, 7, 8, 12 } }, 5).SequenceEqual(new List<int> { 6, 5, 7, 8, 1 }));
```
