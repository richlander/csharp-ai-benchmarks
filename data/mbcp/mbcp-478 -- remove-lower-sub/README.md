# mbcp-478 -- Remove lowercase substrings from a string

## Text

Write a function to remove lowercase substrings from a given string.

## Code

```csharp
using System.Text.RegularExpressions;

public class StringManipulator
{
    public string RemoveLowercase(string str1)
    {
        return Regex.Replace(str1, "[a-z]", "");
    }
}
```

## Test List

```csharp
Debug.Assert(RemoveLowercase("PYTHon") == "PYTH");
```

```csharp
Debug.Assert(RemoveLowercase("FInD") == "FID");
```

```csharp
Debug.Assert(RemoveLowercase("STRinG") == "STRG");
```
