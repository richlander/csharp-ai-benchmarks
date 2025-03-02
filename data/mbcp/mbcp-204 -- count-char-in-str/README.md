# mbcp-204 -- Count character occurrences in a string using Python

## Text

Write a C# function to count the occurrence of a given character in a string.

## Code

```csharp
public int Count(string s, char c) 
{ 
    int res = 0; 
    for (int i = 0; i < s.Length; i++) 
    { 
        if (s[i] == c) 
        { 
            res++; 
        } 
    } 
    return res; 
}
```

## Test List

```csharp
Debug.Assert(Count("abcc", "c") == 2);
```

```csharp
Debug.Assert(Count("ababca", "a") == 3);
```

```csharp
Debug.Assert(Count("mnmm0pm", "m") == 4);
```
