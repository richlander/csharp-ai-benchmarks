# mbcp879 -- Match strings with 'a' and ending in 'b' using regex

## Text

Write a function that matches a string that has an 'a' followed by anything, ending in 'b' by using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public class Matcher
{
    public string TextMatch(string text)
    {
        string patterns = "a.*?b$";
        if (Regex.IsMatch(text, patterns))
        {
            return "Found a match!";
        }
        else
        {
            return "Not matched!";
        }
    }
}
```

## Test List

```csharp
Debug.Assert(TextMatch("aabbbbd") == "Not matched!");
```

```csharp
Debug.Assert(TextMatch("aabAbbbc") == "Not matched!");
```

```csharp
Debug.Assert(TextMatch("accddbbjjjb") == "Found a match!");
```
