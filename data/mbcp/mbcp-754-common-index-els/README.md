# mbcp754 -- Find common index elements in three lists

## Text

Write a function to find common index elements from three lists.

## Code

```csharp
public List<T> ExtractIndexList<T>(List<T> l1, List<T> l2, List<T> l3)
{
    List<T> result = new List<T>();
    for (int i = 0; i < l1.Count; i++)
    {
        T m = l1[i];
        T n = l2[i];
        T o = l3[i];
        if (EqualityComparer<T>.Default.Equals(m, n) && EqualityComparer<T>.Default.Equals(n, o))
        {
            result.Add(m);
        }
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(ExtractIndexList(new List<int> { 1, 1, 3, 4, 5, 6, 7 }, new List<int> { 0, 1, 2, 3, 4, 5, 7 }, new List<int> { 0, 1, 2, 3, 4, 5, 7 }).SequenceEqual(new List<int> { 1, 7 }));
```

```csharp
Debug.Assert(ExtractIndexList(new List<int> { 1, 1, 3, 4, 5, 6, 7 }, new List<int> { 0, 1, 2, 3, 4, 6, 5 }, new List<int> { 0, 1, 2, 3, 4, 6, 7 }).SequenceEqual(new List<int> { 1, 6 }));
```

```csharp
Debug.Assert(ExtractIndexList(new List<int> { 1, 1, 3, 4, 6, 5, 6 }, new List<int> { 0, 1, 2, 3, 4, 5, 7 }, new List<int> { 0, 1, 2, 3, 4, 5, 7 }).SequenceEqual(new List<int> { 1, 5 }));
```
