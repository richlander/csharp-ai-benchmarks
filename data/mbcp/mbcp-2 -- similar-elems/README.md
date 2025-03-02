# mbcp-2 -- Find similar elements in two tuple lists

## Text

Write a function to find the similar elements from the given two tuple lists.

## Code

```csharp
public static Tuple<T> SimilarElements<T>(Tuple<T> testTup1, Tuple<T> testTup2) {
    var res = testTup1.Item1.Where(x => testTup2.Item1.Contains(x)).Distinct().ToArray();
    return Tuple.Create(res);
}
```

## Test List

```csharp
Debug.Assert(SimilarElements(new int[] { 3, 4, 5, 6 }, new int[] { 5, 7, 4, 10 }).SequenceEqual(new int[] { 4, 5 }));
```

```csharp
Debug.Assert(SimilarElements(new int[] { 1, 2, 3, 4 }, new int[] { 5, 4, 3, 7 }).SequenceEqual(new int[] { 3, 4 }));
```

```csharp
Debug.Assert(SimilarElements(new Tuple<int, int, int, int>(11, 12, 14, 13), new Tuple<int, int, int, int>(17, 15, 14, 13)).SequenceEqual(new List<int> { 13, 14 }));
```
