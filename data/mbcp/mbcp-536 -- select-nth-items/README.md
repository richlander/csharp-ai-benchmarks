# mbcp-536 -- Select the nth items from a given list

## Text

Write a function to select the nth items of a list.

## Code

```csharp
public List<T> NthItems<T>(List<T> list, int n)
{
    List<T> result = new List<T>();
    for (int i = 0; i < list.Count; i += n)
    {
        result.Add(list[i]);
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(NthItems(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2).SequenceEqual(new List<int> { 1, 3, 5, 7, 9 }));
```

```csharp
Debug.Assert(NthItems(new List<int> { 10, 15, 19, 17, 16, 18 }, 3).SequenceEqual(new List<int> { 10, 17 }));
```

```csharp
Debug.Assert(NthItems(new List<int> { 14, 16, 19, 15, 17 }, 4).SequenceEqual(new List<int> { 14, 17 }));
```
