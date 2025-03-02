# mbcp167 -- Find smallest power of 2 greater than n

## Text

Write a C# function to find smallest power of 2 greater than or equal to n.

## Code

```csharp
public static int NextPowerOf2(int n) 
{ 
    int count = 0; 
    if (n != 0 && (n & (n - 1)) == 0) 
    { 
        return n; 
    } 
    while (n != 0) 
    { 
        n >>= 1; 
        count++; 
    } 
    return 1 << count; 
}
```

## Test List

```csharp
Debug.Assert(NextPowerOf2(0) == 1);
```

```csharp
Debug.Assert(NextPowerOf2(5) == 8);
```

```csharp
Debug.Assert(NextPowerOf2(17) == 32);
```
