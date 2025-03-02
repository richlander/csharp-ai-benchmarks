# mbcp-535 -- Calculate a cylinder's top or bottom surface area

## Text

Write a function to find the top or bottom surface area of a cylinder.

## Code

```csharp
public static double TopBottomSurfaceArea(double r)  
{  
    double topOrBottomArea = 3.1415 * r * r;  
    return topOrBottomArea;  
}
```

## Test List

```csharp
Debug.Assert(TopBottomSurfaceArea(10) == 314.15000000000003);
```

```csharp
Debug.Assert(TopBottomSurfaceArea(5) == 78.53750000000001);
```

```csharp
Debug.Assert(TopBottomSurfaceArea(4) == 50.264);
```
