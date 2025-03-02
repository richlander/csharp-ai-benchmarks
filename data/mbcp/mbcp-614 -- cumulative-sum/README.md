# mbcp-614 -- Calculate cumulative sum from a list of tuples

## Text

Write a function to find the cumulative sum of all the values that are present in the given tuple list.

## Code

```csharp
public int CummulativeSum(List<List<int>> testList) 
{
    int res = testList.Sum(innerList => innerList.Sum());
    return res;
}
```

## Test List

```csharp
Debug.Assert(CummulativeSum(new List<Tuple<int, int>> { Tuple.Create(1, 3), Tuple.Create(5, 6, 7), Tuple.Create(2, 6) }) == 30);
```

```csharp
Debug.Assert(CummulativeSum(new List<Tuple<int>> { Tuple.Create(2, 4), Tuple.Create(6, 7, 8), Tuple.Create(3, 7) }) == 37);
```

```csharp
Debug.Assert(CummulativeSum(new List<Tuple<int>> { Tuple.Create(3, 5), Tuple.Create(7, 8, 9), Tuple.Create(4, 8) }) == 44);
```
