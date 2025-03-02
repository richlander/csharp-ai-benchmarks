# mbcp-869 -- Remove sublists outside a specified range

## Text

Write a function to remove sublists from a given list of lists, which are outside a given range.

## Code

```csharp
public List<List<T>> RemoveListRange<T>(List<List<T>> list1, double leftrange, double rigthrange) where T : IComparable<T>
{
    var result = list1.Where(i => i.Min().CompareTo(leftrange) >= 0 && i.Max().CompareTo(rigthrange) <= 0).ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(RemoveListRange(new List<List<int>> { new List<int> { 2 }, new List<int> { 0 }, new List<int> { 1, 2, 3 }, new List<int> { 0, 1, 2, 3, 6, 7 }, new List<int> { 9, 11 }, new List<int> { 13, 14, 15, 17 } }, 13, 17).SequenceEqual(new List<List<int>> { new List<int> { 13, 14, 15, 17 } }));
```

```csharp
Debug.Assert(RemoveListRange(new List<List<int>> { new List<int> { 2 }, new List<int> { 0 }, new List<int> { 1, 2, 3 }, new List<int> { 0, 1, 2, 3, 6, 7 }, new List<int> { 9, 11 }, new List<int> { 13, 14, 15, 17 } }, 1, 3).SequenceEqual(new List<List<int>> { new List<int> { 2 }, new List<int> { 1, 2, 3 } }));
```

```csharp
Debug.Assert(RemoveListRange(new List<List<int>> { new List<int> { 2 }, new List<int> { 0 }, new List<int> { 1, 2, 3 }, new List<int> { 0, 1, 2, 3, 6, 7 }, new List<int> { 9, 11 }, new List<int> { 13, 14, 15, 17 } }, 0, 7).SequenceEqual(new List<List<int>> { new List<int> { 2 }, new List<int> { 0 }, new List<int> { 1, 2, 3 }, new List<int> { 0, 1, 2, 3, 6, 7 } }));
```
