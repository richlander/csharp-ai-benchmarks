# mbcp-878 -- Check if the tuple has exactly k elements

## Text

Write a function to check if the given tuple contains only k elements.

## Code

```csharp
public bool CheckTuples(Tuple<int, int> testTuple, List<int> K)
{
    bool res = testTuple.Item1 in K && testTuple.Item2 in K;
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckTuples((3, 5, 6, 5, 3, 6), new List<int> { 3, 6, 5 }) == true);
```

```csharp
Debug.Assert(CheckTuples((4, 5, 6, 4, 6, 5), new List<int> { 4, 5, 6 }) == true);
```

```csharp
Debug.Assert(CheckTuples((9, 8, 7, 6, 8, 9), new List<int> { 9, 8, 1 }) == false);
```
