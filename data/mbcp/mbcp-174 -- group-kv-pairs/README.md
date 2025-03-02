# mbcp-174 -- Group key-value pairs into a dictionary of lists

## Text

Write a function to group a sequence of key-value pairs into a dictionary of lists.

## Code

```csharp
public Dictionary<TKey, List<TValue>> GroupKeyValue<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> l)
{
    var result = new Dictionary<TKey, List<TValue>>();
    foreach (var kvp in l)
    {
        if (!result.ContainsKey(kvp.Key))
        {
            result[kvp.Key] = new List<TValue>();
        }
        result[kvp.Key].Add(kvp.Value);
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(GroupKeyValue(new List<Tuple<string, int>> { Tuple.Create("yellow", 1), Tuple.Create("blue", 2), Tuple.Create("yellow", 3), Tuple.Create("blue", 4), Tuple.Create("red", 1) }).SequenceEqual(new Dictionary<string, List<int>> { { "yellow", new List<int> { 1, 3 } }, { "blue", new List<int> { 2, 4 } }, { "red", new List<int> { 1 } } }));
```

```csharp
Debug.Assert(GroupKeyValue(new List<Tuple<string, int>> { Tuple.Create("python", 1), Tuple.Create("python", 2), Tuple.Create("python", 3), Tuple.Create("python", 4), Tuple.Create("python", 5) }).SequenceEqual(new Dictionary<string, List<int>> { { "python", new List<int> { 1, 2, 3, 4, 5 } } }));
```

```csharp
Debug.Assert(GroupKeyValue(new Tuple<string, int>[] { 
    Tuple.Create("yellow", 100), 
    Tuple.Create("blue", 200), 
    Tuple.Create("yellow", 300), 
    Tuple.Create("blue", 400), 
    Tuple.Create("red", 100) 
}) == new Dictionary<string, List<int>> { 
    { "yellow", new List<int> { 100, 300 } }, 
    { "blue", new List<int> { 200, 400 } }, 
    { "red", new List<int> { 100 } } 
});
```
