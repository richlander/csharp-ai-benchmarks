# mbcp-655 -- Sum of fifth powers of n natural numbers

## Text

Write a C# function to find the sum of fifth power of n natural numbers.

## Code

```csharp
public int FifthPowerSum(int n) 
{ 
    int sm = 0; 
    for (int i = 1; i <= n; i++) 
    { 
        sm += (i * i * i * i * i); 
    } 
    return sm; 
}
```

## Test List

```csharp
Debug.Assert(FifthPowerSum(2) == 33);
```

```csharp
Debug.Assert(FifthPowerSum(4) == 1300);
```

```csharp
Debug.Assert(FifthPowerSum(3) == 276);
```
