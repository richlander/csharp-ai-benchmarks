# mbcp-259 -- Maximize values from two given tuples with a function

## Text

Write a function to maximize the given two tuples.

## Code

```csharp
public static ValueTuple<int[]> MaximizeElements(ValueTuple<int[]> testTup1, ValueTuple<int[]> testTup2)
{
    var res = testTup1.Item1.Zip(testTup2.Item1, (a, b) => Math.Max(a, b)).ToArray();
    return (res);
}
```

## Test List

```csharp
Debug.Assert(MaximizeElements(new (int, int)[] { (1, 3), (4, 5), (2, 9), (1, 10) }, new (int, int)[] { (6, 7), (3, 9), (1, 1), (7, 3) }).SequenceEqual(new (int, int)[] { (6, 7), (4, 9), (2, 9), (7, 10) }));
```

```csharp
Debug.Assert(MaximizeElements(new (int, int)[] { (2, 4), (5, 6), (3, 10), (2, 11) }, new (int, int)[] { (7, 8), (4, 10), (2, 2), (8, 4) }).SequenceEqual(new (int, int)[] { (7, 8), (5, 10), (3, 10), (8, 11) }));
```

```csharp
Debug.Assert(MaximizeElements(new (int, int)[] { (3, 5), (6, 7), (4, 11), (3, 12) }, new (int, int)[] { (8, 9), (5, 11), (3, 3), (9, 5) }) == new (int, int)[] { (8, 9), (6, 11), (4, 11), (9, 12) });
```
