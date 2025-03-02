# mbcp-372 -- Sort elements in ascending order using heap queue

## Text

Write a function to sort a given list of elements in ascending order using heap queue algorithm.

## Code

```csharp
using System.Collections.Generic;

public List<int> HeapAssending(List<int> nums)
{
    // Create a min-heap
    PriorityQueue<int, int> minHeap = new();
    foreach (var num in nums)
    {
        minHeap.Enqueue(num, num);
    }

    List<int> sResult = new();
    while (minHeap.Count > 0)
    {
        sResult.Add(minHeap.Dequeue());
    }
    return sResult;
}
```

## Test List

```csharp
Debug.Assert(HeapAssending(new int[] { 18, 14, 10, 9, 8, 7, 9, 3, 2, 4, 1 }).SequenceEqual(new int[] { 1, 2, 3, 4, 7, 8, 9, 9, 10, 14, 18 }));
```

```csharp
Debug.Assert(HeapAssending(new List<int> { 25, 35, 22, 85, 14, 65, 75, 25, 58 }).SequenceEqual(new List<int> { 14, 22, 25, 25, 35, 58, 65, 75, 85 }));
```

```csharp
Debug.Assert(HeapAssending(new List<int> { 1, 3, 5, 7, 9, 2, 4, 6, 8, 0 }).SequenceEqual(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
```
