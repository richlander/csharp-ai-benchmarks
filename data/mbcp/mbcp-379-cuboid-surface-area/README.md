# mbcp379 -- Calculate the surface area of a cuboid

## Text

Write a function to find the surface area of a cuboid.

## Code

```csharp
public int SurfaceAreaCuboid(int l, int w, int h)  
{  
    int SA = 2 * (l * w + l * h + w * h);  
    return SA;  
}
```

## Test List

```csharp
Debug.Assert(SurfaceAreaCuboid(1, 2, 3) == 22);
```

```csharp
Debug.Assert(SurfaceAreaCuboid(5, 7, 9) == 286);
```

```csharp
Debug.Assert(SurfaceAreaCuboid(10, 15, 21) == 1350);
```
