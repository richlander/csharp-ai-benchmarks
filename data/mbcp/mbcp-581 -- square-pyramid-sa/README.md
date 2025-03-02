# mbcp-581 -- Calculate surface area of a square pyramid

## Text

Write a C# function to find the surface area of the square pyramid.

## Code

```csharp
public static double SurfaceArea(double b, double s) 
{ 
    return 2 * b * s + Math.Pow(b, 2); 
}
```

## Test List

```csharp
Debug.Assert(SurfaceArea(3, 4) == 33);
```

```csharp
Debug.Assert(SurfaceArea(4, 5) == 56);
```

```csharp
Debug.Assert(SurfaceArea(1, 2) == 5);
```
