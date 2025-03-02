# mbcp579 -- Find dissimilar elements in two tuples

## Text

Write a function to find the dissimilar elements in the given two tuples.

## Code

```csharp
public static Tuple<T>[] FindDissimilar<T>(Tuple<T>[] testTup1, Tuple<T>[] testTup2)
{
    var res = new HashSet<T>(testTup1).SymmetricExceptWith(testTup2);
    return res.ToArray();
}
```

## Test List

```csharp
Debug.Assert(FindDissimilar(new Tuple<int, int, int, int>(3, 4, 5, 6), new Tuple<int, int, int, int>(5, 7, 4, 10)).Equals(new Tuple<int, int, int, int>(3, 6, 7, 10)));
```

```csharp
Debug.Assert(FindDissimilar(new[] { 1, 2, 3, 4 }, new[] { 7, 2, 3, 9 }).SequenceEqual(new[] { 1, 4, 7, 9 }));
```

```csharp
Debug.Assert(FindDissimilar(new Tuple<int, int, int, int>(21, 11, 25, 26), new Tuple<int, int, int, int>(26, 34, 21, 36)).Equals(new Tuple<int, int, int, int>(34, 36, 11, 25)));
```
