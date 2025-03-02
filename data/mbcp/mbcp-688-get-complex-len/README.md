# mbcp688 -- Calculate the magnitude of a complex number

## Text

Write a function to get the length of a complex number.

## Code

```csharp
using System;
using System.Numerics;

public class ComplexOperations
{
    public static double LenComplex(double a, double b)
    {
        Complex cn = new Complex(a, b);
        double length = cn.Magnitude;
        return length;
    }
}
```

## Test List

```csharp
Debug.Assert(LenComplex(3, 4) == 5.0);
```

```csharp
Debug.Assert(LenComplex(9, 10) == 13.45362404707371);
```

```csharp
Debug.Assert(LenComplex(7, 9) == 11.40175425099138);
```
