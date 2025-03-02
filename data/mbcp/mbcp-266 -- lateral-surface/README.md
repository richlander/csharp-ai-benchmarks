# mbcp-266 -- Calculate the lateral surface area of a cube

## Text

Write a function to find the lateral surface area of a cube.

## Code

```csharp
public static double LateralSurfaceCube(double l)  
{  
    double LSA = 4 * (l * l);  
    return LSA;  
}
```

## Test List

```csharp
Debug.Assert(LateralSurfaceCube(5) == 100);
```

```csharp
Debug.Assert(LateralSurfaceCube(9) == 324);
```

```csharp
Debug.Assert(LateralSurfaceCube(10) == 400);
```
