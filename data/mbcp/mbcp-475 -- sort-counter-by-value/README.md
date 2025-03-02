# mbcp-475 -- Sort counter values in ascending order

## Text

Write a function to sort counter by value.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class Example
{
    public List<KeyValuePair<string, int>> SortCounter(Dictionary<string, int> dict1)
    {
        var sortedCounter = dict1.OrderByDescending(x => x.Value).ToList();
        return sortedCounter;
    }
}
```

## Test List

```csharp
Debug.Assert(SortCounter(new Dictionary<string, int> { {"Math", 81}, {"Physics", 83}, {"Chemistry", 87} }).SequenceEqual(new List<KeyValuePair<string, int>> { new KeyValuePair<string, int>("Chemistry", 87), new KeyValuePair<string, int>("Physics", 83), new KeyValuePair<string, int>("Math", 81) }));
```

```csharp
Debug.Assert(SortCounter(new Dictionary<string, int>{{"Math", 400}, {"Physics", 300}, {"Chemistry", 250}}).SequenceEqual(new List<Tuple<string, int>>{Tuple.Create("Math", 400), Tuple.Create("Physics", 300), Tuple.Create("Chemistry", 250)}));
```

```csharp
Debug.Assert(SortCounter(new Dictionary<string, int>{{"Math", 900}, {"Physics", 1000}, {"Chemistry", 1250}}).SequenceEqual(new List<KeyValuePair<string, int>> { new KeyValuePair<string, int>("Chemistry", 1250), new KeyValuePair<string, int>("Physics", 1000), new KeyValuePair<string, int>("Math", 900) }));
```
