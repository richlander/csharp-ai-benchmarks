# mbcp590 -- Convert polar to rectangular coordinates function

## Text

Write a function to convert polar coordinates to rectangular coordinates.

## Code

```csharp
using System;
using System.Numerics;

public class Converter
{
    public Tuple<(double, double), Complex> PolarRect(double x, double y)
    {
        Complex cn = new Complex(x, y);
        var polar = Complex polar = Complex.Add(new Complex(cn.Magnitude, cn.Phase));
        Complex cn1 = Complex.FromPolarCoordinates(2, Math.PI);
        return Tuple.Create((polar.Real, polar.Imaginary), cn1);
    }
}
```

## Test List

```csharp
Debug.Assert(PolarRect(3, 4).Item1 == (5.0, 0.9272952180016122) && PolarRect(3, 4).Item2 == new Complex(-2, 2.4492935982947064e-16));
```

```csharp
Debug.Assert(PolarRect(4, 7).Item1 == (8.06225774829855, 1.0516502125483738) && PolarRect(4, 7).Item2 == (-2 + 2.4492935982947064e-16j));
```

```csharp
Debug.Assert(PolarRect(15, 17).Item1 == (22.67156809750927, 0.8478169733934057) && PolarRect(15, 17).Item2 == new Complex(-2, 2.4492935982947064e-16));
```
