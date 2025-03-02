# mbcp-153 -- Find the vertex of a given parabola function

## Text

Write a function to find the vertex of a parabola.

## Code

```csharp
public (double, double) ParabolaVertex(double a, double b, double c) 
{ 
    var vertex = ((-b / (2 * a)), (((4 * a * c) - (b * b)) / (4 * a))); 
    return vertex; 
}
```

## Test List

```csharp
Debug.Assert(ParabolaVertex(5, 3, 2).Equals((-0.3, 1.55)));
```

```csharp
Debug.Assert(ParabolaVertex(9, 8, 4).Equals((-0.4444444444444444, 2.2222222222222223)));
```

```csharp
Debug.Assert(ParabolaVertex(2, 4, 6).Equals((-1.0, 4.0)));
```
