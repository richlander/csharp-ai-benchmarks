# mbcp787 -- Match a string with an a followed by three b's

## Text

Write a function that matches a string that has an a followed by three 'b'.

## Code

```csharp
using System.Text.RegularExpressions;

public class Matcher
{
    public string TextMatchThree(string text)
    {
        string patterns = @"ab{3}?";
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
Debug.Assert(TextMatchThree("ac") == "Not matched!");
```

```csharp
Debug.Assert(TextMatchThree("dc") == "Not matched!");

string TextMatchThree(string input)
{
    // Implement the method logic here
}
```

```csharp
Debug.Assert(TextMatchThree("abbbba") == "Found a match!");
```
