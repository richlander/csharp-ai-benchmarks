# mbcp-773 -- Find substring positions and occurrences in a string

## Text

Write a function to find the occurrence and position of the substrings within a string.

## Code

```csharp
using System.Text.RegularExpressions;

public (string Substring, int Start, int End) OccuranceSubstring(string text, string pattern)
{
    foreach (Match match in Regex.Matches(text, pattern))
    {
        int s = match.Index;
        int e = match.Index + match.Length;
        return (text.Substring(s, e - s), s, e);
    }
    return (null, -1, -1);
}
```

## Test List

```csharp
Debug.Assert(OccuranceSubstring("python programming, python language", "python").Equals(Tuple.Create("python", 0, 6)));
```

```csharp
Debug.Assert(OccuranceSubstring("python programming,programming language", "programming").Equals(("programming", 7, 18)));
```

```csharp
Debug.Assert(OccuranceSubstring("python programming,programming language", "language").Equals(("language", 31, 39)));
```
