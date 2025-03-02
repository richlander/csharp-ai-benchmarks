# mbcp198 -- Find largest triangle in an ellipse

## Text

Write a function to find the largest triangle that can be inscribed in an ellipse.

## Code

```csharp
public double LargestTriangle(double a, double b) 
{ 
    if (a < 0 || b < 0) 
    { 
        return -1; 
    } 
    double area = (3 * Math.Sqrt(3) * Math.Pow(a, 2)) / (4 * b);  
    return area; 
}
```

## Test List

```csharp
Debug.Assert(LargestTriangle(4, 2) == 10.392304845413264);
```

```csharp
Debug.Assert(LargestTriangle(5, 7) == 4.639421805988064);
```

```csharp
Debug.Assert(LargestTriangle(9, 1) == 105.2220865598093);
```
