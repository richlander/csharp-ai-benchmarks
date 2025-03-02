# mbcp-15 -- Split a string at every lowercase letter

## Text

Write a function to split a string at lowercase letters.

## Code

```csharp
public List<string> SplitLowerString(string text) {
    return Regex.Matches(text, "[a-z][^a-z]*")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();
}
```

## Test List

```csharp
Debug.Assert(SplitLowerString("AbCd").SequenceEqual(new List<string> { "bC", "d" }));
```

```csharp
Debug.Assert(SplitLowerString("Python").SequenceEqual(new[] { 'y', 't', 'h', 'o', 'n' }));
```

```csharp
Debug.Assert(SplitLowerString("Programming").SequenceEqual(new char[] { 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'i', 'n', 'g' }));
```
