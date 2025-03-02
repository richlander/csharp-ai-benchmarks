# mbcp606 -- Convert degrees to radians using a function

## Text

Write a function to convert degrees to radians.

## Code

```csharp
public double RadianDegree(double degree)  
{  
    double radian = degree * (Math.PI / 180);  
    return radian;  
}
```

## Test List

```csharp
Debug.Assert(RadianDegree(90) == 1.5707963267948966);
```

```csharp
Debug.Assert(RadianDegree(60) == 1.0471975511965976);
```

```csharp
Debug.Assert(RadianDegree(120) == 2.0943951023931953);
```
