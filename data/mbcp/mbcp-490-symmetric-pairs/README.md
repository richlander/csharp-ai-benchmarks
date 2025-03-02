# mbcp490 -- Extract symmetric pairs from a list of tuples

## Text

Write a function to extract all the pairs which are symmetric in the given tuple list.

## Code

```csharp
public static HashSet<(int, int)> ExtractSymmetric(List<(int, int)> testList) 
{
    var temp = new HashSet<(int, int)>(testList);
    temp.IntersectWith(testList.Select(x => (x.Item2, x.Item1)));
    var res = new HashSet<(int, int)>(temp.Where(x => x.Item1 < x.Item2));
    return res;
}
```

## Test List

```csharp
Debug.Assert(ExtractSymmetric(new (int, int)[] { (6, 7), (2, 3), (7, 6), (9, 8), (10, 2), (8, 9) }).SetEquals(new HashSet<(int, int)> { (8, 9), (6, 7) }));
```

```csharp
Debug.Assert(ExtractSymmetric(new List<(int, int)>{(7, 8), (3, 4), (8, 7), (10, 9), (11, 3), (9, 10)}) .SetEquals(new HashSet<(int, int)>{(9, 10), (7, 8)}));
```

```csharp
Debug.Assert(ExtractSymmetric(new List<(int, int)>{(8, 9), (4, 5), (9, 8), (11, 10), (12, 4), (10, 11)}) .SetEquals(new HashSet<(int, int)>{(8, 9), (10, 11)}));
```
