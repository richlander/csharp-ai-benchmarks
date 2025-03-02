# mbcp676 -- Remove non-alphanumeric characters using regex

## Text

Write a function to remove everything except alphanumeric characters from the given string by using regex.

## Code

```csharp
public string RemoveExtraChar(string text1) {
    var pattern = new Regex(@"[\W_]+");
    return pattern.Replace(text1, "");
}
```

## Test List

```csharp
Debug.Assert(RemoveExtraChar("**//Google Android// - 12. ") == "GoogleAndroid12");
```

```csharp
Debug.Assert(RemoveExtraChar("****//Google Flutter//*** - 36. ") == "GoogleFlutter36");
```

```csharp
Debug.Assert(RemoveExtraChar("**//Google Firebase// - 478. ") == "GoogleFirebase478");
```
