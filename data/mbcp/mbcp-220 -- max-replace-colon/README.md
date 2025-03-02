# mbcp-220 -- Replace max n spaces commas or dots with a colon

## Text

Write a function to replace maximum n occurrences of spaces, commas, or dots with a colon.

## Code

```csharp
public string ReplaceMaxSpecialChar(string text, int n)
{
    return Regex.Replace(text, "[ ,.]", ":", n);
}
```

## Test List

```csharp
Debug.Assert(ReplaceMaxSpecialChar("Python language, Programming language.", 2) == "Python:language: Programming language.");
```

```csharp
Debug.Assert(ReplaceMaxSpecialChar("a b c,d e f", 3) == "a:b:c:d e f");
```

```csharp
Debug.Assert(ReplaceMaxSpecialChar("ram reshma,ram rahim", 1) == "ram:reshma,ram rahim");
```
