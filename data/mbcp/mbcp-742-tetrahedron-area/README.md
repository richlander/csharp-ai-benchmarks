# mbcp742 -- Calculate the area of a tetrahedron in Python

## Text

Write a function to caluclate the area of a tetrahedron.

## Code

```csharp
public double AreaTetrahedron(double side) 
{
    double area = Math.Sqrt(3) * (side * side);
    return area;
}
```

## Test List

```csharp
Debug.Assert(AreaTetrahedron(3) == 15.588457268119894);
```

```csharp
Debug.Assert(AreaTetrahedron(20) == 692.8203230275509);
```

```csharp
Debug.Assert(AreaTetrahedron(10) == 173.20508075688772);
```
