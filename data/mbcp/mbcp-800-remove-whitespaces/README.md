# mbcp800 -- Remove all whitespace from a given string

## Text

Write a function to remove all whitespaces from a string.

## Code

```csharp
public string RemoveAllSpaces(string text)
{
    return Regex.Replace(text, @"\s+", "");
}
```

## Test List

```csharp
Debug.Assert(RemoveAllSpaces("python  program") == "pythonprogram");
```

```csharp
Debug.Assert(RemoveAllSpaces("python   programming    language") == "pythonprogramminglanguage");
```

```csharp
Debug.Assert(RemoveAllSpaces("python                     program") == "pythonprogram");
```
