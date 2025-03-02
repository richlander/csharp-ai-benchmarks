# mbcp-391 -- Convert multiple lists into a nested dictionary

## Text

Write a function to convert more than one list to nested dictionary.

## Code

```csharp
public List<Dictionary<string, Dictionary<string, string>>> ConvertListDictionary(List<string> l1, List<string> l2, List<string> l3) {
    var result = l1.Zip(l2, (x, y) => new { x, y })
                   .Zip(l3, (xy, z) => new { xy.x, xy.y, z })
                   .Select(item => new Dictionary<string, Dictionary<string, string>> {
                       { item.x, new Dictionary<string, string> { { item.y, item.z } } }
                   })
                   .ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(ConvertListDictionary(new List<string> { "S001", "S002", "S003", "S004" }, new List<string> { "Adina Park", "Leyton Marsh", "Duncan Boyle", "Saim Richards" }, new List<int> { 85, 98, 89, 92 }).SequenceEqual(new List<Dictionary<string, Dictionary<string, int>>> { 
    new Dictionary<string, Dictionary<string, int>> { { "S001", new Dictionary<string, int> { { "Adina Park", 85 } } } }, 
    new Dictionary<string, Dictionary<string, int>> { { "S002", new Dictionary<string, int> { { "Leyton Marsh", 98 } } } }, 
    new Dictionary<string, Dictionary<string, int>> { { "S003", new Dictionary<string, int> { { "Duncan Boyle", 89 } } } }, 
    new Dictionary<string, Dictionary<string, int>> { { "S004", new Dictionary<string, int> { { "Saim Richards", 92 } } } } 
}));
```

```csharp
Debug.Assert(ConvertListDictionary(new List<string>{"abc","def","ghi","jkl"}, new List<string>{"python","program","language","programs"}, new List<int>{100,200,300,400}).SequenceEqual(new List<Dictionary<string, Dictionary<string, int>>>{ 
    new Dictionary<string, Dictionary<string, int>> {{"abc", new Dictionary<string, int>{{"python", 100}}}}, 
    new Dictionary<string, Dictionary<string, int>> {{"def", new Dictionary<string, int>{{"program", 200}}}}, 
    new Dictionary<string, Dictionary<string, int>> {{"ghi", new Dictionary<string, int>{{"language", 300}}}}, 
    new Dictionary<string, Dictionary<string, int>> {{"jkl", new Dictionary<string, int>{{"programs", 400}}}} 
}));
```

```csharp
Debug.Assert(ConvertListDictionary(new List<string> { "A1", "A2", "A3", "A4" }, new List<string> { "java", "C", "C++", "DBMS" }, new List<int> { 10, 20, 30, 40 }).SequenceEqual(new List<Dictionary<string, Dictionary<string, int>>> { 
    new Dictionary<string, Dictionary<string, int>> { { "A1", new Dictionary<string, int> { { "java", 10 } } } },
    new Dictionary<string, Dictionary<string, int>> { { "A2", new Dictionary<string, int> { { "C", 20 } } } },
    new Dictionary<string, Dictionary<string, int>> { { "A3", new Dictionary<string, int> { { "C++", 30 } } } },
    new Dictionary<string, Dictionary<string, int>> { { "A4", new Dictionary<string, int> { { "DBMS", 40 } } } }
}));
```
