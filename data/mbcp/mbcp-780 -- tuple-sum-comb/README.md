# mbcp-780 -- Find combinations of sums from tuple lists

## Text

Write a function to find the combinations of sums with tuples in the given tuple list.

## Code

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class CombinationFinder
{
    public List<(int, int)> FindCombinations(List<(int, int)> testList)
    {
        var res = new List<(int, int)>();
        var combinations = testList.SelectMany((a, i) => testList.Skip(i + 1), (a, b) => (a, b));
        foreach (var (a, b) in combinations)
        {
            res.Add((b.Item1 + a.Item1, b.Item2 + a.Item2));
        }
        return res;
    }
}
```

## Test List

```csharp
Debug.Assert(FindCombinations(new (int, int)[] { (2, 4), (6, 7), (5, 1), (6, 10) }).SequenceEqual(new (int, int)[] { (8, 11), (7, 5), (8, 14), (11, 8), (12, 17), (11, 11) }));
```

```csharp
Debug.Assert(FindCombinations(new[] { (3, 5), (7, 8), (6, 2), (7, 11) }).SequenceEqual(new[] { (10, 13), (9, 7), (10, 16), (13, 10), (14, 19), (13, 13) }));
```

```csharp
Debug.Assert(FindCombinations(new (int, int)[] { (4, 6), (8, 9), (7, 3), (8, 12) }).SequenceEqual(new (int, int)[] { (12, 15), (11, 9), (12, 18), (15, 12), (16, 21), (15, 15) }));
```
