# mbcp-108 -- Merge sorted inputs into one sorted iterator

## Text

Write a function to merge multiple sorted inputs into a single sorted iterator using heap queue algorithm.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> MergeSortedList(IList<int> num1, IList<int> num2, IList<int> num3)
    {
        num1 = num1.OrderBy(x => x).ToList();
        num2 = num2.OrderBy(x => x).ToList();
        num3 = num3.OrderBy(x => x).ToList();
        var result = num1.Concat(num2).Concat(num3).OrderBy(x => x);
        return result.ToList();
    }
}
```

## Test List

```csharp
Debug.Assert(MergeSortedList(new int[] { 25, 24, 15, 4, 5, 29, 110 }, new int[] { 19, 20, 11, 56, 25, 233, 154 }, new int[] { 24, 26, 54, 48 }) == new int[] { 4, 5, 11, 15, 19, 20, 24, 24, 25, 25, 26, 29, 48, 54, 56, 110, 154, 233 });
```

```csharp
Debug.Assert(MergeSortedList(new List<int> { 1, 3, 5, 6, 8, 9 }, new List<int> { 2, 5, 7, 11 }, new List<int> { 1, 4, 7, 8, 12 }).SequenceEqual(new List<int> { 1, 1, 2, 3, 4, 5, 5, 6, 7, 7, 8, 8, 9, 11, 12 }));
```

```csharp
Debug.Assert(MergeSortedList(new List<int> { 18, 14, 10, 9, 8, 7, 9, 3, 2, 4, 1 }, new List<int> { 25, 35, 22, 85, 14, 65, 75, 25, 58 }, new List<int> { 12, 74, 9, 50, 61, 41 }).SequenceEqual(new List<int> { 1, 2, 3, 4, 7, 8, 9, 9, 9, 10, 12, 14, 14, 18, 22, 25, 25, 35, 41, 50, 58, 61, 65, 74, 75, 85 }));
```
