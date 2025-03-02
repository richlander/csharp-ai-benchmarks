# mbcp951 -- Find max similar indices in two tuple lists

## Text

Write a function to find the maximum of similar indices in two lists of tuples.

## Code

```csharp
public List<(int, int)> MaxSimilarIndices(List<(int, int)> testList1, List<(int, int)> testList2) {
    var res = testList1.Zip(testList2, (x, y) => (Math.Max(x.Item1, y.Item1), Math.Max(x.Item2, y.Item2))).ToList();
    return res;
}
```

## Test List

```csharp
Debug.Assert(MaxSimilarIndices(new List<Tuple<int, int>> { Tuple.Create(2, 4), Tuple.Create(6, 7), Tuple.Create(5, 1) }, new List<Tuple<int, int>> { Tuple.Create(5, 4), Tuple.Create(8, 10), Tuple.Create(8, 14) }).SequenceEqual(new List<Tuple<int, int>> { Tuple.Create(5, 4), Tuple.Create(8, 10), Tuple.Create(8, 14) }));
```

```csharp
Debug.Assert(MaxSimilarIndices(new List<(int, int)> { (3, 5), (7, 8), (6, 2) }, new List<(int, int)> { (6, 5), (9, 11), (9, 15) }).SequenceEqual(new List<(int, int)> { (6, 5), (9, 11), (9, 15) }));
```

```csharp
Debug.Assert(MaxSimilarIndices(new List<Tuple<int, int>> { Tuple.Create(4, 6), Tuple.Create(8, 9), Tuple.Create(7, 3) }, new List<Tuple<int, int>> { Tuple.Create(7, 6), Tuple.Create(10, 12), Tuple.Create(10, 16) }).SequenceEqual(new List<Tuple<int, int>> { Tuple.Create(7, 6), Tuple.Create(10, 12), Tuple.Create(10, 16) }));
```
