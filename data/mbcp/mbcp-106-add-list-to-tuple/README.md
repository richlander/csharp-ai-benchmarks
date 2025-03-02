# mbcp106 -- Add a list to specified tuples in a function

## Text

Write a function to add the given list to the given tuples.

## Code

```csharp
public Tuple<T> AddLists<T>(List<T> testList, Tuple<T> testTup)
{
    var res = testTup.ToList().Concat(testList).ToArray();
    return Tuple.Create(res);
}
```

## Test List

```csharp
Debug.Assert(AddLists(new List<int> { 5, 6, 7 }, new Tuple<int, int>(9, 10)).SequenceEqual(new Tuple<int, int, int, int, int>(9, 10, 5, 6, 7)));
```

```csharp
Debug.Assert(AddLists(new List<int> { 6, 7, 8 }, new Tuple<int, int>(10, 11)).SequenceEqual(new Tuple<int, int, int, int, int>(10, 11, 6, 7, 8)));
```

```csharp
Debug.Assert(AddLists(new List<int> { 7, 8, 9 }, new Tuple<int, int>(11, 12)).SequenceEqual(new Tuple<int, int, int, int, int>(11, 12, 7, 8, 9)));
```
