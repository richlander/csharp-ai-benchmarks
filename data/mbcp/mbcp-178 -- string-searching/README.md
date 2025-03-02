# mbcp-178 -- Search for literal strings within a larger string

## Text

Write a function to search some literals strings in a string.

## Code

```csharp
using System.Text.RegularExpressions;

public string StringLiterals(string[] patterns, string text)
{
    foreach (var pattern in patterns)
    {
        if (Regex.IsMatch(text, pattern))
            return "Matched!";
        else
            return "Not Matched!";
    }
    return "Not Matched!";
}
```

## Test List

```csharp
Debug.Assert(StringLiterals(new string[] { "language" }, "python language") == "Matched!");
```

```csharp
Debug.Assert(StringLiterals(new string[] { "program" }, "python language") == "Not Matched!");
```

```csharp
Debug.Assert(StringLiterals(new string[] {"python"}, "programming language") == "Not Matched!");
```
