# mbcp180 -- Calculate distance between two geographic points

## Text

Write a function to calculate distance between two points using latitude and longitude.

## Code

```csharp
using System;

public class GeoCalculator
{
    public static double DistanceLatLong(double slat, double slon, double elat, double elon)
    {
        return 6371.01 * Math.Acos(Math.Sin(slat) * Math.Sin(elat) + Math.Cos(slat) * Math.Cos(elat) * Math.Cos(slon - elon));
    }
}
```

## Test List

```csharp
Debug.Assert(DistanceLatLong(23.5, 67.5, 25.5, 69.5) == 12179.372041317429);
```

```csharp
Debug.Assert(DistanceLatLong(10.5, 20.5, 30.5, 40.5) == 6069.397933300514);
```

```csharp
Debug.Assert(DistanceLatLong(10, 20, 30, 40) == 6783.751974994595);
```
