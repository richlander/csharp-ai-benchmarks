# mbcp569 -- Sort strings in each sublist of a list of lists

## Text

Write a function to sort each sublist of strings in a given list of lists.

## Code

```csharp
public List<List<T>> SortSublists<T>(List<List<T>> list1)
{
    var result = list1.Select(sublist => sublist.OrderBy(x => x).ToList()).ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(SortSublists(new List<List<string>> { new List<string> { "green", "orange" }, new List<string> { "black", "white" }, new List<string> { "white", "black", "orange" } }).SequenceEqual(new List<List<string>> { new List<string> { "green", "orange" }, new List<string> { "black", "white" }, new List<string> { "black", "orange", "white" } }));
```

```csharp
Debug.Assert(SortSublists(new List<List<string>> { new List<string> { "green", "orange" }, new List<string> { "black" }, new List<string> { "green", "orange" }, new List<string> { "white" } }).SequenceEqual(new List<List<string>> { new List<string> { "green", "orange" }, new List<string> { "black" }, new List<string> { "green", "orange" }, new List<string> { "white" } }));
```

```csharp
Debug.Assert(SortSublists(new List<List<string>> { new List<string> { "a", "b" }, new List<string> { "d", "c" }, new List<string> { "g", "h" }, new List<string> { "f", "e" } }).SequenceEqual(new List<List<string>> { new List<string> { "a", "b" }, new List<string> { "c", "d" }, new List<string> { "g", "h" }, new List<string> { "e", "f" } }));
```
