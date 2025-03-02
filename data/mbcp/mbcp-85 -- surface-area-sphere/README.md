# mbcp-85 -- Calculate the surface area of a sphere

## Text

Write a function to find the surface area of a sphere.

## Code

```csharp
public static double SurfaceAreaSphere(double r)
{
    double surfaceArea = 4 * Math.PI * r * r;
    return surfaceArea;
}
```

## Test List

```csharp
Debug.Assert(SurfaceAreaSphere(10) == 1256.6370614359173);
```

```csharp
Debug.Assert(SurfaceAreaSphere(15) == 2827.4333882308138);
```

```csharp
Debug.Assert(SurfaceAreaSphere(20) == 5026.548245743669);
```
