# mbcp631 -- Replace whitespaces with underscores and vice versa

## Text

Write a function to replace whitespaces with an underscore and vice versa in a given string by using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public class TextProcessor
{
    public string ReplaceSpaces(string text)
    {
        text = text.Replace(" ", "_");
        return text;
    }
}
```

## Test List

```csharp
Debug.Assert(ReplaceSpaces("Jumanji The Jungle") == "Jumanji_The_Jungle");
```

```csharp
Debug.Assert(ReplaceSpaces("The Avengers") == "The_Avengers");
```

```csharp
Debug.Assert(ReplaceSpaces("Fast and Furious") == "Fast_and_Furious");
```
