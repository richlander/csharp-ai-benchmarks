# mbcp114 -- Assign frequency to tuples in a given list

## Text

Write a function to assign frequency to each tuple in the given tuple list.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static string AssignFreq(List<int> testList)
    {
        var res = testList.GroupBy(x => x)
                          .Select(g => (g.Key, g.Count()))
                          .ToList();
        return res.ToString();
    }
}
```

## Test List

```csharp
Debug.Assert(AssignFreq(new List<Tuple<int, int, int>> { Tuple.Create(6, 5, 8), Tuple.Create(2, 7), Tuple.Create(6, 5, 8), Tuple.Create(6, 5, 8), Tuple.Create(9), Tuple.Create(2, 7) }) == "[(6, 5, 8, 3), (2, 7, 2), (9, 1)]");
```

```csharp
Debug.Assert(AssignFreq(new List<Tuple<int, int>> { Tuple.Create(4, 2, 4), Tuple.Create(7, 1), Tuple.Create(4, 8), Tuple.Create(4, 2, 4), Tuple.Create(9, 2), Tuple.Create(7, 1) }) == "[(4, 2, 4, 2), (7, 1, 2), (4, 8, 1), (9, 2, 1)]");
```

```csharp
Debug.Assert(AssignFreq(new List<(int, int, int)> { (11, 13, 10), (17, 21), (4, 2, 3), (17, 21), (9, 2), (4, 2, 3) }) == "[(11, 13, 10, 1), (17, 21, 2), (4, 2, 3, 2), (9, 2, 1)]");
```
