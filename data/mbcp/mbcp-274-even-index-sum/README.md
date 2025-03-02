# mbcp274 -- Find sum of even index binomial coefficients

## Text

Write a C# function to find sum of even index binomial coefficients.

## Code

```csharp
public static long EvenBinomialCoeffSum(int n) 
{
    return (1L << (n - 1));
}
```

## Test List

```csharp
Debug.Assert(EvenBinomialCoeffSum(4) == 8);
```

```csharp
Debug.Assert(EvenBinomialCoeffSum(6) == 32);
```

```csharp
Debug.Assert(EvenBinomialCoeffSum(2) == 2);
```
