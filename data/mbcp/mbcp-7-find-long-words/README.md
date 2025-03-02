# mbcp7 -- Find words of 4+ characters using regex

## Text

Write a function to find all words which are at least 4 characters long in a string by using regex.

## Code

```csharp
public List<string> FindCharLong(string text) 
{
    return Regex.Matches(text, @"\b\w{4,}\b")
                .Cast<Match>()
                .Select(match => match.Value)
                .ToList();
}
```

## Test List

```csharp
Debug.Assert(FindCharLong("Please move back to stream").SequenceEqual(new List<string> { "Please", "move", "back", "stream" }));
```

```csharp
Debug.Assert(FindCharLong("Jing Eco and Tech").SequenceEqual(new List<string> { "Jing", "Tech" }));
```

```csharp
Debug.Assert(FindCharLong("Jhingai wulu road Zone 3").SequenceEqual(new List<string> { "Jhingai", "wulu", "road", "Zone" }));
```
