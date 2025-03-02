# mbcp491 -- Calculate the sum of a geometric series

## Text

Write a function to find the sum of geometric progression series.

## Code

```csharp
public static double SumGp(double a, int n, double r)
{
    double total = (a * (1 - Math.Pow(r, n))) / (1 - r);
    return total;
}
```

## Test List

```csharp
Debug.Assert(SumGp(1, 5, 2) == 31);
```

```csharp
Debug.Assert(SumGp(1, 5, 4) == 341);
```

```csharp
Debug.Assert(SumGp(2, 6, 3) == 728);
```
