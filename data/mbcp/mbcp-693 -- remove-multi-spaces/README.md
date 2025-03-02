# mbcp-693 -- Remove extra spaces in a string using regex

## Text

Write a function to remove multiple spaces in a string by using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public string RemoveMultipleSpaces(string text1)
{
    return Regex.Replace(text1, " +", " ");
}
```

## Test List

```csharp
Debug.Assert(RemoveMultipleSpaces("Google      Assistant") == "Google Assistant");
```

```csharp
Debug.Assert(RemoveMultipleSpaces("Quad      Core") == "Quad Core");
```

```csharp
Debug.Assert(RemoveMultipleSpaces("ChromeCast      Built-in") == "ChromeCast Built-in");
```
