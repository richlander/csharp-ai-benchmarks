# mbcp917 -- Find uppercase followed by lowercase sequences

## Text

Write a function to find the sequences of one upper case letter followed by lower case letters.

## Code

```csharp
using System.Text.RegularExpressions;

public class Converter
{
    public string TextUppercaseLowercase(string text)
    {
        string patterns = "[A-Z]+[a-z]+$";
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
Debug.Assert(TextUppercaseLowercase("AaBbGg") == "Found a match!");
```

```csharp
Debug.Assert(TextUppercaseLowercase("aA") == "Not matched!");
```

```csharp
Debug.Assert(TextUppercaseLowercase("PYTHON") == "Not matched!");
```
