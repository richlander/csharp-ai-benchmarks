# mbcp285 -- Match string pattern with a followed by two to three b's

## Text

Write a function that matches a string that has an a followed by two to three 'b'.

## Code

```csharp
using System.Text.RegularExpressions;

public class Matcher
{
    public string TextMatchTwoThree(string text)
    {
        string patterns = "ab{2,3}";
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
Debug.Assert(TextMatchTwoThree("ac") == "Not matched!");
```

```csharp
Debug.Assert(TextMatchTwoThree("dc") == "Not matched!");
```

```csharp
Debug.Assert(TextMatchTwoThree("abbbba") == "Found a match!");
```
