# mbcp735 -- Toggle inner bits of a number in Python function

## Text

Write a C# function to toggle bits of the number except the first and the last bit.

## Code

```csharp
public int SetMiddleBits(int n)  
{  
    n |= n >> 1;  
    n |= n >> 2;  
    n |= n >> 4;  
    n |= n >> 8;  
    n |= n >> 16;  
    return (n >> 1) ^ 1;  
}  

public int ToggleMiddleBits(int n)  
{  
    if (n == 1)  
    {  
        return 1;  
    }  
    return n ^ SetMiddleBits(n);  
}
```

## Test List

```csharp
Debug.Assert(ToggleMiddleBits(9) == 15);
```

```csharp
Debug.Assert(ToggleMiddleBits(10) == 12);
```

```csharp
Debug.Assert(ToggleMiddleBits(11) == 13);
```
