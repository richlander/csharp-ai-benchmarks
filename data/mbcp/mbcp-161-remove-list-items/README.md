# mbcp161 -- Remove elements from one list found in another

## Text

Write a function to remove all elements from a given list present in another list.

## Code

```csharp
public List<int> RemoveElements(List<int> list1, List<int> list2) {
    List<int> result = list1.Where(x => !list2.Contains(x)).ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(RemoveElements(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new List<int> { 2, 4, 6, 8 }).SequenceEqual(new List<int> { 1, 3, 5, 7, 9, 10 }));
```

```csharp
Debug.Assert(RemoveElements(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new List<int> { 1, 3, 5, 7 }).SequenceEqual(new List<int> { 2, 4, 6, 8, 9, 10 }));
```

```csharp
Debug.Assert(RemoveElements(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new List<int> { 5, 7 }).SequenceEqual(new List<int> { 1, 2, 3, 4, 6, 8, 9, 10 }));
```
