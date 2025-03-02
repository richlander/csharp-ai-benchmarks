# mbcp719 -- Match a string with an a followed by b's

## Text

Write a function that matches a string that has an a followed by zero or more b's.

## Code

```csharp
public string TextMatch(string text) {
    string patterns = "ab*?";
    if (Regex.IsMatch(text, patterns)) {
        return "Found a match!";
    } else {
        return "Not matched!";
    }
}
```

## Test List

```csharp
Debug.Assert(TextMatch("ac") == "Found a match!");
```

```csharp
Debug.Assert(TextMatch("dc") == "Not matched!");

string TextMatch(string input) {
    // implementation of the function would go here
}
```

```csharp
Debug.Assert(TextMatch("abba") == "Found a match!");
```
