# mbcp-542 -- Replace spaces commas and dots with colons using regex

## Text

Write a function to replace all occurrences of spaces, commas, or dots with a colon in the given string by using regex.

## Code

```csharp
public string FillSpaces(string text)  
{  
    return Regex.Replace(text, "[ ,.]", ":");  
}
```

## Test List

```csharp
Debug.Assert(FillSpaces("Boult Curve Wireless Neckband") == "Boult:Curve:Wireless:Neckband");
```

```csharp
Debug.Assert(FillSpaces("Stereo Sound Sweatproof") == "Stereo:Sound:Sweatproof");
```

```csharp
Debug.Assert(FillSpaces("Probass Curve Audio") == "Probass:Curve:Audio");
```
