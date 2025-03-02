# mbcp945 -- Convert tuples to set with a defined function

## Text

Write a function to convert the given tuples into set.

## Code

```csharp
public HashSet<T> TupleToSet<T>(Tuple<T> t)
{
    return new HashSet<T>(new[] { t.Item1, t.Item2 });
}
```

## Test List

```csharp
Debug.Assert(TupleToSet(new Tuple<string, string, string>("x", "y", "z")).SetEquals(new HashSet<string> { "y", "x", "z" }));
```

```csharp
Debug.Assert(TupleToSet(new Tuple<string, string, string>("a", "b", "c")).SetEquals(new HashSet<string> { "c", "a", "b" }));
```

```csharp
Debug.Assert(TupleToSet(("z", "d", "e")).SetEquals(new HashSet<string> { "d", "e", "z" }));
```
