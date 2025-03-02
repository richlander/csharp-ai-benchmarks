# mbcp-91 -- Check if a substring exists in a list of strings

## Text

Write a function to check if a substring is present in a given list of string values.

## Code

```csharp
public bool FindSubstring(string[] str1, string subStr) 
{
    return str1.Any(s => s.Contains(subStr));
}
```

## Test List

```csharp
Debug.Assert(FindSubstring(new string[] { "red", "black", "white", "green", "orange" }, "ack") == true);
```

```csharp
Debug.Assert(FindSubstring(new string[] { "red", "black", "white", "green", "orange" }, "abc") == false);
```

```csharp
Debug.Assert(FindSubstring(new string[] { "red", "black", "white", "green", "orange" }, "ange") == true);
```
