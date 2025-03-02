# mbcp-746 -- Calculate the area of a circular sector

## Text

Write a function to find area of a sector.

## Code

```csharp
public static double? SectorArea(double r, double a)
{
    double pi = 22.0 / 7.0;
    if (a >= 360)
    {
        return null;
    }
    double sectorArea = (pi * r * r) * (a / 360);
    return sectorArea;
}
```

## Test List

```csharp
Debug.Assert(SectorArea(4, 45) == 6.285714285714286);
```

```csharp
Debug.Assert(SectorArea(9, 45) == 31.82142857142857);

double SectorArea(double radius, double angle)
{
    return (Math.PI * radius * radius * angle) / 360.0;
}
```

```csharp
Debug.Assert(SectorArea(9, 360) == null);
```
