# mbcp-13 -- Count the most frequent words in a dictionary

## Text

Write a function to count the most common words in a dictionary.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class WordCounter
{
    public List<KeyValuePair<string, int>> CountCommon(List<string> words)
    {
        var wordCounts = words.GroupBy(word => word)
                              .ToDictionary(g => g.Key, g => g.Count());
        return wordCounts.OrderByDescending(pair => pair.Value)
                         .Take(4)
                         .ToList();
    }
}
```

## Test List

```csharp
Debug.Assert(CountCommon(new List<string> { "red", "green", "black", "pink", "black", "white", "black", "eyes", "white", "black", "orange", "pink", "pink", "red", "red", "white", "orange", "white", "black", "pink", "green", "green", "pink", "green", "pink", "white", "orange", "orange", "red" }).SequenceEqual(new List<Tuple<string, int>> { Tuple.Create("pink", 6), Tuple.Create("black", 5), Tuple.Create("white", 5), Tuple.Create("red", 4) }));
```

```csharp
var result = CountCommon(new List<string> { "one", "two", "three", "four", "five", "one", "two", "one", "three", "one" });
Debug.Assert(result.SequenceEqual(new List<Tuple<string, int>> { Tuple.Create("one", 4), Tuple.Create("two", 2), Tuple.Create("three", 2), Tuple.Create("four", 1) }));
```

```csharp
Debug.Assert(CountCommon(new List<string> { "Facebook", "Apple", "Amazon", "Netflix", "Google", "Apple", "Netflix", "Amazon" }).SequenceEqual(new List<Tuple<string, int>> { Tuple.Create("Apple", 2), Tuple.Create("Amazon", 2), Tuple.Create("Netflix", 2), Tuple.Create("Facebook", 1) }));
```
