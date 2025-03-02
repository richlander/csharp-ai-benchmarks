# mbcp578 -- Interleave two lists of equal length into one

## Text

Write a function to interleave lists of the same length.

## Code

```csharp
public List<T> InterleaveLists<T>(List<T> list1, List<T> list2, List<T> list3)
{
    var result = new List<T>();
    var count = Math.Min(Math.Min(list1.Count, list2.Count), list3.Count);

    for (int i = 0; i < count; i++)
    {
        result.Add(list1[i]);
        result.Add(list2[i]);
        result.Add(list3[i]);
    }
    
    return result;
}
```

## Test List

```csharp
Debug.Assert(InterleaveLists(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 10, 20, 30, 40, 50, 60, 70 }, new int[] { 100, 200, 300, 400, 500, 600, 700 }).SequenceEqual(new int[] { 1, 10, 100, 2, 20, 200, 3, 30, 300, 4, 40, 400, 5, 50, 500, 6, 60, 600, 7, 70, 700 }));
```

```csharp
Debug.Assert(InterleaveLists(new List<int> { 10, 20 }, new List<int> { 15, 2 }, new List<int> { 5, 10 }).SequenceEqual(new List<int> { 10, 15, 5, 20, 2, 10 }));
```

```csharp
Debug.Assert(InterleaveLists(new List<int> { 11, 44 }, new List<int> { 10, 15 }, new List<int> { 20, 5 }).SequenceEqual(new List<int> { 11, 10, 20, 44, 15, 5 }));
```
