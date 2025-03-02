# mbcp163 -- Calculate area of a regular polygon using a function

## Text

Write a function to calculate the area of a regular polygon.

## Code

```csharp
public static double AreaPolygon(int s, double l)  
{  
    double area = s * (l * l) / (4 * Math.Tan(Math.PI / s));  
    return area;  
}
```

## Test List

```csharp
Debug.Assert(AreaPolygon(4, 20) == 400.00000000000006);
```

```csharp
Debug.Assert(AreaPolygon(10, 15) == 1731.1969896610804);
```

```csharp
Debug.Assert(AreaPolygon(9, 7) == 302.90938549487214);
```
