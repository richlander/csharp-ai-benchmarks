# mbcp668 -- Replace multiple characters with a single one

## Text

Write a C# function to replace multiple occurence of character by single.

## Code

```csharp
using System.Text.RegularExpressions;

public string Replace(string input, string character) 
{
    string pattern = character + "{2,}";
    string result = Regex.Replace(input, pattern, character);
    return result;
}
```

## Test List

```csharp
Debug.Assert(Replace("peep", 'e') == "pep");
```

```csharp
Debug.Assert(Replace("Greek", 'e') == "Grek");
```

```csharp
Debug.Assert(Replace("Moon", 'o') == "Mon");
```
