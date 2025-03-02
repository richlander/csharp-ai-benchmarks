# mbcp-653 -- Group key-value pairs into a dictionary of lists

## Text

Write a function to group a sequence of key-value pairs into a dictionary of lists using collections module.

## Code

```csharp
using System.Collections.Generic;

public Dictionary<TKey, List<TValue>> GroupingDictionary<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> l)
{
    var d = new Dictionary<TKey, List<TValue>>();
    foreach (var kvp in l)
    {
        if (!d.ContainsKey(kvp.Key))
        {
            d[kvp.Key] = new List<TValue>();
        }
        d[kvp.Key].Add(kvp.Value);
    }
    return d;
}
```

## Test List

```csharp
Debug.Assert(GroupingDictionary(new List<Tuple<string, int>> { Tuple.Create("yellow", 1), Tuple.Create("blue", 2), Tuple.Create("yellow", 3), Tuple.Create("blue", 4), Tuple.Create("red", 1) }) == new Dictionary<string, List<int>> { { "yellow", new List<int> { 1, 3 } }, { "blue", new List<int> { 2, 4 } }, { "red", new List<int> { 1 } } });
```

```csharp
Debug.Assert(GroupingDictionary(new Tuple<string, int>[] { Tuple.Create("yellow", 10), Tuple.Create("blue", 20), Tuple.Create("yellow", 30), Tuple.Create("blue", 40), Tuple.Create("red", 10) }).Equals(new Dictionary<string, List<int>> { { "yellow", new List<int> { 10, 30 } }, { "blue", new List<int> { 20, 40 } }, { "red", new List<int> { 10 } } }));
```

```csharp
Debug.Assert(GroupingDictionary(new Tuple<string, int>[] { Tuple.Create("yellow", 15), Tuple.Create("blue", 25), Tuple.Create("yellow", 35), Tuple.Create("blue", 45), Tuple.Create("red", 15) }).SequenceEqual(new Dictionary<string, List<int>> { { "yellow", new List<int> { 15, 35 } }, { "blue", new List<int> { 25, 45 } }, { "red", new List<int> { 15 } } }));
```
