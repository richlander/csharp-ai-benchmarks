# mbcp-109 -- Count rotations of an odd binary string value

## Text

Write a C# function to find the count of rotations of a binary string with odd value.

## Code

```csharp
public int OddEquivalent(string s, int n) 
{ 
    int count = 0; 
    for (int i = 0; i < n; i++) 
    { 
        if (s[i] == '1') 
        { 
            count++; 
        } 
    } 
    return count; 
}
```

## Test List

```csharp
Debug.Assert(OddEquivalent("011001", 6) == 3);
```

```csharp
Debug.Assert(OddEquivalent("11011", 5) == 4);
```

```csharp
Debug.Assert(OddEquivalent("1010", 4) == 2);
```
