# mbcp-199 -- Find highest power of 2 less than or equal to n

## Text

Write a C# function to find highest power of 2 less than or equal to given number.

## Code

```csharp
public int HighestPowerOf2(int n) 
{ 
    int res = 0; 
    for (int i = n; i > 0; i--) 
    { 
        if ((i & (i - 1)) == 0) 
        { 
            res = i; 
            break; 
        } 
    } 
    return res; 
}
```

## Test List

```csharp
Debug.Assert(HighestPowerOf2(10) == 8);
```

```csharp
Debug.Assert(HighestPowerOf2(19) == 16);
```

```csharp
Debug.Assert(HighestPowerOf2(32) == 32);
```
