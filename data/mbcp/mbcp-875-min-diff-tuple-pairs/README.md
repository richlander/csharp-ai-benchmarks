# mbcp875 -- Find minimum difference between tuple pairs

## Text

Write a function to find the minimum difference in the tuple pairs of given tuples.

## Code

```csharp
public static int MinDifference(List<Tuple<int, int>> testList) {
    var temp = testList.Select(t => Math.Abs(t.Item2 - t.Item1)).ToList();
    var res = temp.Min();
    return res;
}
```

## Test List

```csharp
Debug.Assert(MinDifference(new List<Tuple<int, int>> { Tuple.Create(3, 5), Tuple.Create(1, 7), Tuple.Create(10, 3), Tuple.Create(1, 2) }) == 1);
```

```csharp
Debug.Assert(MinDifference(new (int, int)[] { (4, 6), (12, 8), (11, 4), (2, 13) }) == 2);
```

```csharp
Debug.Assert(MinDifference(new Tuple<int, int>[] { Tuple.Create(5, 17), Tuple.Create(3, 9), Tuple.Create(12, 5), Tuple.Create(3, 24) }) == 6);
```
