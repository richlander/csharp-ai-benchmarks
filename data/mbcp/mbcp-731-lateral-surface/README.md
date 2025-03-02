# mbcp731 -- Calculate the cone's lateral surface area function

## Text

Write a function to find the lateral surface area of a cone.

## Code

```csharp
public double LateralsurfaceCone(double r, double h)
{
    double l = Math.Sqrt(r * r + h * h);
    double LSA = Math.PI * r * l;
    return LSA;
}
```

## Test List

```csharp
Debug.Assert(LateralsurfaceCone(5, 12) == 204.20352248333654);
```

```csharp
Debug.Assert(LateralsurfaceCone(10, 15) == 566.3586699569488);
```

```csharp
Debug.Assert(LateralsurfaceCone(19, 17) == 1521.8090132193388);
```
