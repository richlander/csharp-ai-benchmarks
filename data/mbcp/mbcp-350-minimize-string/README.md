# mbcp350 -- Minimize string length by removing one character

## Text

Write a C# function to minimize the length of the string by removing occurrence of only one character.

## Code

```csharp
public int MinimumLength(string s) 
{ 
    int maxOcc = 0; 
    int n = s.Length; 
    int[] arr = new int[26]; 
    for (int i = 0; i < n; i++) 
    { 
        arr[s[i] - 'a']++; 
    } 
    for (int i = 0; i < 26; i++) 
    { 
        if (arr[i] > maxOcc) 
        { 
            maxOcc = arr[i]; 
        } 
    } 
    return n - maxOcc; 
}
```

## Test List

```csharp
Debug.Assert(MinimumLength("mnm") == 1);
```

```csharp
Debug.Assert(MinimumLength("abcda") == 3);
```

```csharp
Debug.Assert(MinimumLength("abcb") == 2);
```
