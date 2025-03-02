# mbcp-789 -- Calculate the perimeter of a regular polygon

## Text

Write a function to calculate the perimeter of a regular polygon.

## Code

```csharp
public static double PerimeterPolygon(int s, double l) 
{
    double perimeter = s * l;
    return perimeter;
}
```

## Test List

```csharp
Debug.Assert(PerimeterPolygon(4, 20) == 80);
```

```csharp
Debug.Assert(PerimeterPolygon(10, 15) == 150);
```

```csharp
Debug.Assert(PerimeterPolygon(9, 7) == 63);
```
