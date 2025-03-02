# mbcp-830 -- Round a number up to the specified decimal places

## Text

Write a function to round up a number to specific digits.

## Code

```csharp
public static double RoundUp(double a, int digits)
{
    double n = Math.Pow(10, -digits);
    return Math.Round(Math.Ceiling(a / n) * n, digits);
}
```

## Test List

```csharp
Debug.Assert(RoundUp(123.01247, 0) == 124);

public static int RoundUp(double value, int decimals)
{
    double factor = Math.Pow(10, decimals);
    return (int)Math.Ceiling(value * factor) / (int)factor;
}
```

```csharp
Debug.Assert(RoundUp(123.01247, 1) == 123.1);

double RoundUp(double value, int decimalPlaces)
{
    double factor = Math.Pow(10, decimalPlaces);
    return Math.Ceiling(value * factor) / factor;
}
```

```csharp
Debug.Assert(RoundUp(123.01247, 2) == 123.02);

public static double RoundUp(double value, int digits)
{
    double multiplier = Math.Pow(10, digits);
    return Math.Ceiling(value * multiplier) / multiplier;
}
```
