# mbcp888 -- Subtract elements of nested tuples in a function

## Text

Write a function to substract the elements of the given nested tuples.

## Code

```csharp
public Tuple<Tuple<int, int>[]> SubstractElements(Tuple<int, int>[] testTup1, Tuple<int, int>[] testTup2)
{
    var res = testTup1.Zip(testTup2, (tup1, tup2) => 
        Tuple.Create(tup1.Item1 - tup2.Item1, tup1.Item2 - tup2.Item2)).ToArray();
    return Tuple.Create(res);
}
```

## Test List

```csharp
Debug.Assert(SubstractElements(new int[,] { { 1, 3 }, { 4, 5 }, { 2, 9 }, { 1, 10 } }, new int[,] { { 6, 7 }, { 3, 9 }, { 1, 1 }, { 7, 3 } }) == new int[,] { { -5, -4 }, { 1, -4 }, { 1, 8 }, { -6, 7 } });
```

```csharp
Debug.Assert(SubstractElements(new (int, int)[] { (13, 4), (14, 6), (13, 10), (12, 11) }, new (int, int)[] { (19, 8), (14, 10), (12, 2), (18, 4) }) == new (int, int)[] { (-6, -4), (0, -4), (1, 8), (-6, 7) });
```

```csharp
Debug.Assert(SubstractElements(new (int, int)[] { (19, 5), (18, 7), (19, 11), (17, 12) }, new (int, int)[] { (12, 9), (17, 11), (13, 3), (19, 5) }).SequenceEqual(new (int, int)[] { (7, -4), (1, -4), (6, 8), (-2, 7) }));
```
