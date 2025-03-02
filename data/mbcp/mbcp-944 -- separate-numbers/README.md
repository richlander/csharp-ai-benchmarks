# mbcp-944 -- Separate numbers from a string with their positions

## Text

Write a function to separate and print the numbers and their position of a given string.

## Code

```csharp
public int NumPosition(string text) {
    var match = Regex.Match(text, @"\d+");
    return match.Success ? match.Index : -1;
}
```

## Test List

```csharp
Debug.Assert(NumPosition("there are 70 flats in this apartment") == 10);
```

```csharp
Debug.Assert(NumPosition("every adult have 32 teeth") == 17);
```

```csharp
Debug.Assert(NumPosition("isha has 79 chocolates in her bag") == 9);
```
