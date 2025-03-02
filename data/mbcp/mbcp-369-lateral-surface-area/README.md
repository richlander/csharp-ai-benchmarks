# mbcp369 -- Calculate lateral surface area of a cuboid

## Text

Write a function to find the lateral surface area of cuboid

## Code

```csharp
public static double LateralsurfaceCuboid(double l, double w, double h) {
    double LSA = 2 * h * (l + w);
    return LSA;
}
```

## Test List

```csharp
Debug.Assert(LateralsurfaceCuboid(8, 5, 6) == 156);
```

```csharp
Debug.Assert(LateralsurfaceCuboid(7, 9, 10) == 320);
```

```csharp
Debug.Assert(LateralsurfaceCuboid(10, 20, 30) == 1800);
```
