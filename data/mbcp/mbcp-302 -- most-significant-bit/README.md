# mbcp-302 -- Find the highest set bit in a number

## Text

Write a C# function to find the most significant bit number which is also a set bit.

## Code

```csharp
public static int SetBitNumber(int n) 
{ 
    if (n == 0) 
    { 
        return 0; 
    } 
    int msb = 0; 
    n /= 2; 
    while (n > 0) 
    { 
        n /= 2; 
        msb++; 
    } 
    return 1 << msb; 
}
```

## Test List

```csharp
Debug.Assert(SetBitNumber(6) == 4);
```

```csharp
Debug.Assert(SetBitNumber(10) == 8);
```

```csharp
Debug.Assert(SetBitNumber(18) == 16);
```
