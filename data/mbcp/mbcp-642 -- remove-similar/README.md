# mbcp-642 -- Remove duplicates from a tuple matrix

## Text

Write a function to remove similar rows from the given tuple matrix.

## Code

```csharp
public static HashSet<HashSet<int>> RemoveSimilarRow(List<List<int>> testList)
{
    var res = new HashSet<HashSet<int>>(testList.Select(sub => new HashSet<int>(sub.OrderBy(x => x))).Select(sub => new HashSet<int>(sub))).OrderBy(sub => string.Join(",", sub));
    return res;
}
```

## Test List

```csharp
Debug.Assert(RemoveSimilarRow(new List<List<(int, int)>> { new List<(int, int)> { (4, 5), (3, 2) }, new List<(int, int)> { (2, 2), (4, 6) }, new List<(int, int)> { (3, 2), (4, 5) } }) .SetEquals(new HashSet<(int, int)> { ((2, 2), (4, 6)), ((3, 2), (4, 5)) }));
```

```csharp
Debug.Assert(RemoveSimilarRow(new List<List<(int, int)>> { new List<(int, int)> { (5, 6), (4, 3) }, new List<(int, int)> { (3, 3), (5, 7) }, new List<(int, int)> { (4, 3), (5, 6) } }) == new HashSet<(int, int)> { ((4, 3), (5, 6)), ((3, 3), (5, 7)) });
```

```csharp
Debug.Assert(RemoveSimilarRow(new[] { new[] { (6, 7), (5, 4) }, new[] { (4, 4), (6, 8) }, new[] { (5, 4), (6, 7) } }) .SetEquals(new HashSet<(int, int)> { ((4, 4), (6, 8)), ((5, 4), (6, 7)) }));
```
