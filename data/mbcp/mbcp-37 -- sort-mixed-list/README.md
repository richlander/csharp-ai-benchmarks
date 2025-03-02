# mbcp-37 -- Sort a mixed list of integers and strings

## Text

Write a function to sort a given mixed list of integers and strings.

## Code

```csharp
public List<object> SortMixedList(List<object> mixedList) {
    var intPart = mixedList.OfType<int>().OrderBy(i => i).ToList();
    var strPart = mixedList.OfType<string>().OrderBy(i => i).ToList();
    return intPart.Concat(strPart).ToList();
}
```

## Test List

```csharp
Debug.Assert(SortMixedList(new object[] { 19, "red", 12, "green", "blue", 10, "white", "green", 1 }).SequenceEqual(new object[] { 1, 10, 12, 19, "blue", "green", "green", "red", "white" }));
```

```csharp
Debug.Assert(SortMixedList(new object[] { 19, "red", 12, "green", "blue", 10, "white", "green", 1 }).SequenceEqual(new object[] { 1, 10, 12, 19, "blue", "green", "green", "red", "white" }));
```

```csharp
Debug.Assert(SortMixedList(new List<object> { 19, "red", 12, "green", "blue", 10, "white", "green", 1 }).SequenceEqual(new List<object> { 1, 10, 12, 19, "blue", "green", "green", "red", "white" }));
```
