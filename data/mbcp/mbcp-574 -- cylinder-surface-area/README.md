# mbcp-574 -- Calculate the surface area of a cylinder

## Text

Write a function to find the surface area of a cylinder.

## Code

```csharp
public double SurfaceAreaCylinder(double r, double h)
{
    double surfaceArea = (2 * 3.1415 * r * r) + (2 * 3.1415 * r * h);
    return surfaceArea;
}
```

## Test List

```csharp
Debug.Assert(SurfaceAreaCylinder(10, 5) == 942.45);
```

```csharp
Debug.Assert(SurfaceAreaCylinder(4, 5) == 226.18800000000002);
```

```csharp
Debug.Assert(SurfaceAreaCylinder(4, 10) == 351.848);
```
