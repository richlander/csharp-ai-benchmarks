# mbcp-311 -- Set the leftmost unset bit in a binary number

## Text

Write a C# function to set the left most unset bit.

## Code

```csharp
public static int SetLeftMostUnsetBit(int n) 
{ 
    if ((n & (n + 1)) == 0) 
    { 
        return n; 
    } 
    int pos = 0, temp = n, count = 0; 
    while (temp != 0) 
    { 
        if ((temp & 1) == 0) 
        { 
            pos = count; 
        } 
        count++; 
        temp >>= 1; 
    } 
    return (n | (1 << pos)); 
}
```

## Test List

```csharp
Debug.Assert(SetLeftMostUnsetBit(10) == 14);
```

```csharp
Debug.Assert(SetLeftMostUnsetBit(12) == 14);
```

```csharp
Debug.Assert(SetLeftMostUnsetBit(15) == 15);
```
