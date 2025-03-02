# mbcp124 -- Get the angle of a complex number using a function

## Text

Write a function to get the angle of a complex number.

## Code

```csharp
public static double AngleComplex(double a, double b)
{
    complex cn = new complex(a, b);
    double angle = Math.Atan2(b, a);
    return angle;
}
```

## Test List

```csharp
Debug.Assert(AngleComplex(0, new Complex(0, 1)) == 1.5707963267948966);
```

```csharp
Debug.Assert(AngleComplex(2, new Complex(0, 1)) == 0.4636476090008061);
```

```csharp
Debug.Assert(AngleComplex(0, new Complex(0, 2)) == 1.5707963267948966);
```
