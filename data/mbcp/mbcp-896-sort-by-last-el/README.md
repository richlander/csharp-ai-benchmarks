# mbcp896 -- Sort tuples by their last element in ascending order

## Text

Write a function to sort a list in increasing order by the last element in each tuple from a given list of non-empty tuples.

## Code

```csharp
public static List<Tuple> SortListLast(List<Tuple> tuples)
{
    return tuples.OrderBy(Last).ToList();
}

public static object Last(List<object> n)
{
    return n.Last();
}
```

## Test List

```csharp
Debug.Assert(SortListLast(new List<(int, int)> { (2, 5), (1, 2), (4, 4), (2, 3), (2, 1) }).SequenceEqual(new List<(int, int)> { (2, 1), (1, 2), (2, 3), (4, 4), (2, 5) }));
```

```csharp
Debug.Assert(SortListLast(new List<(int, int)> { (9, 8), (4, 7), (3, 5), (7, 9), (1, 2) }).SequenceEqual(new List<(int, int)> { (1, 2), (3, 5), (4, 7), (9, 8), (7, 9) }));
```

```csharp
Debug.Assert(SortListLast(new List<Tuple<int, int>> { Tuple.Create(20, 50), Tuple.Create(10, 20), Tuple.Create(40, 40) }).SequenceEqual(new List<Tuple<int, int>> { Tuple.Create(10, 20), Tuple.Create(40, 40), Tuple.Create(20, 50) }));
```
