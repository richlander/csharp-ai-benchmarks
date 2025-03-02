# mbcp-233 -- Calculate the lateral surface area of a cylinder

## Text

Write a function to find the lateral surface area of a cylinder.

## Code

```csharp
public double LateralsufaceCylinder(double r, double h) {
    double lateralsurface = 2 * 3.1415 * r * h;
    return lateralsurface;
}
```

## Test List

```csharp
Debug.Assert(LateralsufaceCylinder(10, 5) == 314.15000000000003);
```

```csharp
Debug.Assert(LateralsufaceCylinder(4, 5) == 125.66000000000001);
```

```csharp
Debug.Assert(LateralsufaceCylinder(4, 10) == 251.32000000000002);
```
