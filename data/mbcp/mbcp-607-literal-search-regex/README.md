# mbcp607 -- Search for pattern in string using regex locating index

## Text

Write a function to search a literals string in a string and also find the location within the original string where the pattern occurs by using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public class Example
{
    public static (string, int, int) FindLiterals(string text, string pattern)
    {
        Match match = Regex.Match(text, pattern);
        int s = match.Index;
        int e = match.Index + match.Length;
        return (match.ToString(), s, e);
    }
}
```

## Test List

```csharp
Debug.Assert(FindLiterals("The quick brown fox jumps over the lazy dog.", "fox").Equals(Tuple.Create("fox", 16, 19)));
```

```csharp
Debug.Assert(FindLiterals("Its been a very crazy procedure right", "crazy").Equals(("crazy", 16, 21)));
```

```csharp
Debug.Assert(FindLiterals("Hardest choices required strongest will", "will").Equals(("will", 35, 39)));
```
