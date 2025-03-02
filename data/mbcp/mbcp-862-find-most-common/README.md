# mbcp862 -- Count the most common words in a text input

## Text

Write a function to find the occurrences of n most common words in a given text.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class WordCounter
{
    public List<KeyValuePair<string, int>> NCommonWords(string text, int n)
    {
        var words = Regex.Matches(text, @"\w+").Cast<Match>().Select(m => m.Value);
        var nCommonWords = words.GroupBy(word => word)
                                 .Select(group => new KeyValuePair<string, int>(group.Key, group.Count()))
                                 .OrderByDescending(pair => pair.Value)
                                 .Take(n)
                                 .ToList();
        return nCommonWords;
    }
}
```

## Test List

```csharp
Debug.Assert(NCommonWords("python is a programming language", 1).SequenceEqual(new List<Tuple<string, int>> { Tuple.Create("python", 1) }));
```

```csharp
Debug.Assert(NCommonWords("python is a programming language", 1).SequenceEqual(new KeyValuePair<string, int>[] { new KeyValuePair<string, int>("python", 1) }));
```

```csharp
Debug.Assert(NCommonWords("python is a programming language", 5).SequenceEqual(new List<(string, int)> { ("python", 1), ("is", 1), ("a", 1), ("programming", 1), ("language", 1) }));
```
