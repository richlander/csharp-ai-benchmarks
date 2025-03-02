# mbcp-779 -- Count unique lists in a given list

## Text

Write a function to count the number of unique lists within a list.

## Code

```csharp
public Dictionary<Tuple<int>, int> UniqueSublists(List<List<int>> list1) 
{
    var result = new Dictionary<Tuple<int>, List<int>>();
    foreach (var l in list1) 
    {
        var key = Tuple.Create(l.ToArray());
        if (!result.ContainsKey(key)) 
        {
            result[key] = new List<int>();
        }
        result[key].Add(1);
    }
    foreach (var kvp in result.ToList()) 
    {
        result[kvp.Key] = new List<int> { kvp.Value.Sum() };
    }
    return result.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First());
}
```

## Test List

```csharp
Debug.Assert(UniqueSublists(new List<List<int>> { new List<int> { 1, 3 }, new List<int> { 5, 7 }, new List<int> { 1, 3 }, new List<int> { 13, 15, 17 }, new List<int> { 5, 7 }, new List<int> { 9, 11 } }) == new Dictionary<Tuple<int, int>, int> { { Tuple.Create(1, 3), 2 }, { Tuple.Create(5, 7), 2 }, { Tuple.Create(13, 15, 17), 1 }, { Tuple.Create(9, 11), 1 } });
```

```csharp
Debug.Assert(UniqueSublists(new List<List<string>> { new List<string> { "green", "orange" }, new List<string> { "black" }, new List<string> { "green", "orange" }, new List<string> { "white" } }).SequenceEqual(new Dictionary<(string, string), int> { { ("green", "orange"), 2 }, { ("black",), 1 }, { ("white",), 1 } }));
```

```csharp
Debug.Assert(UniqueSublists(new List<List<int>>{ new List<int>{ 1, 2 }, new List<int>{ 3, 4 }, new List<int>{ 4, 5 }, new List<int>{ 6, 7 }}) .SequenceEqual(new Dictionary<(int, int), int> { { (1, 2), 1 }, { (3, 4), 1 }, { (4, 5), 1 }, { (6, 7), 1 } }));
```
