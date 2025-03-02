# mbcp-794 -- Match string with 'a' start and 'b' end

## Text

Write a function that matches a string that has an 'a' followed by anything, ending in 'b'.

## Code

```csharp
public string TextStartaEndb(string text)
{
    string patterns = @"a.*?b$";
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
Debug.Assert(TextStartaEndb("aabbbb") == "Found a match!");
```

```csharp
Debug.Assert(TextStartaEndb("aabAbbbc") == "Not matched!");
```

```csharp
Debug.Assert(text_starta_endb("accddbbjjj") == "Not matched!");
```
