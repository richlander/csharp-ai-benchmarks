# mbcp271 -- Sum fifth powers of first n even numbers

## Text

Write a C# function to find the sum of fifth power of first n even natural numbers.

## Code

```csharp
public static int EvenPowerSum(int n) 
{ 
    int sum = 0; 
    for (int i = 1; i <= n; i++) 
    { 
        int j = 2 * i; 
        sum += (j * j * j * j * j); 
    } 
    return sum; 
}
```

## Test List

```csharp
Debug.Assert(EvenPowerSum(2) == 1056);
```

```csharp
Debug.Assert(EvenPowerSum(3) == 8832);
```

```csharp
Debug.Assert(EvenPowerSum(1) == 32);
```
