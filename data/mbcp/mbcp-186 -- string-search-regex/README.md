# mbcp-186 -- Search literals in a string using regex function

## Text

Write a function to search some literals strings in a string by using regex.

## Code

```csharp
public string CheckLiterals(string text, List<string> patterns) {
    foreach (var pattern in patterns) {
        if (Regex.IsMatch(text, pattern)) {
            return "Matched!";
        } else {
            return "Not Matched!";
        }
    }
    return "Not Matched!"; // Added a return for case where no patterns are checked
}
```

## Test List

```csharp
Debug.Assert(CheckLiterals("The quick brown fox jumps over the lazy dog.", new string[] { "fox" }) == "Matched!");
```

```csharp
Debug.Assert(CheckLiterals("The quick brown fox jumps over the lazy dog.", new string[] { "horse" }) == "Not Matched!");
```

```csharp
Debug.Assert(CheckLiterals("The quick brown fox jumps over the lazy dog.", new string[] { "lazy" }) == "Matched!");
```
