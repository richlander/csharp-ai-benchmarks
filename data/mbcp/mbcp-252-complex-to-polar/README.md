# mbcp252 -- Convert complex numbers to polar coordinates in Python

## Text

Write a C# function to convert complex numbers to polar coordinates.

## Code

```csharp
using System;
using System.Numerics;

public class Converter
{
    public (double, double) Convert(Complex numbers)
    {
        double magnitude = Complex.Abs(numbers);
        double phase = Complex.Phase(numbers);
        return (magnitude, phase);
    }
}
```

## Test List

```csharp
Debug.Assert(Convert(1) == (1.0, 0.0));
```

```csharp
Debug.Assert(Convert(4) == (4.0, 0.0));
```

```csharp
Debug.Assert(Convert(5) == (5.0, 0.0));
```
