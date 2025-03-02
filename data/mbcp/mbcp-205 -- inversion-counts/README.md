# mbcp-205 -- Find inversions in a list of tuples elements

## Text

Write a function to find the inversions of tuple elements in the given tuple list.

## Code

```csharp
public Tuple<int> InversionElements(Tuple<int> testTup) {
    var res = Tuple.Create(testTup.Item1, ~testTup.Item1, testTup.Item2, ~testTup.Item2, testTup.Item3, ~testTup.Item3);
    return res;
}
```

## Test List

```csharp
Debug.Assert(InversionElements(new int[] { 7, 8, 9, 1, 10, 7 }).SequenceEqual(new int[] { -8, -9, -10, -2, -11, -8 }));
```

```csharp
Debug.Assert(InversionElements(new int[] { 2, 4, 5, 6, 1, 7 }).SequenceEqual(new int[] { -3, -5, -6, -7, -2, -8 }));
```

```csharp
Debug.Assert(InversionElements(new int[] { 8, 9, 11, 14, 12, 13 }).SequenceEqual(new int[] { -9, -10, -12, -15, -13, -14 }));
```
