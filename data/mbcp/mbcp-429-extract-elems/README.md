# mbcp429 -- Extract elementwise tuples from two given tuples

## Text

Write a function to extract the elementwise and tuples from the given two tuples.

## Code

```csharp
public static Tuple<int, int> AndTuples(Tuple<int, int> testTup1, Tuple<int, int> testTup2)
{
    var res = Tuple.Create(testTup1.Item1 & testTup2.Item1, testTup1.Item2 & testTup2.Item2);
    return res;
}
```

## Test List

```csharp
Debug.Assert(AndTuples((10, 4, 6, 9), (5, 2, 3, 3)).Equals((0, 0, 2, 1)));
```

```csharp
Debug.Assert(AndTuples(new Tuple<int, int, int, int>(1, 2, 3, 4), new Tuple<int, int, int, int>(5, 6, 7, 8)).Equals(new Tuple<int, int, int, int>(1, 2, 3, 0)));
```

```csharp
Debug.Assert(AndTuples((8, 9, 11, 12), (7, 13, 14, 17)).Equals((0, 9, 10, 0)));
```
