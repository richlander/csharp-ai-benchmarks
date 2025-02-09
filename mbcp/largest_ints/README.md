# 4 -- Find largest integers from list

largest_ints

## Prompt

Write a function to find the largest integers from a given list of numbers using heap queue algorithm.

## Solution

```csharp
using System;
using System.Linq;
using System.Diagnostics;

int[] HeapQueueLargest(int[] nums, int n)
{
    return nums.OrderByDescending(x => x).Take(n).ToArray();
}
```

## Tests

```csharp
Debug.Assert(HeapQueueLargest(new int[]{25,35,22,85,14,65,75,22,58}, 3).SequenceEqual(new int[]{85,75,65}));
```

```csharp
Debug.Assert(HeapQueueLargest(new int[]{25,35,22,85,14,65,75,22,58}, 2).SequenceEqual(new int[]{85,75}));
```

```csharp
Debug.Assert(HeapQueueLargest(new int[]{25,35,22,85,14,65,75,22,58}, 5).SequenceEqual(new int[]{85,75,65,58,35}));
```
