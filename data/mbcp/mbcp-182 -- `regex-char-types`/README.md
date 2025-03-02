# mbcp-182 -- Regex function to identify character types

## Text

Write a function to find uppercase, lowercase, special character and numeric values using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public (List<string>, List<string>, List<string>, List<string>) FindCharacter(string input)
{
    var uppercaseCharacters = Regex.Matches(input, @"[A-Z]")
        .Cast<Match>()
        .Select(m => m.Value)
        .ToList();
    var lowercaseCharacters = Regex.Matches(input, @"[a-z]")
        .Cast<Match>()
        .Select(m => m.Value)
        .ToList();
    var numericalCharacters = Regex.Matches(input, @"[0-9]")
        .Cast<Match>()
        .Select(m => m.Value)
        .ToList();
    var specialCharacters = Regex.Matches(input, @"[, .!?]")
        .Cast<Match>()
        .Select(m => m.Value)
        .ToList();

    return (uppercaseCharacters, lowercaseCharacters, numericalCharacters, specialCharacters);
}
```

## Test List

```csharp
Debug.Assert(FindCharacter("ThisIsGeeksforGeeks").Equals((new char[] { 'T', 'I', 'G', 'G' }, new char[] { 'h', 'i', 's', 's', 'e', 'e', 'k', 's', 'f', 'o', 'r', 'e', 'e', 'k', 's' }, new char[] { }, new char[] { })));
```

```csharp
Debug.Assert(FindCharacter("Hithere2").Item1.SequenceEqual(new[] {'H'}) && 
              FindCharacter("Hithere2").Item2.SequenceEqual(new[] {'i', 't', 'h', 'e', 'r', 'e'}) && 
              FindCharacter("Hithere2").Item3.SequenceEqual(new[] {'2'}) && 
              FindCharacter("Hithere2").Item4.Count == 0);
```

```csharp
Debug.Assert(FindCharacter("HeyFolks32").Equals((new List<char> { 'H', 'F' }, new List<char> { 'e', 'y', 'o', 'l', 'k', 's' }, new List<char> { '3', '2' }, new List<char> { })));
```
