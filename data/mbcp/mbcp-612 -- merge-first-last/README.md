# mbcp-612 -- Merge first and last elements of list of lists

## Text

Write a C# function to merge the first and last elements separately in a list of lists.

## Code

```csharp
public List<List<T>> Merge<T>(List<List<T>> lst)  
{  
    return lst.Select(ele => ele.ToList()).ToList();  
}
```

## Test List

```csharp
Debug.Assert(Merge(new List<List<string>> { new List<string> { "x", "y" }, new List<string> { "a", "b" }, new List<string> { "m", "n" } }).SequenceEqual(new List<List<string>> { new List<string> { "x", "a", "m" }, new List<string> { "y", "b", "n" } }));
```

```csharp
Debug.Assert(Merge(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 }, new List<int> { 5, 6 }, new List<int> { 7, 8 } }) == new List<List<int>> { new List<int> { 1, 3, 5, 7 }, new List<int> { 2, 4, 6, 8 } });
```

```csharp
Debug.Assert(Merge(new List<List<string>> { new List<string> { "x", "y", "z" }, new List<string> { "a", "b", "c" }, new List<string> { "m", "n", "o" } }) == new List<List<string>> { new List<string> { "x", "a", "m" }, new List<string> { "y", "b", "n" }, new List<string> { "z", "c", "o" } });
```
