# mbcp-73 -- Split a string by multiple delimiters using regex

## Text

Write a function to split the given string with multiple delimiters by using regex.

## Code

```csharp
public List<string> MultipleSplit(string text) 
{
    return Regex.Split(text, "; |, |\\*|\\n").ToList();
}
```

## Test List

```csharp
Debug.Assert(MultipleSplit("Forces of the \ndarkness*are coming into the play.") == new List<string> { "Forces of the ", "darkness", "are coming into the play." });
```

```csharp
Debug.Assert(MultipleSplit("Mi Box runs on the \n Latest android*which has google assistance and chromecast.") == new List<string> { "Mi Box runs on the ", " Latest android", "which has google assistance and chromecast." });
```

```csharp
Debug.Assert(MultipleSplit("Certain services\nare subjected to change*over the seperate subscriptions.") == new List<string> { "Certain services", "are subjected to change", "over the seperate subscriptions." });
```
