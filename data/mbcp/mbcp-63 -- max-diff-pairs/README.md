# mbcp-63 -- Find max difference in tuple pairs

## Text

Write a function to find the maximum difference between available pairs in the given tuple list.

## Code

```csharp
public static int MaxDifference(List<Tuple<int, int>> testList)
{
    var temp = testList.Select(pair => Math.Abs(pair.Item2 - pair.Item1)).ToList();
    int res = temp.Max();
    return res;
}
```

## Test List

```csharp
Debug.Assert(MaxDifference(new List<(int, int)> { (3, 5), (1, 7), (10, 3), (1, 2) }) == 7);
```

```csharp
Debug.Assert(MaxDifference(new Tuple<int, int>[] { Tuple.Create(4, 6), Tuple.Create(2, 17), Tuple.Create(9, 13), Tuple.Create(11, 12) }) == 15);
```

```csharp
Debug.Assert(MaxDifference(new List<Tuple<int, int>> { Tuple.Create(12, 35), Tuple.Create(21, 27), Tuple.Create(13, 23), Tuple.Create(41, 22) }) == 23);
```
