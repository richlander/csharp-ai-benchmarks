# mbcp-484 -- Remove matching tuples from two provided tuples

## Text

Write a function to remove the matching tuples from the given two tuples.

## Code

```csharp
public List<Tuple> RemoveMatchingTuple(List<Tuple> testList1, List<Tuple> testList2) {
    var res = testList1.Where(sub => !testList2.Contains(sub)).ToList();
    return res;
}
```

## Test List

```csharp
Debug.Assert(RemoveMatchingTuple(new List<Tuple<string, string>> { Tuple.Create("Hello", "dude"), Tuple.Create("How", "are"), Tuple.Create("you", "?") }, new List<Tuple<string, string>> { Tuple.Create("Hello", "dude"), Tuple.Create("How", "are") }).SequenceEqual(new List<Tuple<string, string>> { Tuple.Create("you", "?") }));
```

```csharp
Debug.Assert(RemoveMatchingTuple(new List<Tuple<string, string>> { Tuple.Create("Part", "of"), Tuple.Create("the", "journey"), Tuple.Create("is ", "end") }, new List<Tuple<string, string>> { Tuple.Create("Journey", "the"), Tuple.Create("is", "end") }).SequenceEqual(new List<Tuple<string, string>> { Tuple.Create("Part", "of"), Tuple.Create("the", "journey"), Tuple.Create("is ", "end") }));
```

```csharp
Debug.Assert(RemoveMatchingTuple(new[] { Tuple.Create("Its", "been"), Tuple.Create("a", "long"), Tuple.Create("day", "without") }, new[] { Tuple.Create("a", "long"), Tuple.Create("my", "friend") }).SequenceEqual(new[] { Tuple.Create("Its", "been"), Tuple.Create("day", "without") }));
```
