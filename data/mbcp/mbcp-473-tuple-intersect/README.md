# mbcp473 -- Find intersection of elements in tuple list

## Text

Write a function to find the tuple intersection of elements in the given tuple list irrespective of their order.

## Code

```csharp
public static HashSet<Tuple<int, int>> TupleIntersection(List<Tuple<int, int>> testList1, List<Tuple<int, int>> testList2) {
    var res = new HashSet<Tuple<int, int>>(testList1.Select(ele => Tuple.Create(Math.Min(ele.Item1, ele.Item2), Math.Max(ele.Item1, ele.Item2))))
        .Intersect(new HashSet<Tuple<int, int>>(testList2.Select(ele => Tuple.Create(Math.Min(ele.Item1, ele.Item2), Math.Max(ele.Item1, ele.Item2)))));
    return res;
}
```

## Test List

```csharp
Debug.Assert(TupleIntersection(new List<(int, int)> { (3, 4), (5, 6), (9, 10), (4, 5) }, new List<(int, int)> { (5, 4), (3, 4), (6, 5), (9, 11) }).SetEquals(new HashSet<(int, int)> { (4, 5), (3, 4), (5, 6) }));
```

```csharp
Debug.Assert(TupleIntersection(new List<(int, int)> { (4, 1), (7, 4), (11, 13), (17, 14) }, new List<(int, int)> { (1, 4), (7, 4), (16, 12), (10, 13) }).SetEquals(new HashSet<(int, int)> { (4, 7), (1, 4) }));
```

```csharp
Debug.Assert(TupleIntersection(new List<Tuple<int, int>> { Tuple.Create(2, 1), Tuple.Create(3, 2), Tuple.Create(1, 3), Tuple.Create(1, 4) }, new List<Tuple<int, int>> { Tuple.Create(11, 2), Tuple.Create(2, 3), Tuple.Create(6, 2), Tuple.Create(1, 3) }).SetEquals(new HashSet<Tuple<int, int>> { Tuple.Create(1, 3), Tuple.Create(2, 3) }));
```
