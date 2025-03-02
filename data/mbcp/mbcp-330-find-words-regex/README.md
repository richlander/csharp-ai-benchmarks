# mbcp330 -- Find words of 3 to 5 letters in a string

## Text

Write a function to find all three, four, five characters long words in the given string by using regex.

## Code

```csharp
public List<string> FindChar(string text) {
    return Regex.Matches(text, @"\b\w{3,5}\b")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();
}
```

## Test List

```csharp
Debug.Assert(FindChar("For the four consumer complaints contact manager AKR reddy").SequenceEqual(new List<string> { "For", "the", "four", "AKR", "reddy" }));
```

```csharp
Debug.Assert(FindChar("Certain service are subject to change MSR").SequenceEqual(new List<string> { "are", "MSR" }));
```

```csharp
Debug.Assert(FindChar("Third party legal desclaimers").SequenceEqual(new List<string> { "Third", "party", "legal" }));
```
