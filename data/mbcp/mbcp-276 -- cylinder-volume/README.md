# mbcp-276 -- Calculate the volume of a cylinder given dimensions

## Text

Write a function to find the volume of a cylinder.

## Code

```csharp
public double VolumeCylinder(double r, double h)
{
    double volume = 3.1415 * r * r * h;
    return volume;
}
```

## Test List

```csharp
Debug.Assert(VolumeCylinder(10, 5) == 1570.7500000000002);
```

```csharp
Debug.Assert(VolumeCylinder(4, 5) == 251.32000000000002);
```

```csharp
Debug.Assert(VolumeCylinder(4, 10) == 502.64000000000004);
```
