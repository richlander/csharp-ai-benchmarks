# mbcp16 -- Find sequences of lowercase letters with underscores

## Text

Write a function to find sequences of lowercase letters joined with an underscore.

## Code

```csharp
public string TextLowercaseUnderscore(string text)  
{  
    string patterns = "^[a-z]+_[a-z]+$";  
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
Debug.Assert(TextLowercaseUnderscore("aab_cbbbc") == "Found a match!");
```

```csharp
Debug.Assert(TextLowercaseUnderscore("aab_Abbbc") == "Not matched!");
```

```csharp
Debug.Assert(TextLowercaseUnderscore("Aaab_abbbc") == "Not matched!");
```
