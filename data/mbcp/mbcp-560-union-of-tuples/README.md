# mbcp560 -- Find union of elements in given tuples

## Text

Write a function to find the union of elements of the given tuples.

## Code

```csharp
public static Tuple<int> UnionElements(Tuple<int> testTup1, Tuple<int> testTup2)
{
    var res = new HashSet<int>(testTup1.Concat(testTup2));
    return Tuple.Create(res.ToArray());
}
```

## Test List

```csharp
Debug.Assert(UnionElements(new int[] { 3, 4, 5, 6 }, new int[] { 5, 7, 4, 10 }).SequenceEqual(new int[] { 3, 4, 5, 6, 7, 10 }));
```

```csharp
Debug.Assert(UnionElements(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 5, 6 }).SequenceEqual(new int[] { 1, 2, 3, 4, 5, 6 }));
```

```csharp
Debug.Assert(UnionElements(new int[] { 11, 12, 13, 14 }, new int[] { 13, 15, 16, 17 }).SequenceEqual(new int[] { 11, 12, 13, 14, 15, 16, 17 }));
```
