# mbcp-104 -- Sort sublists of strings using a lambda function

## Text

Write a function to sort each sublist of strings in a given list of lists using lambda function.

## Code

```csharp
public List<List<T>> SortSublists<T>(List<List<T>> inputList) where T : IComparable
{
    var result = inputList.Select(x => x.OrderBy(y => y).ToList()).ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(SortSublists(new List<List<string>>() { new List<string>() { "green", "orange" }, new List<string>() { "black", "white" }, new List<string>() { "white", "black", "orange" } }).SequenceEqual(new List<List<string>>() { new List<string>() { "green", "orange" }, new List<string>() { "black", "white" }, new List<string>() { "black", "orange", "white" } }));
```

```csharp
Debug.Assert(SortSublists(new List<List<string>> { new List<string> { " red ", "green" }, new List<string> { "blue ", " black" }, new List<string> { " orange", "brown" } }).SequenceEqual(new List<List<string>> { new List<string> { " red ", "green" }, new List<string> { " black", "blue " }, new List<string> { " orange", "brown" } }));
```

```csharp
Debug.Assert(SortSublists(new List<List<string>> { new List<string> { "zilver", "gold" }, new List<string> { "magnesium", "aluminium" }, new List<string> { "steel", "bronze" } }).SequenceEqual(new List<List<string>> { new List<string> { "gold", "zilver" }, new List<string> { "aluminium", "magnesium" }, new List<string> { "bronze", "steel" } }));
```
