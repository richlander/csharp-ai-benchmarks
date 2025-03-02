# mbcp691 -- Group first elements by corresponding second elements

## Text

Write a function to group the 1st elements on the basis of 2nd elements in the given tuple list.

## Code

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static Dictionary<int, List<int>> GroupElement(List<Tuple<int, int>> testList)
    {
        var res = new Dictionary<int, List<int>>();
        foreach (var group in testList.OrderBy(ele => ele.Item2).GroupBy(ele => ele.Item2))
        {
            res[group.Key] = group.Select(ele => ele.Item1).ToList();
        }
        return res;
    }
}
```

## Test List

```csharp
Debug.Assert(GroupElement(new List<(int, int)> { (6, 5), (2, 7), (2, 5), (8, 7), (9, 8), (3, 7) }) .SequenceEqual(new Dictionary<int, List<int>> { { 5, new List<int> { 6, 2 } }, { 7, new List<int> { 2, 8, 3 } }, { 8, new List<int> { 9 } } }));
```

```csharp
Debug.Assert(GroupElement(new List<(int, int)> { (7, 6), (3, 8), (3, 6), (9, 8), (10, 9), (4, 8) }).SequenceEqual(new Dictionary<int, List<int>> { { 6, new List<int> { 7, 3 } }, { 8, new List<int> { 3, 9, 4 } }, { 9, new List<int> { 10 } } }));
```

```csharp
Debug.Assert(GroupElement(new List<(int, int)>{(8, 7), (4, 9), (4, 7), (10, 9), (11, 10), (5, 9)}) == new Dictionary<int, List<int>>{{7, new List<int>{8, 4}}, {9, new List<int>{4, 10, 5}}, {10, new List<int>{11}}});
```
