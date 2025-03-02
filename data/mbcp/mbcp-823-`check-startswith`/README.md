# mbcp823 -- Check if a string starts with a substring using regex

## Text

Write a function to check if the given string starts with a substring using regex.

## Code

```csharp
using System;
using System.Text.RegularExpressions;

public class SubstringChecker
{
    public string CheckSubstring(string inputString, string sample)
    {
        if (inputString.Contains(sample))
        {
            string pattern = "^" + Regex.Escape(sample);
            Match match = Regex.Match(inputString, pattern);
            if (match.Success)
            {
                return "string starts with the given substring";
            }
            else
            {
                return "string doesnt start with the given substring";
            }
        }
        else
        {
            return "entered string isnt a substring";
        }
    }
}
```

## Test List

```csharp
Debug.Assert(CheckSubstring("dreams for dreams makes life fun", "makes") == "string doesnt start with the given substring");

string CheckSubstring(string mainString, string substring) {
    if (!mainString.StartsWith(substring)) {
        return "string doesnt start with the given substring";
    }
    return ""; // or any appropriate return based on your logic
}
```

```csharp
Debug.Assert(CheckSubstring("Hi there how are you Hi alex", "Hi") == "string starts with the given substring");

string CheckSubstring(string mainString, string substring) {
    return mainString.StartsWith(substring) ? "string starts with the given substring" : "";
}
```

```csharp
Debug.Assert(CheckSubstring("Its been a long day", "been") == "string doesnt start with the given substring");

public string CheckSubstring(string mainString, string substring)
{
    if (!mainString.StartsWith(substring))
    {
        return "string doesnt start with the given substring";
    }
    return string.Empty;
}
```
