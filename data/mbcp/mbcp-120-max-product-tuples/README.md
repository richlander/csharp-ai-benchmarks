# mbcp120 -- Find max product of tuple pairs in a list

## Text

Write a function to find the maximum product from the pairs of tuples within a given list.

## Code

```csharp
public static int MaxProductTuple(List<Tuple<int, int>> list1)
{
    int resultMax = list1.Select(tuple => Math.Abs(tuple.Item1 * tuple.Item2)).Max();
    return resultMax;
}
```

## Test List

```csharp
Debug.Assert(MaxProductTuple(new List<Tuple<int, int>> { Tuple.Create(2, 7), Tuple.Create(2, 6), Tuple.Create(1, 8), Tuple.Create(4, 9) }) == 36);
```

```csharp
Debug.Assert(MaxProductTuple(new (int, int)[]{ (10, 20), (15, 2), (5, 10) }) == 200);
```

```csharp
Debug.Assert(MaxProductTuple(new (int, int)[] { (11, 44), (10, 15), (20, 5), (12, 9) }) == 484);
```
