# mbcp-681 -- Find the smallest prime divisor of a number

## Text

Write a C# function to find the smallest prime divisor of a number.

## Code

```csharp
public static int SmallestDivisor(int n) 
{ 
    if (n % 2 == 0) 
    { 
        return 2; 
    } 
    int i = 3; 
    while (i * i <= n) 
    { 
        if (n % i == 0) 
        { 
            return i; 
        } 
        i += 2; 
    } 
    return n; 
}
```

## Test List

```csharp
Debug.Assert(SmallestDivisor(10) == 2);
```

```csharp
Debug.Assert(SmallestDivisor(25) == 5);
```

```csharp
Debug.Assert(SmallestDivisor(31) == 31);
```
