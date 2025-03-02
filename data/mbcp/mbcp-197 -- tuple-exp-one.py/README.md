# mbcp-197 -- Exponentiate two given tuples in a function

## Text

Write a function to perform the exponentiation of the given two tuples.

## Code

```csharp
public static Tuple<int> FindExponentio(Tuple<int> testTup1, Tuple<int> testTup2) {
    var res = testTup1.Zip(testTup2, (ele1, ele2) => (int)Math.Pow(ele1, ele2)).ToArray();
    return Tuple.Create(res);
}
```

## Test List

```csharp
Debug.Assert(FindExponentio(new int[] { 10, 4, 5, 6 }, new int[] { 5, 6, 7, 5 }) == new int[] { 100000, 4096, 78125, 7776 });
```

```csharp
Debug.Assert(FindExponentio(new int[] { 11, 5, 6, 7 }, new int[] { 6, 7, 8, 6 }).SequenceEqual(new int[] { 1771561, 78125, 1679616, 117649 }));
```

```csharp
Debug.Assert(FindExponentio(new[] { 12, 6, 7, 8 }, new[] { 7, 8, 9, 7 }).SequenceEqual(new[] { 35831808, 1679616, 40353607, 2097152 }));
```
