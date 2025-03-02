# mbcp905 -- Sum of squares of binomial coefficients in Python

## Text

Write a C# function to find the sum of squares of binomial co-efficients.

## Code

```csharp
public static int Factorial(int start, int end) 
{ 
    int res = 1; 
    for (int i = start; i <= end; i++) 
    { 
        res *= i; 
    } 
    return res; 
} 

public static int SumOfSquare(int n) 
{ 
    return (int)(Factorial(n + 1, 2 * n) / Factorial(1, n)); 
}
```

## Test List

```csharp
Debug.Assert(SumOfSquare(4) == 70);
```

```csharp
Debug.Assert(SumOfSquare(5) == 252);
```

```csharp
Debug.Assert(SumOfSquare(2) == 6);
```
