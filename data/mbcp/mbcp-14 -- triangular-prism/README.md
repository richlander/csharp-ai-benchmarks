# mbcp-14 -- Calculate triangular prism volume in Python

## Text

Write a C# function to find the volume of a triangular prism.

## Code

```csharp
public double FindVolume(double l, double b, double h) 
{ 
    return (l * b * h) / 2; 
}
```

## Test List

```csharp
Debug.Assert(FindVolume(10, 8, 6) == 240);
```

```csharp
Debug.Assert(FindVolume(3, 2, 2) == 6);
```

```csharp
Debug.Assert(FindVolume(1, 2, 1) == 1);
```
