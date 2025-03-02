# mbcp-246 -- Compute square roots with Babylonian method

## Text

Write a function for computing square roots using the babylonian method.

## Code

```csharp
public static double BabylonianSquareroot(double number)
{
    if (number == 0)
    {
        return 0;
    }
    double g = number / 2.0;
    double g2 = g + 1;
    while (g != g2)
    {
        double n = number / g;
        g2 = g;
        g = (g + n) / 2;
    }
    return g;
}
```

## Test List

```csharp
Debug.Assert(BabylonianSquareroot(10) == 3.162277660168379);
```

```csharp
Debug.Assert(BabylonianSquareroot(2) == 1.414213562373095);
```

```csharp
Debug.Assert(BabylonianSquareroot(9) == 3.0);
```
