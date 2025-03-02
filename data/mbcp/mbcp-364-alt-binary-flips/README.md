# mbcp364 -- Count flips to alternate characters in a binary string

## Text

Write a function to find the number of flips required to make the given binary string a sequence of alternate characters.

## Code

```csharp
public string MakeFlip(char ch) 
{
    return ch == '0' ? "1" : "0";
}

public int GetFlipWithStartingCharacter(string str, char expected) 
{
    int flipCount = 0;
    for (int i = 0; i < str.Length; i++) 
    {
        if (str[i] != expected) 
        {
            flipCount++;
        }
        expected = MakeFlip(expected);
    }
    return flipCount;
}

public int MinFlipToMakeStringAlternate(string str) 
{
    return Math.Min(GetFlipWithStartingCharacter(str, '0'), GetFlipWithStartingCharacter(str, '1'));
}
```

## Test List

```csharp
Debug.Assert(MinFlipToMakeStringAlternate("0001010111") == 2);
```

```csharp
Debug.Assert(MinFlipToMakeStringAlternate("001") == 1);
```

```csharp
Debug.Assert(MinFlipToMakeStringAlternate("010111011") == 2);
```
