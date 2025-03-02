# mbcp-930 -- Match a string with an a followed by b's using regex

## Text

Write a function that matches a string that has an a followed by zero or more b's by using regex.

## Code

```csharp
public string TextMatch(string text)  
{  
    string patterns = "ab*?";  
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
Debug.Assert(TextMatch("msb") == "Not matched!");
```

```csharp
Debug.Assert(TextMatch("a0c") == "Found a match!");
```

```csharp
Debug.Assert(TextMatch("abbc") == "Found a match!");
```
