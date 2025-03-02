# mbcp454 -- Function to find words with the letter z

## Text

Write a function that matches a word containing 'z'.

## Code

```csharp
public string TextMatchWordz(string text)  
{  
    string patterns = @"\w*z.\w*";  
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
Debug.Assert(TextMatchWordz("pythonz.") == "Found a match!");
```

```csharp
Debug.Assert(TextMatchWordz("xyz.") == "Found a match!");
```

```csharp
Debug.Assert(TextMatchWordz("  lang  .") == "Not matched!");
```
