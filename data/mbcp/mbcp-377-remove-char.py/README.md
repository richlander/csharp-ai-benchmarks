# mbcp377 -- Remove all instances of a character from a string

## Text

Write a C# function to remove all occurrences of a character in a given string.

## Code

```csharp
public string RemoveChar(string s, char c)  
{  
    int counts = s.Count(x => x == c);  
    s = s.ToList();  
    while (counts > 0)  
    {  
        s.Remove(c);  
        counts--;  
    }  
    return string.Join("", s);  
}
```

## Test List

```csharp
Debug.Assert(RemoveChar("aba", 'a') == "b");
```

```csharp
Debug.Assert(RemoveChar("toggle", 'g') == "tole");
```

```csharp
Debug.Assert(RemoveChar("aabbc", 'b') == "aac");
```
