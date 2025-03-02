# mbcp-193 -- Remove duplicates from a given tuple

## Text

Write a function to remove the duplicates from the given tuple.

## Code

```csharp
public Tuple<T> RemoveTuple<T>(Tuple<T> testTup)
{
    var res = new HashSet<T>(testTup).ToArray();
    return Tuple.Create(res);
}
```

## Test List

```csharp
Debug.Assert(RemoveTuple(new Tuple<int, int, int, int, int, int, int, int, int>(1, 3, 5, 2, 3, 5, 1, 1, 3)).Equals(new Tuple<int, int, int, int>(1, 2, 3, 5)));
```

```csharp
Debug.Assert(RemoveTuple(new Tuple<int, int, int, int, int, int, int, int, int, int>(2, 3, 4, 4, 5, 6, 6, 7, 8, 8)).SequenceEqual(new Tuple<int, int, int, int, int, int, int>(2, 3, 4, 5, 6, 7, 8)));
```

```csharp
Debug.Assert(RemoveTuple(new Tuple<int, int, int, int, int, int, int, int>(11, 12, 13, 11, 11, 12, 14, 13)).Equals(new Tuple<int, int, int, int>(11, 12, 13, 14)));
```
