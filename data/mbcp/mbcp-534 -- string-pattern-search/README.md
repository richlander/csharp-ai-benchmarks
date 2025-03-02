# mbcp-534 -- Search for a pattern in a string and locate it

## Text

Write a function to search a literals string in a string and also find the location within the original string where the pattern occurs.

## Code

```csharp
using System.Text.RegularExpressions;

public (int, int) SearchLiteral(string pattern, string text)
{
    Match match = Regex.Match(text, pattern);
    int s = match.Index;
    int e = match.Index + match.Length;
    return (s, e);
}
```

## Test List

```csharp
Debug.Assert(SearchLiteral("python", "python programming language").Equals((0, 6)));

public static (int, int) SearchLiteral(string searchTerm, string text)
{
    int index = text.IndexOf(searchTerm);
    if (index != -1)
    {
        return (index, index + searchTerm.Length);
    }
    return (-1, -1);
}
```

```csharp
Debug.Assert(SearchLiteral("programming", "python programming language").Equals((7, 18)));
```

```csharp
Debug.Assert(SearchLiteral("language", "python programming language").Equals((19, 27)));
```
