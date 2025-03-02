# mbcp-643 -- Match words with 'z' not at the start or end

## Text

Write a function that matches a word containing 'z', not at the start or end of the word.

## Code

```csharp
public string TextMatchWordzMiddle(string text) {
    string patterns = @"\Bz\B";
    if (Regex.IsMatch(text, patterns)) {
        return "Found a match!";
    } else {
        return "Not matched!";
    }
}
```

## Test List

```csharp
Debug.Assert(TextMatchWordzMiddle("pythonzabc.") == "Found a match!");
```

```csharp
Debug.Assert(TextMatchWordzMiddle("xyzabc.") == "Found a match!");
```

```csharp
Debug.Assert(TextMatchWordzMiddle("  lang  .") == "Not matched!");
```
