# mbcp-805 -- Find the list with the highest sum in a list of lists

## Text

Write a function to find the list in a list of lists whose sum of elements is the highest.

## Code

```csharp
public List<int> MaxSumList(List<List<int>> lists)
{
    return lists.OrderByDescending(list => list.Sum()).First();
}
```

## Test List

```csharp
Debug.Assert(MaxSumList(new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 10, 11, 12 }, new List<int> { 7, 8, 9 } }).SequenceEqual(new List<int> { 10, 11, 12 }));
```

```csharp
Debug.Assert(MaxSumList(new List<List<int>> { new List<int> { 3, 2, 1 }, new List<int> { 6, 5, 4 }, new List<int> { 12, 11, 10 } }).SequenceEqual(new List<int> { 12, 11, 10 }));
```

```csharp
Debug.Assert(MaxSumList(new List<List<int>> { new List<int> { 2, 3, 1 } }).SequenceEqual(new List<int> { 2, 3, 1 }));
```
