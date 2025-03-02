# mbcp761 -- Calculate arc length from angle and radius

## Text

Write a function to caluclate arc length of an angle.

## Code

```csharp
public static double? ArcLength(double d, double a)
{
    double pi = 22.0 / 7.0;
    if (a >= 360)
    {
        return null;
    }
    double arclength = (pi * d) * (a / 360);
    return arclength;
}
```

## Test List

```csharp
Debug.Assert(ArcLength(9, 45) == 3.5357142857142856);
```

```csharp
Debug.Assert(ArcLength(9, 480) == null);
```

```csharp
Debug.Assert(ArcLength(5, 270) == 11.785714285714285);
```
