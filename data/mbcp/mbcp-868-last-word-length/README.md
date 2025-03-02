# mbcp868 -- Find the length of the last word in a string

## Text

Write a C# function to find the length of the last word in a given string.

## Code

```csharp
public int LengthOfLastWord(string a) 
{ 
    int l = 0; 
    string x = a.Trim(); 
    for (int i = 0; i < x.Length; i++) 
    { 
        if (x[i] == ' ') 
        { 
            l = 0; 
        } 
        else 
        { 
            l++; 
        } 
    } 
    return l; 
}
```

## Test List

```csharp
Debug.Assert(LengthOfLastWord("python language") == 8);
```

```csharp
Debug.Assert(LengthOfLastWord("PHP") == 3);
```

```csharp
Debug.Assert(LengthOfLastWord("") == 0);
```
