# mbcp854 -- Convert a list to a heap using the heap queue algorithm

## Text

Write a function which accepts an arbitrary list and converts it to a heap using heap queue algorithm.

## Code

```csharp
using System.Collections.Generic;

public List<int> RawHeap(List<int> rawheap)
{
    Heapify(rawheap);
    return rawheap;
}

private void Heapify(List<int> heap)
{
    int count = heap.Count;
    for (int i = count / 2 - 1; i >= 0; i--)
    {
        SiftDown(heap, i, count);
    }
}

private void SiftDown(List<int> heap, int index, int count)
{
    int childIndex = 2 * index + 1;
    while (childIndex < count)
    {
        int rightIndex = childIndex + 1;
        if (rightIndex < count && heap[rightIndex] < heap[childIndex])
        {
            childIndex = rightIndex;
        }

        if (heap[index] <= heap[childIndex]) 
            break;

        int temp = heap[index];
        heap[index] = heap[childIndex];
        heap[childIndex] = temp;

        index = childIndex;
        childIndex = 2 * index + 1;
    }
}
```

## Test List

```csharp
Debug.Assert(RawHeap(new List<int> { 25, 44, 68, 21, 39, 23, 89 }).SequenceEqual(new List<int> { 21, 25, 23, 44, 39, 68, 89 }));
```

```csharp
Debug.Assert(RawHeap(new int[] { 25, 35, 22, 85, 14, 65, 75, 25, 58 }).SequenceEqual(new int[] { 14, 25, 22, 25, 35, 65, 75, 85, 58 }));
```

```csharp
Debug.Assert(RawHeap(new List<int> { 4, 5, 6, 2 }).SequenceEqual(new List<int> { 2, 4, 6, 5 }));
```
