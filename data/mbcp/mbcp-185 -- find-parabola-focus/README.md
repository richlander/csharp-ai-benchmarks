# mbcp-185 -- Find the focus of a given parabola function

## Text

Write a function to find the focus of a parabola.

## Code

```csharp
public (double, double) ParabolaFocus(double a, double b, double c) 
{
    var focus = (-b / (2 * a), ((4 * a * c) - (b * b) + 1) / (4 * a));
    return focus;
}
```

## Test List

```csharp
Debug.Assert(ParabolaFocus(5, 3, 2).Item1 == -0.3 && ParabolaFocus(5, 3, 2).Item2 == 1.6);
```

```csharp
Debug.Assert(ParabolaFocus(9, 8, 4).Equals((-0.4444444444444444, 2.25)));
```

```csharp
Debug.Assert(ParabolaFocus(2, 4, 6).Equals((-1.0, 4.125)));
```
