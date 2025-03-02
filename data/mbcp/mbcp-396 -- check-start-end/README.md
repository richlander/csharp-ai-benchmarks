# mbcp-396 -- Check if string starts and ends with same character

## Text

Write a function to check whether the given string starts and ends with the same character or not using regex.

## Code

```csharp
using System;
using System.Text.RegularExpressions;

public class Validator
{
    private static readonly string regex = @"^[a-z]$|^([a-z]).*\1$";
    
    public static string CheckChar(string input)
    {
        if (Regex.IsMatch(input, regex))
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
Debug.Assert(CheckChar("abba") == "Valid");
```

```csharp
Debug.Assert(CheckChar("a") == "Valid");
```

```csharp
Debug.Assert(CheckChar("abcd") == "Invalid");
```
