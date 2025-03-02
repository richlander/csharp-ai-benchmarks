# mbcp-470 -- Compute pairwise sums of tuple elements

## Text

Write a function to find the pairwise addition of the elements of the given tuples.

## Code

```csharp
public static Tuple<int,int>[] AddPairwise(Tuple<int,int>[] testTup)
{
    var res = testTup.Zip(testTup.Skip(1), (i, j) => new Tuple<int,int>(i.Item1 + j.Item1, i.Item2 + j.Item2)).ToArray();
    return res;
}
```

## Test List

```csharp
Debug.Assert(AddPairwise(new int[] { 1, 5, 7, 8, 10 }).SequenceEqual(new int[] { 6, 12, 15, 18 }));
```

```csharp
Debug.Assert(AddPairwise(new int[] { 2, 6, 8, 9, 11 }).SequenceEqual(new int[] { 8, 14, 17, 20 }));
```

```csharp
Debug.Assert(AddPairwise(new int[] { 3, 7, 9, 10, 12 }).SequenceEqual(new int[] { 10, 16, 19, 22 }));
```
