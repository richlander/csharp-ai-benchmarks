# mbcp406 -- Determine if a number is odd or even

## Text

Write a C# function to find the parity of a given number.

## Code

```csharp
public string FindParity(int x) 
{ 
    int y = x ^ (x >> 1); 
    y = y ^ (y >> 2); 
    y = y ^ (y >> 4); 
    y = y ^ (y >> 8); 
    y = y ^ (y >> 16); 
    if ((y & 1) != 0) 
    { 
        return "Odd Parity"; 
    } 
    return "Even Parity"; 
}
```

## Test List

```csharp
Debug.Assert(FindParity(12) == "Even Parity");
```

```csharp
Debug.Assert(FindParity(7) == "Odd Parity");
```

```csharp
Debug.Assert(FindParity(10) == "Even Parity");
```
