# mbcp732 -- Replace spaces commas and dots with a colon

## Text

Write a function to replace all occurrences of spaces, commas, or dots with a colon.

## Code

```csharp
public string ReplaceSpecialChar(string text)
{
    return Regex.Replace(text, "[ ,.]", ":");
}
```

## Test List

```csharp
Debug.Assert(ReplaceSpecialChar("Python language, Programming language.") == "Python:language::Programming:language:");
```

```csharp
Debug.Assert(ReplaceSpecialChar("a b c,d e f") == "a:b:c:d:e:f");
```

```csharp
Debug.Assert(ReplaceSpecialChar("ram reshma,ram rahim") == "ram:reshma:ram:rahim");
```
