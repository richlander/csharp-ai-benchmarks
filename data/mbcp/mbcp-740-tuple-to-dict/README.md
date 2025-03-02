# mbcp740 -- Convert tuple to key-value dictionary from pairs

## Text

Write a function to convert the given tuple to a key-value dictionary using adjacent elements.

## Code

```csharp
public Dictionary<T, U> TupleToDict<T, U>(Tuple<T, U> testTup)
{
    var res = new Dictionary<T, U>();
    for (int idx = 0; idx < testTup.Length; idx += 2)
    {
        res[testTup[idx]] = testTup[idx + 1];
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(TupleToDict(new Tuple<int, int, int, int, int, int>(1, 5, 7, 10, 13, 5)).SequenceEqual(new Dictionary<int, int> { { 1, 5 }, { 7, 10 }, { 13, 5 } }));
```

```csharp
Debug.Assert(TupleToDict(new int[] { 1, 2, 3, 4, 5, 6 }).SequenceEqual(new Dictionary<int, int> { { 1, 2 }, { 3, 4 }, { 5, 6 } }));
```

```csharp
Debug.Assert(TupleToDict((7, 8, 9, 10, 11, 12)).SequenceEqual(new Dictionary<int, int> { { 7, 8 }, { 9, 10 }, { 11, 12 } }));
```
