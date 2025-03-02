# mbcp-43 -- Find lowercase letter sequences with regex

## Text

Write a function to find sequences of lowercase letters joined with an underscore using regex.

## Code

```csharp
public string TextMatch(string text)  
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
Debug.Assert(TextMatch("aab_cbbbc") == "Found a match!");

string TextMatch(string input) {
    // Your previous implementation here
}
```

```csharp
Debug.Assert(TextMatch("aab_Abbbc") == "Not matched!");
```

```csharp
Debug.Assert(TextMatch("Aaab_abbbc") == "Not matched!");
```
