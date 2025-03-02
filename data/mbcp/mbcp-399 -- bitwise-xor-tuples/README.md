# mbcp-399 -- Bitwise xor operation for given tuples

## Text

Write a function to perform the mathematical bitwise xor operation across the given tuples.

## Code

```csharp
public static Tuple<int> BitwiseXor(Tuple<int> testTup1, Tuple<int> testTup2) {
    var res = new int[testTup1.Item1.Length];
    for (int i = 0; i < testTup1.Item1.Length; i++) {
        res[i] = testTup1.Item1[i] ^ testTup2.Item1[i];
    }
    return Tuple.Create(res);
}
```

## Test List

```csharp
Debug.Assert(BitwiseXor(new int[] { 10, 4, 6, 9 }, new int[] { 5, 2, 3, 3 }).SequenceEqual(new int[] { 15, 6, 5, 10 }));
```

```csharp
Debug.Assert(BitwiseXor(new int[] { 11, 5, 7, 10 }, new int[] { 6, 3, 4, 4 }).SequenceEqual(new int[] { 13, 6, 3, 14 }));
```

```csharp
Debug.Assert(BitwiseXor(new int[] { 12, 6, 8, 11 }, new int[] { 7, 4, 5, 6 }).SequenceEqual(new int[] { 11, 2, 13, 13 }));
```
