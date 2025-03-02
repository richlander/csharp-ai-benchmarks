# mbcp921 -- Chunk tuples into smaller groups of size n

## Text

Write a function to perform chunking of tuples each of size n.

## Code

```csharp
public List<Tuple<int, int>> ChunkTuples(List<Tuple<int, int>> testTup, int N) {
    List<List<Tuple<int, int>>> res = new List<List<Tuple<int, int>>>();
    for (int i = 0; i < testTup.Count; i += N) {
        res.Add(testTup.Skip(i).Take(N).ToList());
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(ChunkTuples(new int[] { 10, 4, 5, 6, 7, 6, 8, 3, 4 }, 3).SequenceEqual(new List<(int, int, int)> { (10, 4, 5), (6, 7, 6), (8, 3, 4) }));
```

```csharp
Debug.Assert(ChunkTuples(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2).SequenceEqual(new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 }, new[] { 9 } }));
```

```csharp
Debug.Assert(ChunkTuples(new int[] { 11, 14, 16, 17, 19, 21, 22, 25 }, 4).SequenceEqual(new List<(int, int, int, int)> { (11, 14, 16, 17), (19, 21, 22, 25) }));
```
