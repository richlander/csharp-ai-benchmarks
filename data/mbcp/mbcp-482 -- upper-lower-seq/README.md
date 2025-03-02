# mbcp-482 -- Find sequences of uppercase followed by lowercase letters

## Text

Write a function to find sequences of one upper case letter followed by lower case letters in the given string by using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public class Matcher
{
    public string Match(string text)
    {
        string pattern = "[A-Z]+[a-z]+$";
        if (Regex.IsMatch(text, pattern))
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }
}
```

## Test List

```csharp
Debug.Assert(Match("Geeks") == "Yes");
```

```csharp
Debug.Assert(Match("geeksforGeeks") == "Yes");
```

```csharp
Debug.Assert(Match("geeks") == "No");
```
