# mbcp-81 -- Zip two given tuples into a single tuple

## Text

Write a function to zip the two given tuples.

## Code

```csharp
List<Tuple<T, T>> ZipTuples<T>(Tuple<T>[] testTup1, Tuple<T>[] testTup2) 
{
    List<Tuple<T, T>> res = new List<Tuple<T, T>>();
    for (int i = 0; i < testTup1.Length; i++) 
    {
        res.Add(Tuple.Create(testTup1[i], testTup2[i % testTup2.Length]));
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(ZipTuples(new int[] { 7, 8, 4, 5, 9, 10 }, new int[] { 1, 5, 6 }).SequenceEqual(new List<Tuple<int, int>> { Tuple.Create(7, 1), Tuple.Create(8, 5), Tuple.Create(4, 6), Tuple.Create(5, 1), Tuple.Create(9, 5), Tuple.Create(10, 6) }));
```

```csharp
Debug.Assert(ZipTuples(new int[] { 8, 9, 5, 6, 10, 11 }, new int[] { 2, 6, 7 }).SequenceEqual(new List<Tuple<int, int>> { Tuple.Create(8, 2), Tuple.Create(9, 6), Tuple.Create(5, 7), Tuple.Create(6, 2), Tuple.Create(10, 6), Tuple.Create(11, 7) }));
```

```csharp
Debug.Assert(ZipTuples((9, 10, 6, 7, 11, 12), (3, 7, 8)).SequenceEqual(new List<Tuple<int, int>> { Tuple.Create(9, 3), Tuple.Create(10, 7), Tuple.Create(6, 8), Tuple.Create(7, 3), Tuple.Create(11, 7), Tuple.Create(12, 8) }));
```
