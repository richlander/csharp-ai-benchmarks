# mbcp-889 -- Reverse lists in a given list of lists

## Text

Write a function to reverse each list in a given list of lists.

## Code

```csharp
public List<List<int>> ReverseListLists(List<List<int>> lists) 
{
    foreach (var l in lists) 
    {
        l.Sort((a, b) => b.CompareTo(a));
    }
    return lists;
}
```

## Test List

```csharp
Debug.Assert(ReverseListLists(new List<List<int>> { new List<int> { 1, 2, 3, 4 }, new List<int> { 5, 6, 7, 8 }, new List<int> { 9, 10, 11, 12 }, new List<int> { 13, 14, 15, 16 } }) == new List<List<int>> { new List<int> { 4, 3, 2, 1 }, new List<int> { 8, 7, 6, 5 }, new List<int> { 12, 11, 10, 9 }, new List<int> { 16, 15, 14, 13 } });
```

```csharp
Debug.Assert(ReverseListLists(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 } }) == new List<List<int>> { new List<int> { 2, 1 }, new List<int> { 3, 2 }, new List<int> { 4, 3 } });
```

```csharp
Debug.Assert(ReverseListLists(new List<List<int>> { new List<int> { 10, 20 }, new List<int> { 30, 40 } }).SequenceEqual(new List<List<int>> { new List<int> { 20, 10 }, new List<int> { 40, 30 } }));
```
