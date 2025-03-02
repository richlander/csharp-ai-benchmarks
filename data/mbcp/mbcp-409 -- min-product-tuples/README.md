# mbcp-409 -- Find minimum product from tuple pairs in a list

## Text

Write a function to find the minimum product from the pairs of tuples within a given list.

## Code

```csharp
public static int MinProductTuple(List<Tuple<int, int>> list1) {
    int resultMin = list1.Select(tuple => Math.Abs(tuple.Item1 * tuple.Item2)).Min();
    return resultMin;
}
```

## Test List

```csharp
Debug.Assert(MinProductTuple(new (int, int)[] { (2, 7), (2, 6), (1, 8), (4, 9) }) == 8);
```

```csharp
Debug.Assert(MinProductTuple(new Tuple<int, int>[] { Tuple.Create(10, 20), Tuple.Create(15, 2), Tuple.Create(5, 10) }) == 30);
```

```csharp
Debug.Assert(MinProductTuple(new (int, int)[] { (11, 44), (10, 15), (20, 5), (12, 9) }) == 100);
```
