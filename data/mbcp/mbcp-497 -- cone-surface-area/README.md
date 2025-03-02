# mbcp-497 -- Calculate the surface area of a cone function

## Text

Write a function to find the surface area of a cone.

## Code

```csharp
public static double SurfaceAreaCone(double r, double h)  
{  
    double l = Math.Sqrt(r * r + h * h);  
    double SA = Math.PI * r * (r + l);  
    return SA;  
}
```

## Test List

```csharp
Debug.Assert(SurfaceAreaCone(5, 12) == 282.7433388230814);
```

```csharp
Debug.Assert(SurfaceAreaCone(10, 15) == 880.5179353159282);
```

```csharp
Debug.Assert(SurfaceAreaCone(19, 17) == 2655.923961165254);
```
