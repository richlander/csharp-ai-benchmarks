# mbcp238 -- Count non-empty substrings in a given string

## Text

Write a C# function to count number of non-empty substrings of a given string.

## Code

```csharp
public int NumberOfSubstrings(string str) 
{ 
    int strLen = str.Length; 
    return (int)(strLen * (strLen + 1) / 2); 
}
```

## Test List

```csharp
Debug.Assert(NumberOfSubstrings("abc") == 6);
```

```csharp
Debug.Assert(NumberOfSubstrings("abcd") == 10);
```

```csharp
Debug.Assert(NumberOfSubstrings("abcde") == 15);
```
