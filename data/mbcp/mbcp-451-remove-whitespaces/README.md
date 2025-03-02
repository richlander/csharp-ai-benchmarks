# mbcp451 -- Remove all whitespaces from a string using regex

## Text

Write a function to remove all whitespaces from the given string using regex.

## Code

```csharp
public string RemoveWhitespaces(string text1) 
{
    return Regex.Replace(text1, @"\s+", "");
}
```

## Test List

```csharp
Debug.Assert(RemoveWhitespaces(" Google    Flutter ") == "GoogleFlutter");
```

```csharp
Debug.Assert(RemoveWhitespaces(" Google    Dart ") == "GoogleDart");
```

```csharp
Debug.Assert(RemoveWhitespaces(" iOS    Swift ") == "iOSSwift");
```
