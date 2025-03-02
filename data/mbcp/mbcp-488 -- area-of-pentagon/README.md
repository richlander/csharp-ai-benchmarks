# mbcp-488 -- Calculate the area of a pentagon using a function

## Text

Write a function to find the area of a pentagon.

## Code

```csharp
public static double AreaPentagon(double a)
{
    double area = (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(a, 2)) / 4.0;
    return area;
}
```

## Test List

```csharp
Debug.Assert(AreaPentagon(5) == 43.01193501472417);
```

```csharp
Debug.Assert(AreaPentagon(10) == 172.0477400588967);
```

```csharp
Debug.Assert(AreaPentagon(15) == 387.10741513251753);
```
