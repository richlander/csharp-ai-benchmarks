# mbcp337 -- Match a word at the end of a string with punctuation

## Text

Write a function that matches a word at the end of a string, with optional punctuation.

## Code

```csharp
public string TextMatchWord(string text)
{
    string patterns = @"\w+\S*$";
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
Debug.Assert(TextMatchWord("python.") == "Found a match!");
```

```csharp
Debug.Assert(TextMatchWord("python.") == "Found a match!");
```

```csharp
Debug.Assert(TextMatchWord("  lang  .") == "Not matched!");
```
