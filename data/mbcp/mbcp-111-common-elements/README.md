# mbcp111 -- Find common elements in nested lists

## Text

Write a function to find common elements in given nested lists. * list item * list item * list item * list item

## Code

```csharp
public List<T> CommonInNestedLists<T>(List<List<T>> nestedList)
{
    var sets = nestedList.Select(list => new HashSet<T>(list));
    var intersection = sets.Aggregate((hashSet1, hashSet2) =>
    {
        hashSet1.IntersectWith(hashSet2);
        return hashSet1;
    });
    return intersection.ToList();
}
```

## Test List

```csharp
Debug.Assert(CommonInNestedLists(new List<List<int>> { new List<int> { 12, 18, 23, 25, 45 }, new List<int> { 7, 12, 18, 24, 28 }, new List<int> { 1, 5, 8, 12, 15, 16, 18 } }) .SequenceEqual(new List<int> { 18, 12 }));
```

```csharp
Debug.Assert(CommonInNestedLists(new List<List<int>> { new List<int> { 12, 5, 23, 25, 45 }, new List<int> { 7, 11, 5, 23, 28 }, new List<int> { 1, 5, 8, 18, 23, 16 } }) .SequenceEqual(new List<int> { 5, 23 }));
```

```csharp
Debug.Assert(CommonInNestedLists(new List<List<int>> { new List<int> { 2, 3, 4, 1 }, new List<int> { 4, 5 }, new List<int> { 6, 4, 8 }, new List<int> { 4, 5 }, new List<int> { 6, 8, 4 } }).SequenceEqual(new List<int> { 4 }));
```
