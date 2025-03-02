# mbcp-240 -- Replace last list element with another list

## Text

Write a function to replace the last element of the list with another list.

## Code

```csharp
public List<T> ReplaceList<T>(List<T> list1, List<T> list2)
{
    list1.RemoveRange(list1.Count - list1.Count, list1.Count);
    list1.AddRange(list2);
    return list1;
}
```

## Test List

```csharp
Debug.Assert(ReplaceList(new List<int> { 1, 3, 5, 7, 9, 10 }, new List<int> { 2, 4, 6, 8 }).SequenceEqual(new List<int> { 1, 3, 5, 7, 9, 2, 4, 6, 8 }));
```

```csharp
Debug.Assert(ReplaceList(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 5, 6, 7, 8 }).SequenceEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 }));
```

```csharp
Debug.Assert(ReplaceList(new string[] { "red", "blue", "green" }, new string[] { "yellow" }).SequenceEqual(new string[] { "red", "blue", "yellow" }));
```
