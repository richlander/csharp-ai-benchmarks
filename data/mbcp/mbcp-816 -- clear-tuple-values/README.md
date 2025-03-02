# mbcp-816 -- Clear all values in the provided tuples function

## Text

Write a function to clear the values of the given tuples.

## Code

```csharp
public static Tuple<T> ClearTuple<T>(Tuple<T> testTup)
{
    var temp = testTup.ToList();
    temp.Clear();
    testTup = Tuple.Create(temp.ToArray());
    return testTup;
}
```

## Test List

```csharp
Debug.Assert(ClearTuple(new Tuple<int, int, int, int, int>(1, 5, 3, 6, 8)).Equals(new Tuple()));
```

```csharp
Debug.Assert(ClearTuple(new Tuple<int, int, int, int, int>(2, 1, 4, 5, 6)).Equals(Tuple.Create()));
```

```csharp
Debug.Assert(ClearTuple(new Tuple<int, int, int, int, int>(3, 2, 5, 6, 8)).Equals(Tuple.Create()));
```
