# mbcp-662 -- Sort a list within a dictionary using a function

## Text

Write a function to sort a list in a dictionary.

## Code

```csharp
public Dictionary<string, List<string>> SortedDict(Dictionary<string, List<string>> dict1)
{
    var sortedDict = dict1.ToDictionary(x => x.Key, x => x.Value.OrderBy(y => y).ToList());
    return sortedDict;
}
```

## Test List

```csharp
Debug.Assert(SortedDict(new Dictionary<string, List<int>> { { "n1", new List<int> { 2, 3, 1 } }, { "n2", new List<int> { 5, 1, 2 } }, { "n3", new List<int> { 3, 2, 4 } } }) .SequenceEqual(new Dictionary<string, List<int>> { { "n1", new List<int> { 1, 2, 3 } }, { "n2", new List<int> { 1, 2, 5 } }, { "n3", new List<int> { 2, 3, 4 } } }));
```

```csharp
Debug.Assert(SortedDict(new Dictionary<string, List<int>>() { {"n1", new List<int>() { 25, 37, 41 } }, {"n2", new List<int>() { 41, 54, 63 } }, {"n3", new List<int>() { 29, 38, 93 } } }) == new Dictionary<string, List<int>>() { {"n1", new List<int>() { 25, 37, 41 } }, {"n2", new List<int>() { 41, 54, 63 } }, {"n3", new List<int>() { 29, 38, 93 } } });
```

```csharp
Debug.Assert(SortedDict(new Dictionary<string, List<int>> { { "n1", new List<int> { 58, 44, 56 } }, { "n2", new List<int> { 91, 34, 58 } }, { "n3", new List<int> { 100, 200, 300 } } }) 
    .SequenceEqual(new Dictionary<string, List<int>> { { "n1", new List<int> { 44, 56, 58 } }, { "n2", new List<int> { 34, 58, 91 } }, { "n3", new List<int> { 100, 200, 300 } } }));
```
