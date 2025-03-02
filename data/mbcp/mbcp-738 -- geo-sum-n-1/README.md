# mbcp-738 -- Compute geometric sum for n minus one

## Text

Write a function to calculate the geometric sum of n-1.

## Code

```csharp
public double GeometricSum(int n)
{
    if (n < 0)
    {
        return 0;
    }
    else
    {
        return 1.0 / Math.Pow(2, n) + GeometricSum(n - 1);
    }
}
```

## Test List

```csharp
Debug.Assert(GeometricSum(7) == 1.9921875);
```

```csharp
Debug.Assert(GeometricSum(4) == 1.9375);
```

```csharp
Debug.Assert(GeometricSum(8) == 1.99609375);
```
