# mbcp209 -- Delete smallest heap element and insert new item

## Text

Write a function to delete the smallest element from the given heap and then insert a new item.

## Code

```csharp
using System.Collections.Generic;

public List<int> HeapReplace(List<int> heap, int a)
{
    Heapify(heap);
    heap[0] = a;
    Heapify(heap);
    return heap;
}

private void Heapify(List<int> heap)
{
    int n = heap.Count;
    for (int i = n / 2 - 1; i >= 0; i--)
    {
        SiftDown(heap, i, n);
    }
}

private void SiftDown(List<int> heap, int i, int n)
{
    int smallest = i;
    int left = 2 * i + 1;
    int right = 2 * i + 2;

    if (left < n && heap[left] < heap[smallest])
    {
        smallest = left;
    }

    if (right < n && heap[right] < heap[smallest])
    {
        smallest = right;
    }

    if (smallest != i)
    {
        int temp = heap[i];
        heap[i] = heap[smallest];
        heap[smallest] = temp;
        SiftDown(heap, smallest, n);
    }
}
```

## Test List

```csharp
Debug.Assert(HeapReplace(new List<int> { 25, 44, 68, 21, 39, 23, 89 }, 21).SequenceEqual(new List<int> { 21, 25, 23, 44, 39, 68, 89 }));
```

```csharp
Debug.Assert(HeapReplace(new List<int> { 25, 44, 68, 21, 39, 23, 89 }, 110).SequenceEqual(new List<int> { 23, 25, 68, 44, 39, 110, 89 }));
```

```csharp
Debug.Assert(HeapReplace(new List<int> { 25, 44, 68, 21, 39, 23, 89 }, 500).SequenceEqual(new List<int> { 23, 25, 68, 44, 39, 500, 89 }));
```
