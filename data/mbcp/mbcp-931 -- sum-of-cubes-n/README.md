# mbcp-931 -- Calculate the sum of cubes from 1 to n

## Text

Write a function to calculate the sum of series 1³+2³+3³+….+n³.

## Code

```csharp
public double SumSeries(double number)
{
    double total = 0;
    total = Math.Pow((number * (number + 1)) / 2, 2);
    return total;
}
```

## Test List

```csharp
Debug.Assert(SumSeries(7) == 784);
```

```csharp
Debug.Assert(SumSeries(5) == 225);
```

```csharp
Debug.Assert(SumSeries(15) == 14400);
```
