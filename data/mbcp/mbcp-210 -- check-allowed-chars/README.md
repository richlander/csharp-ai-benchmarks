# mbcp-210 -- Check string for allowed characters using regex

## Text

Write a function to check that the given string contains only a certain set of characters(in this case a-z, a-z and 0-9) by using regex.

## Code

```csharp
public static bool IsAllowedSpecificChar(string input)
{
    var getChar = new Regex(@"[^a-zA-Z0-9\.]");
    var match = getChar.Match(input);
    return !match.Success;
}
```

## Test List

```csharp
Debug.Assert(IsAllowedSpecificChar("ABCDEFabcdef123450") == true);
```

```csharp
Debug.Assert(IsAllowedSpecificChar("*&%@#!}{") == false);
```

```csharp
Debug.Assert(IsAllowedSpecificChar("HELLOhowareyou98765") == true);
```
