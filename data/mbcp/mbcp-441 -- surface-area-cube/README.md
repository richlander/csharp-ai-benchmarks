# mbcp-441 -- Calculate the surface area of a cube

## Text

Write a function to find the surface area of a cube.

## Code

```csharp
public static double SurfaceAreaCube(double l)
{
    double surfaceArea = 6 * l * l;
    return surfaceArea;
}
```

## Test List

```csharp
Debug.Assert(SurfaceAreaCube(5) == 150);
```

```csharp
Debug.Assert(SurfaceAreaCube(3) == 54);
```

```csharp
Debug.Assert(SurfaceAreaCube(10) == 600);
```
