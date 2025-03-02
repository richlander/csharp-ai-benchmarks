# mbcp972 -- Concatenate two tuples into a nested tuple structure

## Text

Write a function to concatenate the given two tuples to a nested tuple.

## Code

```csharp
public Tuple<string, string> ConcatenateNested(Tuple<string, string> testTup1, Tuple<string, string> testTup2) 
{
    var res = Tuple.Create(testTup1.Item1 + testTup2.Item1, testTup1.Item2 + testTup2.Item2);
    return res;
}
```

## Test List

```csharp
Debug.Assert(ConcatenateNested((3, 4), (5, 6)).SequenceEqual(new Tuple<int, int, int, int>(3, 4, 5, 6)));
```

```csharp
Debug.Assert(ConcatenateNested(new Tuple<int, int>(1, 2), new Tuple<int, int>(3, 4)).SequenceEqual(new Tuple<int, int>(1, 2, 3, 4)));
```

```csharp
Debug.Assert(ConcatenateNested((4, 5), (6, 8)).SequenceEqual(new int[] { 4, 5, 6, 8 }));
```
