# mbcp969 -- Join tuples by matching their initial elements

## Text

Write a function to join the tuples if they have similar initial elements.

## Code

```csharp
public List<Tuple<int, int>> JoinTuples(List<Tuple<int, int>> testList) {
    List<List<int>> res = new List<List<int>>();
    foreach (var sub in testList) {
        if (res.Count > 0 && res[res.Count - 1][0] == sub.Item1) {
            res[res.Count - 1].AddRange(sub.ToList().GetRange(1, sub.Item2 - 1));
        } else {
            res.Add(new List<int>(sub.ToList()));
        }
    }
    return res.Select(x => Tuple.Create(x.ToArray())).ToList();
}
```

## Test List

```csharp
Debug.Assert(JoinTuples(new (int, int)[] { (5, 6), (5, 7), (6, 8), (6, 10), (7, 13) }).SequenceEqual(new (int, int, int)[] { (5, 6, 7), (6, 8, 10), (7, 13) }));
```

```csharp
Debug.Assert(JoinTuples(new List<Tuple<int, int>>() { Tuple.Create(6, 7), Tuple.Create(6, 8), Tuple.Create(7, 9), Tuple.Create(7, 11), Tuple.Create(8, 14) }).SequenceEqual(new List<Tuple<int, int>>() { Tuple.Create(6, 7, 8), Tuple.Create(7, 9, 11), Tuple.Create(8, 14) }));
```

```csharp
Debug.Assert(JoinTuples(new List<Tuple<int, int>> { Tuple.Create(7, 8), Tuple.Create(7, 9), Tuple.Create(8, 10), Tuple.Create(8, 12), Tuple.Create(9, 15) }).SequenceEqual(new List<Tuple<int, int>> { Tuple.Create(7, 8, 9), Tuple.Create(8, 10, 12), Tuple.Create(9, 15) }));
```
