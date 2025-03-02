# mbcp496 -- Find smallest integers using heap queue method

## Text

Write a function to find the smallest integers from a given list of numbers using heap queue algorithm.

## Code

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class HeapQueue
{
    public List<int> HeapQueueSmallest(List<int> nums, int n)
    {
        return nums.OrderBy(x => x).Take(n).ToList();
    }
}
```

## Test List

```csharp
Debug.Assert(HeapQueueSmallest(new int[] { 25, 35, 22, 85, 14, 65, 75, 25, 58 }, 3).SequenceEqual(new int[] { 14, 22, 25 }));
```

```csharp
Debug.Assert(HeapQueueSmallest(new List<int> { 25, 35, 22, 85, 14, 65, 75, 25, 58 }, 2).SequenceEqual(new List<int> { 14, 22 }));
```

```csharp
Debug.Assert(HeapQueueSmallest(new int[] { 25, 35, 22, 85, 14, 65, 75, 22, 58 }, 5).SequenceEqual(new int[] { 14, 22, 22, 25, 35 }));
```
