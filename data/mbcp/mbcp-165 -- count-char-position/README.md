# mbcp-165 -- Count alphabetic position matches in a string

## Text

Write a C# function to count characters at same position in a given string (lower and uppercase characters) as in english alphabet.

## Code

```csharp
public int CountCharPosition(string str1) 
{ 
    int countChars = 0; 
    for (int i = 0; i < str1.Length; i++) 
    { 
        if ((i == str1[i] - 'A') || (i == str1[i] - 'a')) 
        { 
            countChars++; 
        } 
    } 
    return countChars; 
}
```

## Test List

```csharp
Debug.Assert(CountCharPosition("xbcefg") == 2);
```

```csharp
Debug.Assert(CountCharPosition("ABcED") == 3);
```

```csharp
Debug.Assert(CountCharPosition("AbgdeF") == 5);
```
