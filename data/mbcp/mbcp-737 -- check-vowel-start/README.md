# mbcp-737 -- Check if a string starts with a vowel using regex

## Text

Write a function to check whether the given string is starting with a vowel or not using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public class StringChecker
{
    private static string regex = "^[aeiouAEIOU][A-Za-z0-9_]*";

    public static string CheckStr(string inputString)
    {
        if (Regex.IsMatch(inputString, regex))
        {
            return "Valid";
        }
        else
        {
            return "Invalid";
        }
    }
}
```

## Test List

```csharp
Debug.Assert(CheckStr("annie") == "Valid");
```

```csharp
Debug.Assert(CheckStr("dawood") == "Invalid");
```

```csharp
Debug.Assert(CheckStr("Else") == "Valid");
```
