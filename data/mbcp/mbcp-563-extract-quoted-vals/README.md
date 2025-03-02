# mbcp563 -- Extract values from quoted strings in a given text

## Text

Write a function to extract values between quotation marks of a string.

## Code

```csharp
public List<string> ExtractValues(string text)
{
    return Regex.Matches(text, "\"(.*?)\"")
                .Cast<Match>()
                .Select(m => m.Groups[1].Value)
                .ToList();
}
```

## Test List

```csharp
Debug.Assert(ExtractValues("\"Python\", \"PHP\", \"Java\"").SequenceEqual(new List<string> { "Python", "PHP", "Java" }));
```

```csharp
Debug.Assert(ExtractValues("\"python\",\"program\",\"language\"").SequenceEqual(new[] { "python", "program", "language" }));
```

```csharp
Debug.Assert(ExtractValues("\"red\",\"blue\",\"green\",\"yellow\"").SequenceEqual(new List<string> { "red", "blue", "green", "yellow" }));
```
