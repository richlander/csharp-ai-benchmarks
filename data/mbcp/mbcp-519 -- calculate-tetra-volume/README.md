# mbcp-519 -- Calculate the volume of a tetrahedron with a function

## Text

Write a function to calculate volume of a tetrahedron.

## Code

```csharp
public double VolumeTetrahedron(double num) {
    double volume = (Math.Pow(num, 3) / (6 * Math.Sqrt(2)));
    return Math.Round(volume, 2);
}
```

## Test List

```csharp
Debug.Assert(VolumeTetrahedron(10) == 117.85);
```

```csharp
Debug.Assert(VolumeTetrahedron(15) == 397.75);
```

```csharp
Debug.Assert(VolumeTetrahedron(20) == 942.81);
```
