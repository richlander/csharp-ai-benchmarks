# mbcp261 -- Divide numbers in tuples using a custom function

## Text

Write a function to perform mathematical division operation across the given tuples.

## Code

```csharp
public static Tuple<int> DivisionElements(Tuple<int> testTup1, Tuple<int> testTup2)
{
    var res = Tuple.Create(testTup1.Item1 / testTup2.Item1, testTup1.Item2 / testTup2.Item2);
    return res;
}
```

## Test List

```csharp
Debug.Assert(DivisionElements((10, 4, 6, 9), (5, 2, 3, 3)).SequenceEqual((2, 2, 2, 3)));
```

```csharp
Debug.Assert(DivisionElements(new int[] { 12, 6, 8, 16 }, new int[] { 6, 3, 4, 4 }).SequenceEqual(new int[] { 2, 2, 2, 4 }));
```

```csharp
Debug.Assert(DivisionElements(new int[] { 20, 14, 36, 18 }, new int[] { 5, 7, 6, 9 }).SequenceEqual(new int[] { 4, 2, 6, 2 }));
```
