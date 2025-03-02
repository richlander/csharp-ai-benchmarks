# mbcp217 -- Find the first repeated character in a string

## Text

Write a C# function to find the first repeated character in a given string.

## Code

```csharp
public char FirstRepeatedChar(string str) 
{ 
    Dictionary<char, int> h = new Dictionary<char, int>(); 
    foreach (char ch in str) 
    { 
        if (h.ContainsKey(ch)) 
        { 
            return ch; 
        } 
        else 
        { 
            h[ch] = 0; 
        } 
    } 
    return '\0'; 
}
```

## Test List

```csharp
Debug.Assert(FirstRepeatedChar("Google") == "o");
```

```csharp
Debug.Assert(FirstRepeatedChar("data") == "a");
```

```csharp
Debug.Assert(FirstRepeatedChar("python") == '\0');
```
