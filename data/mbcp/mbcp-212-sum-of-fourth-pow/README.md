# mbcp212 -- Sum of fourth powers of n natural numbers

## Text

Write a C# function to find the sum of fourth power of n natural numbers.

## Code

```csharp
public int FourthPowerSum(int n) 
{ 
    int sum = 0; 
    for (int i = 1; i <= n; i++) 
    { 
        sum += (i * i * i * i); 
    } 
    return sum; 
}
```

## Test List

```csharp
Debug.Assert(FourthPowerSum(2) == 17);
```

```csharp
Debug.Assert(FourthPowerSum(4) == 354);
```

```csharp
Debug.Assert(FourthPowerSum(6) == 2275);
```
