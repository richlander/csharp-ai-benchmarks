# mbcp860 -- Check if string ends with alphanumeric characters

## Text

Write a function to check whether the given string is ending with only alphanumeric characters or not using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public class Validator
{
    private static readonly string regex = "[a-zA-Z0-9]$";

    public static string CheckAlphanumeric(string input)
    {
        if (Regex.IsMatch(input, regex))
        {
            return "Accept";
        }
        else
        {
            return "Discard";
        }
    }
}
```

## Test List

```csharp
Debug.Assert(CheckAlphanumeric("dawood@") == "Discard");
```

```csharp
Debug.Assert(CheckAlphanumeric("skdmsam326") == "Accept");
```

```csharp
Debug.Assert(CheckAlphanumeric("cooltricks@") == "Discard");
```
