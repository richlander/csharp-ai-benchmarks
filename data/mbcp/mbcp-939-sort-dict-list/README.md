# mbcp939 -- Sort a list of dictionaries with a lambda function

## Text

Write a function to sort a list of dictionaries using lambda function.

## Code

```csharp
public List<Dictionary<string, object>> SortedModels(List<Dictionary<string, object>> models) 
{
    var sortedModels = models.OrderBy(x => x["color"]).ToList();
    return sortedModels;
}
```

## Test List

```csharp
Debug.Assert(SortedModels(new List<Dictionary<string, object>>() {
    new Dictionary<string, object>{{"make", "Nokia"}, {"model", 216}, {"color", "Black"}},
    new Dictionary<string, object>{{"make", "Mi Max"}, {"model", 2}, {"color", "Gold"}},
    new Dictionary<string, object>{{"make", "Samsung"}, {"model", 7}, {"color", "Blue"}}
}).SequenceEqual(new List<Dictionary<string, object>>() {
    new Dictionary<string, object>{{"make", "Nokia"}, {"model", 216}, {"color", "Black"}},
    new Dictionary<string, object>{{"make", "Samsung"}, {"model", 7}, {"color", "Blue"}},
    new Dictionary<string, object>{{"make", "Mi Max"}, {"model", 2}, {"color", "Gold"}}
}));
```

```csharp
Debug.Assert(SortedModels(new List<Dictionary<string, object>>() {
    new Dictionary<string, object>() { {"make", "Vivo"}, {"model", 20}, {"color", "Blue"} },
    new Dictionary<string, object>() { {"make", "oppo"}, {"model", 17}, {"color", "Gold"} },
    new Dictionary<string, object>() { {"make", "Apple"}, {"model", 11}, {"color", "red"} }
}).SequenceEqual(new List<Dictionary<string, object>>() {
    new Dictionary<string, object>() { {"make", "Vivo"}, {"model", 20}, {"color", "Blue"} },
    new Dictionary<string, object>() { {"make", "oppo"}, {"model", 17}, {"color", "Gold"} },
    new Dictionary<string, object>() { {"make", "Apple"}, {"model", 11}, {"color", "red"} }
}));
```

```csharp
Debug.Assert(SortedModels(new List<Dictionary<string, object>> {
    new Dictionary<string, object>{{"make", "micromax"}, {"model", 40}, {"color", "grey"}},
    new Dictionary<string, object>{{"make", "poco"}, {"model", 60}, {"color", "blue"}}
}).SequenceEqual(new List<Dictionary<string, object>> {
    new Dictionary<string, object>{{"make", "poco"}, {"model", 60}, {"color", "blue"}},
    new Dictionary<string, object>{{"make", "micromax"}, {"model", 40}, {"color", "grey"}}
}));
```
