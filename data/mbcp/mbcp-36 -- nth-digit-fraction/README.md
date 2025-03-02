# mbcp-36 -- Find the nth digit in a proper fraction

## Text

Write a C# function to find the nth digit in the proper fraction of two given numbers.

## Code

```csharp
public int FindNthDigit(int p, int q, int N) 
{  
    while (N > 0) 
    { 
        N -= 1;  
        p *= 10;  
        int res = p / q;  
        p %= q;  
    } 
    return res;  
}
```

## Test List

```csharp
Debug.Assert(FindNthDigit(1, 2, 1) == 5);
```

```csharp
Debug.Assert(FindNthDigit(3, 5, 1) == 6);
```

```csharp
Debug.Assert(FindNthDigit(5, 6, 5) == 3);
```
