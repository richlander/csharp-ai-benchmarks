# mbcp-635 -- Heapify values and remove smallest elements sequentially

## Text

Write a function to push all values into a heap and then pop off the smallest values one at a time.

## Code

```csharp
public List<T> HeapSort<T>(IEnumerable<T> iterable) where T : IComparable<T>
{
    var h = new List<T>();
    foreach (var value in iterable)
    {
        h.Add(value);
        h.Sort();
    }
    var result = new List<T>();
    while (h.Count > 0)
    {
        result.Add(h[0]);
        h.RemoveAt(0);
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(HeapSort(new List<int> { 1, 3, 5, 7, 9, 2, 4, 6, 8, 0 }).SequenceEqual(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
```

```csharp
Debug.Assert(HeapSort(new int[] { 25, 35, 22, 85, 14, 65, 75, 25, 58 }).SequenceEqual(new int[] { 14, 22, 25, 25, 35, 58, 65, 75, 85 }));
```

```csharp
Debug.Assert(HeapSort(new int[] { 7, 1, 9, 5 }).SequenceEqual(new int[] { 1, 5, 7, 9 }));
```
