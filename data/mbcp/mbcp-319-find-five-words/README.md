# mbcp319 -- Find five-letter words in a string using regex

## Text

Write a function to find all five characters long word in the given string by using regex.

## Code

```csharp
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class WordFinder
{
    public List<string> FindLongWord(string text) 
    {
        return new List<string>(Regex.Matches(text, @"\b\w{5}\b").Select(m => m.Value));
    }
}
```

## Test List

```csharp
Debug.Assert(FindLongWord("Please move back to strem").SequenceEqual(new List<string> { "strem" }));
```

```csharp
Debug.Assert(FindLongWord("4K Ultra HD streaming player").SequenceEqual(new List<string> { "Ultra" }));
```

```csharp
Debug.Assert(FindLongWord("Streaming Media Player").SequenceEqual(new List<string> { "Media" }));
```
