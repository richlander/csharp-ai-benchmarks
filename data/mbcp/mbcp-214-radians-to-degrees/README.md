# mbcp214 -- Convert radians to degrees in a simple function

## Text

Write a function to convert radians to degrees.

## Code

```csharp
public static double DegreeRadian(double radian)  
{  
    double degree = radian * (180 / Math.PI);  
    return degree;  
}
```

## Test List

```csharp
Debug.Assert(DegreeRadian(90) == 5156.620156177409);
```

```csharp
Debug.Assert(DegreeRadian(60) == 3437.746770784939);
```

```csharp
Debug.Assert(DegreeRadian(120) == 6875.493541569878);
```
