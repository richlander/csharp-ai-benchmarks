# mbcp-82 -- Calculate the volume of a sphere given its radius

## Text

Write a function to find the volume of a sphere.

## Code

```csharp
public double VolumeSphere(double r)
{
    double volume = (4.0 / 3.0) * Math.PI * r * r * r;
    return volume;
}
```

## Test List

```csharp
Debug.Assert(VolumeSphere(10) == 4188.790204786391);
```

```csharp
Debug.Assert(VolumeSphere(25) == 65449.84694978735);
```

```csharp
Debug.Assert(VolumeSphere(20) == 33510.32163829113);
```
