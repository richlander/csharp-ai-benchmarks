# mbcp-237 -- Check similar occurrences in given tuples

## Text

Write a function to check the occurrences of records which occur similar times in the given tuples.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public Dictionary<string, int> CheckOccurrences(List<List<string>> testList)
{
    var res = testList.Select(ele => string.Join(",", ele.OrderBy(x => x)))
                      .GroupBy(x => x)
                      .ToDictionary(g => g.Key, g => g.Count());
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckOccurrences(new List<(int, int)> { (3, 1), (1, 3), (2, 5), (5, 2), (6, 3) }) .SequenceEqual(new Dictionary<(int, int), int> { {(1, 3), 2}, {(2, 5), 2}, {(3, 6), 1} }));
```

```csharp
Debug.Assert(CheckOccurrences(new List<Tuple<int, int>> { Tuple.Create(4, 2), Tuple.Create(2, 4), Tuple.Create(3, 6), Tuple.Create(6, 3), Tuple.Create(7, 4) }) 
    .SequenceEqual(new Dictionary<Tuple<int, int>, int> { { Tuple.Create(2, 4), 2 }, { Tuple.Create(3, 6), 2 }, { Tuple.Create(4, 7), 1 } }));
```

```csharp
Debug.Assert(CheckOccurrences(new (int, int)[] { (13, 2), (11, 23), (12, 25), (25, 12), (16, 23) }) == new Dictionary<(int, int), int> { { (2, 13), 1 }, { (11, 23), 1 }, { (12, 25), 2 }, { (16, 23), 1 } });
```
