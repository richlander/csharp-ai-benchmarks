# mbcp-956 -- Split strings at uppercase letters using regex

## Text

Write a function to split the given string at uppercase letters by using regex.

## Code

```csharp
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Splitter
{
    public List<string> SplitList(string text)
    {
        return new List<string>(Regex.Matches(text, "[A-Z][^A-Z]*").Select(m => m.Value));
    }
}
```

## Test List

```csharp
Debug.Assert(SplitList("LearnToBuildAnythingWithGoogle").SequenceEqual(new List<string> { "Learn", "To", "Build", "Anything", "With", "Google" }));
```

```csharp
Debug.Assert(SplitList("ApmlifyingTheBlack+DeveloperCommunity").SequenceEqual(new List<string> { "Apmlifying", "The", "Black+", "Developer", "Community" }));
```

```csharp
Debug.Assert(SplitList("UpdateInTheGoEcoSystem").SequenceEqual(new List<string> { "Update", "In", "The", "Go", "Eco", "System" }));
```
