# mbcp-341 -- Convert a set into ordered tuples format

## Text

Write a function to convert the given set into ordered tuples.

## Code

```csharp
public Tuple<T> SetToTuple<T>(HashSet<T> s)
{
    var t = s.OrderBy(x => x).ToArray();
    return Tuple.Create(t);
}
```

## Test List

```csharp
Debug.Assert(SetToTuple(new HashSet<int> { 1, 2, 3, 4, 5 }).Equals(ValueTuple.Create(1, 2, 3, 4, 5)));
```

```csharp
Debug.Assert(SetToTuple(new HashSet<int> { 6, 7, 8, 9, 10, 11 }).SequenceEqual(new ValueTuple<int, int, int, int, int, int>(6, 7, 8, 9, 10, 11)));
```

```csharp
Debug.Assert(SetToTuple(new HashSet<int>{12, 13, 14, 15, 16}).SequenceEqual(new ValueTuple<int, int, int, int, int>(12, 13, 14, 15, 16)));
```
