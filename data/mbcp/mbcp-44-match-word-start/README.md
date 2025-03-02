# mbcp44 -- Match a word at the start of a string

## Text

Write a function that matches a word at the beginning of a string.

## Code

```csharp
public string TextMatchString(string text) 
{
    string patterns = @"^\w+";
    if (Regex.IsMatch(text, patterns)) 
    {
        return "Found a match!";
    } 
    else 
    {
        return "Not matched!";
    }
}
```

## Test List

```csharp
Debug.Assert(TextMatchString("python") == "Not matched!");
```

```csharp
Debug.Assert(TextMatchString("python") == "Found a match!");
```

```csharp
Debug.Assert(TextMatchString("  lang") == "Not matched!");
```
