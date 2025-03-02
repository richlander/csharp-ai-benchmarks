# mbcp-434 -- Function to match 'a' followed by one or more 'b's

## Text

Write a function that matches a string that has an a followed by one or more b's.

## Code

```csharp
using System.Text.RegularExpressions;

public class Matcher
{
    public string TextMatchOne(string text)
    {
        string patterns = "ab+?";
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
Debug.Assert(TextMatchOne("ac") == "Not matched!");
```

```csharp
Debug.Assert(TextMatchOne("dc") == "Not matched!");
```

```csharp
Debug.Assert(TextMatchOne("abba") == "Found a match!");
```
