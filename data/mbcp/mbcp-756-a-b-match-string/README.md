# mbcp756 -- Match a string with an a followed by optional b

## Text

Write a function that matches a string that has an a followed by zero or one 'b'.

## Code

```csharp
public string TextMatchZeroOne(string text) 
{
    string patterns = "ab?";
    if (System.Text.RegularExpressions.Regex.IsMatch(text, patterns)) 
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
Debug.Assert(TextMatchZeroOne("ac") == "Found a match!");
```

```csharp
Debug.Assert(TextMatchZeroOne("dc") == "Not matched!");
```

```csharp
Debug.Assert(TextMatchZeroOne("abbbba") == "Found a match!");
```
