# mbcp-40 -- Count element frequency in a list of lists

## Text

Write a function to find frequency of the elements in a given list of lists using collections module.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class Example
{
    public Dictionary<int, int> FreqElement(IEnumerable<IEnumerable<int>> nums)
    {
        var result = nums.SelectMany(x => x)
                         .GroupBy(x => x)
                         .ToDictionary(g => g.Key, g => g.Count());
        return result;
    }
}
```

## Test List

```csharp
var result = FreqElement(new int[][] { new int[] { 1, 2, 3, 2 }, new int[] { 4, 5, 6, 2 }, new int[] { 7, 1, 9, 5 } });
var expected = new Dictionary<int, int> { { 2, 3 }, { 1, 2 }, { 5, 2 }, { 3, 1 }, { 4, 1 }, { 6, 1 }, { 7, 1 }, { 9, 1 } };
Debug.Assert(result.SequenceEqual(expected));
```

```csharp
Debug.Assert(freq_element(new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } }).SequenceEqual(new Dictionary<int, int> { { 1, 1 }, { 2, 1 }, { 3, 1 }, { 4, 1 }, { 5, 1 }, { 6, 1 }, { 7, 1 }, { 8, 1 }, { 9, 1 }, { 10, 1 }, { 11, 1 }, { 12, 1 } }));
```

```csharp
Debug.Assert(FreqElement(new int[][] { new int[] { 15, 20, 30, 40 }, new int[] { 80, 90, 100, 110 }, new int[] { 30, 30, 80, 90 } })
    .SequenceEqual(new Dictionary<int, int> { { 30, 3 }, { 80, 2 }, { 90, 2 }, { 15, 1 }, { 20, 1 }, { 40, 1 }, { 100, 1 }, { 110, 1 } }));
```
