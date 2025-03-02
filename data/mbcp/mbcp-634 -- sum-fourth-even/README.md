# mbcp-634 -- Sum of fourth powers of first n even numbers

## Text

Write a C# function to find the sum of fourth power of first n even natural numbers.

## Code

```csharp
public static int EvenPowerSum(int n) 
{ 
    int sum = 0; 
    for (int i = 1; i <= n; i++) 
    { 
        int j = 2 * i; 
        sum += j * j * j * j; 
    } 
    return sum; 
}
```

## Test List

```csharp
Debug.Assert(EvenPowerSum(2) == 272);
```

```csharp
Debug.Assert(EvenPowerSum(3) == 1568);
```

```csharp
Debug.Assert(EvenPowerSum(4) == 5664);
```
